using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    public class Verdict
    {
        public readonly bool relevant;
        public readonly bool correct;
        public readonly bool incorrect;
        public readonly bool needless;
        public readonly bool needmore;
        public readonly string haystackId;
        public readonly string riddleId;
        public readonly string lastAttemptText;
        public readonly string lastAttemptContext;
        public readonly Fate past;
        public Verdict(
bool relevant, bool correct, bool incorrect, bool needless, bool needmore, string haystackId, string riddleId, string lastAttemptText, string lastAttemptContext, Fate past)
        {
            this.relevant = relevant;
            this.correct = correct;
            this.incorrect = incorrect;
            this.needless = needless;
            this.needmore = needmore;
            this.haystackId = haystackId;
            this.riddleId = riddleId;
            this.lastAttemptText = lastAttemptText;
            this.lastAttemptContext = lastAttemptContext;
            this.past = past;
        }
    }
}
