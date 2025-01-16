using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    internal class Fate
    {
        private Riddle riddle;
        private Haystack haystack;
        private string haystackId;

        public Fate(Riddle riddle, Haystack haystack, string haystackId)
        {
            this.riddle = riddle;
            this.haystack = haystack;
            this.haystackId = haystackId;
        }

        public Verdict IncorrectVerdict(string lastAttempt, string context)
        {
            return new Verdict(true, false, true, false, false, haystackId, riddle.Id, lastAttempt, context, this);
        }

        public Verdict NeedLessVerdict(string lastAttempt, string context)
        {
            return new Verdict(true, false, true, true, false, haystackId, riddle.Id, lastAttempt, context, this);
        }

        public Verdict NeedMoreVerdict(string lastAttempt, string context)
        {
            return new Verdict(true, false, true, false, true, haystackId, riddle.Id, lastAttempt, context, this);
        }

        public Verdict CorrectVerdict(string lastAttempt, string context)
        {
            return new Verdict(true, true, false, false, false, haystackId, riddle.Id, lastAttempt, context, this);
        }

        public Verdict IrrelevantVerdict(string lastAttempt, string context)
        {
            return new Verdict(false, false, false, false, false, haystackId, riddle.Id, lastAttempt, context, this);
        }

        public static Verdict FreshVerdict()
        {
            return new Verdict(true, false, false, false, false, "", "", "", "", null);
        }

        public static Verdict SkipKnown(String haystackId, string riddleId)
        {
            return new Verdict(true, false, false, false, false, haystackId, riddleId, "", "", null);
        }

        public static Verdict SkipUnknown(string haystackId)
        {
            return new Verdict(true, false, false, false, false, haystackId, "", "", "", null);
        }
    }
}
