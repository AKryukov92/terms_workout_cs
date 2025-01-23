using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    internal class SingleAnswerRiddleProgress : RiddleProgress
    {
        private readonly Riddle riddle;
        private bool matchingGiven;
        private bool minimalGiven;
        private bool maximalGiven;
        private readonly Answer answer;

        public SingleAnswerRiddleProgress(Riddle riddle)
        {
            this.riddle = riddle;
            this.matchingGiven = false;
            this.minimalGiven = false;
            this.maximalGiven = false;
            this.answer = riddle.Answers[0];
        }

        public override bool IsFullySolved()
        {
            return matchingGiven;
        }

        public override bool IsPartiallySolved()
        {
            return matchingGiven;
        }

        public override int countMatching()
        {
            return matchingGiven ? 1 : 0;
        }

        public override void update(Verdict verdict)
        {
            string[] attemptTokens = Regex.Split(verdict.lastAttemptText, "\\s+");
            string[] contextTokens = Regex.Split(verdict.lastAttemptContext, "\\s+");
            if (answer.Matches(attemptTokens, contextTokens))
            {
                matchingGiven = true;
            }
            if (answer.IsMinimal(attemptTokens))
            {
                minimalGiven = true;
            }
            if (answer.IsMaximal(attemptTokens))
            {
                maximalGiven = true;
            }
        }
    }
}
