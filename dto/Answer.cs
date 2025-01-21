using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace Sphinx.dto
{
    public class Answer
    {
        [XmlElement(ElementName = "min")]
        public string minimal;
        [XmlElement(ElementName = "max")]
        public string maximal;
        [XmlElement(ElementName = "context")]
        public string context;

        public Answer()
        {
        }

        public Answer(string minimal, string maximal, string context)
        {
            this.minimal = minimal;
            this.maximal = maximal;
            this.context = context;
        }

        private string[] _minimalTokens;
        private string[] _maximalTokens;
        private string[] _contextTokens;
        public string[] MinimalTokens
        {
            get
            {
                if (_minimalTokens == null)
                {
                    _minimalTokens = Regex.Split(minimal, "\\s+");
                }
                return _minimalTokens;
            }
        }
        public string[] MaximalTokens
        {
            get
            {
                if (_maximalTokens == null)
                {
                    _maximalTokens = Regex.Split(maximal, "\\s+");
                }
                return _maximalTokens;
            }
        }
        public string[] ContextTokens
        {
            get
            {
                if (_contextTokens == null)
                {
                    _contextTokens = Regex.Split(context, "\\s+");
                }
                return _contextTokens;
            }
        }

        public bool Matches(string[] attemptTokens, string[] answerContext)
        {
            bool matchesMinimal = Haystack.IndexOfInArr(attemptTokens, MinimalTokens) >= 0;
            bool matchesMaximal = Haystack.IndexOfInArr(MaximalTokens, attemptTokens) >= 0;
            bool matchesContext = Haystack.IndexOfInArr(answerContext, ContextTokens) >= 0;
            return matchesMinimal && matchesMaximal && matchesContext;
        }

        public bool IsNeedLess(string[] attemptTokens)
        {
            return Haystack.IndexOfInArr(attemptTokens, MaximalTokens) >= 0;
        }

        public bool IsNeedMore(string[] attemptTokens)
        {
            return Haystack.IndexOfInArr(MinimalTokens, attemptTokens) >= 0;
        }

        public bool IsMinimal(string[] attemptTokens)
        {
            return MinimalTokens.Equals(attemptTokens);
        }

        public bool IsMaximal(string[] attemptTokens)
        {
            return MaximalTokens.Equals(attemptTokens);
        }

        public bool RelevantTo(String[] grain)
        {
            bool matchesMinimal = Haystack.IndexOfInArr(grain, MinimalTokens) >= 0;
            bool matchesMaximal = Haystack.IndexOfInArr(grain, MaximalTokens) >= 0;
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
