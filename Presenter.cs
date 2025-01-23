using Sphinx.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sphinx
{
    internal class Presenter
    {
        private readonly IView view;
        private readonly RiddleLoaderService RiddleLoaderService;
        private readonly Random rnd;
        private readonly Journey journey;
        private Riddle currentRiddle;
        private Haystack currentHaystack;
        private string currentHaystackId;

        public Presenter(IView view)
        {
            this.view = view;
            RiddleLoaderService = new RiddleLoaderService();
            rnd = new Random();
            journey = new Journey();
        }
        public void Init()
        {
            try
            {
                Meta m = RiddleLoaderService.LoadMeta();
                view.ShowMeta(m);
            }
            catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
        public void LoadHaystackById(string haystackId)
        {
            try
            {
                currentHaystackId = haystackId;
                currentHaystack = RiddleLoaderService.LoadHaystack(haystackId);
                var progress = new HaystackProgress(haystackId, currentHaystack, journey.verdicts);
                view.ReportProgress(progress);
                currentRiddle = currentHaystack.getFreshRiddle(rnd, haystackId, progress);
                if (currentRiddle != null)
                {
                    view.ShowRiddle(currentHaystack.wheat, currentRiddle.Needle);
                    view.ShowVerdict(Fate.FreshVerdict());
                    List<HighlightRange> ranges = journey.GetSuccessfulAttempts(currentHaystack.Grain, currentRiddle.Id);
                    HighlightRange.JoinRanges(ranges);
                    view.HighlightAnswers(ranges);
                } else
                {
                    view.ShowError("Не удалось найти задачу");
                }
            } catch (Exception ex)
            {
                view.ShowError(ex.Message);
            }
        }
        public void Guess(string originalAttempt, string originalContext)
        {
            var verdict = Decide(originalAttempt, originalContext);
            journey.AddStep(verdict);
            view.ShowVerdict(verdict);
            List<HighlightRange> ranges = journey.GetSuccessfulAttempts(currentHaystack.Grain, currentRiddle.Id);
            HighlightRange.JoinRanges(ranges);
            view.HighlightAnswers(ranges);
        }

        public Verdict Decide(string originalAttempt, string originalContext)
        {
            if (currentHaystack == null || currentRiddle == null || currentHaystackId == null)
            {
                throw new Exception("Попытка решить неопределенную задачу");
            }
            Fate past = new Fate(currentRiddle, currentHaystack, currentHaystackId);
            string attempt = Regex.Replace(originalAttempt, "\\s+", " ").Trim();
            string context = Regex.Replace(originalContext, "\\s+", " ").Trim();
            string[] attemptTokens = attempt.Split(' ');
            string[] contextTokens = context.Split(' ');
            if (!currentHaystack.IsRelevant(attemptTokens))
            {
                return past.IrrelevantVerdict(originalAttempt, originalContext);
            }
            if (currentRiddle.IsCorrect(attemptTokens, contextTokens))
            {
                return past.CorrectVerdict(originalAttempt, originalContext);
            }
            else
            {
                if (currentRiddle.IsNeedLess(attemptTokens))
                {
                    return past.NeedLessVerdict(originalAttempt, originalContext);
                }
                else if (attempt.Length > 3 && currentRiddle.IsNeedMore(attemptTokens))
                {
                    return past.NeedMoreVerdict(originalAttempt, originalContext);
                }
                else
                {
                    return past.IncorrectVerdict(originalAttempt, originalContext);
                }
            }
        }
    }
}
