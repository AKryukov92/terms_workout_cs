using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sphinx.dto
{
    [Serializable, XmlRoot("riddle")]
    public class Riddle
    {
        [XmlElement(ElementName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "needle")]
        public string Needle { get; set; }
        [XmlElement(ElementName = "answer")]
        public List<Answer> Answers { get; set; }

        public Riddle()
        {
        }

        public Riddle(string id, string needle, List<Answer> answers)
        {
            Id = id;
            Needle = needle;
            Answers = answers;
        }

        public bool HasMultipleAnswers()
        {
            return Answers.Count > 1;
        }

        public bool IsCorrect(string[] attemptTokens, string[] contextTokens)
        {
            return Answers.Exists((a) => a.Matches(attemptTokens, contextTokens));
        }

        public bool IsNeedLess(string[] tokens)
        {
            return Answers.Exists((a) => a.IsNeedLess(tokens));
        }

        public bool IsNeedMore(string[] tokens)
        {
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
                HighlightRange.HighlightAll(grain, f.Invoke(a), a.ContextTokens)
            ).ToList();
        }
    }
}
