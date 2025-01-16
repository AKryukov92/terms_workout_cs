using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    internal class Journey
    {
        public List<Verdict> verdicts;
        public Journey()
        {
            verdicts = new List<Verdict>();
        }
        public void AddStep(Verdict verdict)
        {
            verdicts.Add(verdict);
        }
        public List<HighlightRange> GetSuccessfulAttempts(string[] grain, string riddleId)
        {
            return verdicts.Where(step => step.correct && step.riddleId == riddleId).
                SelectMany(step => HighlightRange.HighlightAll(
                    grain, Regex.Split(step.lastAttemptText, "\\s+"), Regex.Split(step.lastAttemptContext, "\\s+")
                )).ToList();
        }
    }
}
