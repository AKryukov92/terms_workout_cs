using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    internal class HaystackProgress
    {
        public string HaystackId { get; private set; }
        public Haystack Haystack { get; private set; }
        public Dictionary<string, RiddleProgress> RiddlesProgress
        {
            get; private set;
        }

        public HaystackProgress(string haystackId, Haystack haystack, List<Verdict> verdicts)
        {
            HaystackId = haystackId;
            Haystack = haystack;
            RiddlesProgress = new Dictionary<string, RiddleProgress>();
            foreach (var riddle in haystack.Riddles)
            {
                RiddlesProgress.Add(riddle.Id, RiddleProgress.ForRiddle(riddle));
            }
            foreach (var verdict in verdicts)
            {
                if (verdict.haystackId == haystackId)
                {
                    Update(verdict);
                }
            }
        }

        public int MaxProgress() {  return RiddlesProgress.Count; }
        public int CurrentProgress()
        {
            return RiddlesProgress.Values.Where(r => r.IsPartiallySolved()).Count();
        }
        public int MaxAnswerProgress()
        {
            return Haystack.Riddles.Select(r => r.Answers.Count).Sum();
        }
        public int CurrentAnswerProgress()
        {
            return RiddlesProgress.Values.Select(rp => rp.countMatching()).Sum();
        }

        public void Update(Verdict verdict)
        {
            if (verdict.haystackId != HaystackId)
            {
                return;
            }
            if (RiddlesProgress.ContainsKey(verdict.riddleId))
            {
                return;
            }
            RiddleProgress progress = RiddlesProgress[verdict.riddleId];
            progress.update(verdict);
        }
    }
}
