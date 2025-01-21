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
                var verdict = past.IrrelevantVerdict(originalAttempt, originalContext);
                journey.AddStep(verdict);
                view.ShowVerdict(verdict);
            }
            if (currentRiddle.IsCorrect(attemptTokens, contextTokens))
            {
                Riddle nextRiddle = currentHaystack.GetRiddle(rnd);
                var verdict = past.CorrectVerdict(originalAttempt, originalContext);
                journey.AddStep(verdict);
                view.ShowVerdict(verdict);
            }
            ....
        }
    }
}
