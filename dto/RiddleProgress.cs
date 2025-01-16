using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    internal abstract class RiddleProgress
    {
        public abstract bool IsFullySolved();
        public abstract bool IsPartiallySolved();
        public abstract int countMatching();
        public abstract void update(Verdict verdict);
        public static RiddleProgress ForRiddle(Riddle riddle)
        {
            if (riddle.HasMultipleAnswers())
            {
                return new MultipleAnswerRiddleProgress(riddle);
            } else
            {
                return new SingleAnswerRiddleProgress(riddle);
            }
        }
    }
}
