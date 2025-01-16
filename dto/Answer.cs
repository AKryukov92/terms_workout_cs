using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Sphinx.dto
{
    internal class Answer
    {
        private readonly string minimal;
        private readonly string maximal;
        private readonly string context;

        public string[] getContextFragments()
        {
            return Regex.Split(context, "\\s+");
        }

        public bool Matches(string[] attemptTokens)
        {
            string[] minimalTokens = Regex.Split(minimal, "\\s+");
            string[] maximalTokens = Regex.Split(maximal, "\\s+");
            bool matchesMinimal = Haystack.IndexOfInArr(attemptTokens, minimalTokens) >= 0;
            bool matchesMaximal = Haystack.IndexOfInArr(maximalTokens, attemptTokens) >= 0;
            return matchesMinimal && matchesMaximal;
        }

        public bool IsNeedLess(string[] attemptTokens)
        {
            string[] maximalTokens = Regex.Split(minimal, "\\s+");
            return Haystack.IndexOfInArr(attemptTokens, maximalTokens) >= 0;
        }

        public bool IsNeedMore(string[] attemptTokens)
        {
            string[] minimalTokens = Regex.Split(maximal, "\\s+");
            return Haystack.IndexOfInArr(minimalTokens, attemptTokens) >= 0;
        }

        public bool IsMinimal(string[] attemptTokens)
        {
            return Regex.Split(minimal, "\\s+").Equals(attemptTokens);
        }

        public bool IsMaximal(string[] attemptTokens)
        {
            return Regex.Split(maximal, "\\s+").Equals(attemptTokens);
        }

        public bool RelevantTo(String[] grain)
        {
            String[] minimalTokens = Regex.Split(minimal, "\\s+");
            String[] maximalTokens = Regex.Split(maximal, "\\s+");
            bool matchesMinimal = Haystack.IndexOfInArr(grain, minimalTokens) >= 0;
            bool matchesMaximal = Haystack.IndexOfInArr(grain, maximalTokens) >= 0;
            return matchesMinimal && matchesMaximal;
        }

        public override string ToString()
        {
            return "Answer{" +
                "minimal='" + minimal + '\'' +
                ", maximal='" + maximal + '\'' +
                ", context='" + (context != null ? context : maximal) + '\'' +
                '}';
        }
    }
}
