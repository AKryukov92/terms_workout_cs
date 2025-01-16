using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    internal class Riddle
    {
        public string Id { get; private set; }
        public string Needle { get; private set; }
        public List<Answer> Answers { get; private set; }
        public bool HasMultipleAnswers()
        {
            return Answers.Count > 1;
        }

        public bool IsCorrect(string[] tokens)
        {
            //String[] tokens = Regex.Split(attempt, "\\s+");
            return Answers.Exists((a) => a.Matches(tokens));
        }

        public bool IsNeedLess(string[] tokens)
        {
            //String[] tokens = Regex.Split(attempt, "\\s+");
            return Answers.Exists((a) => a.IsNeedLess(tokens));
        }

        public bool IsNeedMore(string[] tokens)
        {
            //String[] tokens = Regex.Split(attempt, "\\s+");
            return Answers.Exists((a) => a.IsNeedMore(tokens));
        }

        public void AssertRelevant(String[] grain)
        {
            foreach (var a in Answers)
            {
                if (!a.RelevantTo(grain))
                {
                    throw new Exception(grain[0]);
                }
            }
        }
        public List<HighlightRange> ExtractRanges(string[] grain, Func<Answer, string[]> f)
        {
            return Answers.SelectMany(a =>
                HighlightRange.HighlightAll(grain, f.Invoke(a), a.getContextFragments())
            ).ToList();
        }
    }
}
