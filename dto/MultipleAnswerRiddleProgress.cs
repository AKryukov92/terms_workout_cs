using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    internal class MultipleAnswerRiddleProgress : RiddleProgress
    {
        private readonly Riddle riddle;
        private HashSet<Answer> matching;
        private HashSet<Answer> minimal;
        private HashSet<Answer> maximal;

        public MultipleAnswerRiddleProgress(Riddle riddle)
        {
            this.riddle = riddle;
            this.matching = new HashSet<Answer>();
            this.minimal = new HashSet<Answer>();
            this.maximal = new HashSet<Answer>();
        }

        public override int countMatching()
        {
            return matching.Count;
        }

        public override bool IsFullySolved()
        {
            return matching.Count == riddle.Answers.Count;
        }

        public override bool IsPartiallySolved()
        {
            return matching.Count != 0;
        }

        public override void update(Verdict verdict)
        {
            foreach (var answer in riddle.Answers)
            {
                string[] attemptTokens = Regex.Split(verdict.lastAttemptText, "\\s+");
                string[] contextTokens = Regex.Split(verdict.lastAttemptContext, "\\s+");
                if (answer.Matches(attemptTokens, contextTokens))
                {
                    matching.Add(answer);
                }
                if (answer.IsMinimal(attemptTokens))
                {
                    minimal.Add(answer);
                }
                if (answer.IsMaximal(attemptTokens))
                {
                    maximal.Add(answer);
                }
            }
        }
    }
}
