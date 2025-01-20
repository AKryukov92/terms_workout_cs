using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx.dto
{
    public class HighlightRange
    {
        private readonly int startIndex;
        private readonly int endIndex;

        public HighlightRange(int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                throw new ArgumentException("Start index should be less than end index");
            }
            this.startIndex = startIndex;
            this.endIndex = endIndex;
        }

        public bool Contains(HighlightRange range)
        {
            return this.startIndex <= range.startIndex && range.endIndex <= this.endIndex;
        }

        public bool Intersects(HighlightRange range) {
            return range.startIndex  < this.endIndex &&  this.startIndex < range.endIndex;
        }

        public HighlightRange ConnectWith(HighlightRange range)
        {
            if (!Intersects(range))
            {
                return null;
            }
            if (this.startIndex <= range.startIndex)
            {
                if (this.endIndex < range.endIndex)
                {
                    return new HighlightRange(this.startIndex, range.endIndex);
                }
                else
                {
                    return new HighlightRange(startIndex, this.endIndex);
                }
            }
            else
            {
                if (this.endIndex <= range.endIndex)
                {
                    return new HighlightRange(range.startIndex, range.endIndex);
                }
                else
                {
                    return new HighlightRange(range.startIndex, this.endIndex);
                }
            }
        }

        public override bool Equals(object obj)
        {
            return obj is HighlightRange range &&
                   startIndex == range.startIndex &&
                   endIndex == range.endIndex;
        }

        public override int GetHashCode()
        {
            int hashCode = 755297355;
            hashCode = hashCode * -1521134295 + startIndex.GetHashCode();
            hashCode = hashCode * -1521134295 + endIndex.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "[" + startIndex + ";" + endIndex + ")";
        }

        public static void JoinRanges(List<HighlightRange> ranges)
        {
            ranges.Sort((a, b) =>
            {
                if (a.startIndex == b.startIndex)
                {
                    return a.endIndex - b.endIndex;
                } else
                {
                    return a.startIndex - b.startIndex;
                }
            });
            int toCon = 0;
            while(toCon < ranges.Count - 1)
            {
                HighlightRange cur = ranges[toCon];
                HighlightRange next = ranges[toCon + 1];
                if (cur.Intersects(next))
                {
                    int finalToCon = toCon;
                    var res = cur.ConnectWith(next);
                    if (res != null)
                    {
                        ranges.RemoveAt(finalToCon);
                        ranges.RemoveAt(finalToCon);
                        ranges.Insert(finalToCon, res);
                    }
                } else
                {
                    toCon++;
                }
            }
        }
        public static List<HighlightRange> HighlightAll(string[] grain, string[] fragments, string[] context)
        {
            List<HighlightRange> result = new List<HighlightRange>();
            int minusChars= Haystack.IndexOfInArr(context, fragments, 0);
            int start = Haystack.IndexOfInArr(grain, fragments, 0);
            int contextStart = Haystack.IndexOfInArr(grain, context, start >= minusChars ? start - minusChars : 0);
            int contextEnd = contextStart + LengthOf(context);
            while( start >=0)
            {
                int end = start + LengthOf(fragments);
                if (contextStart <= start && end <= contextEnd)
                {
                    result.Add(new HighlightRange(start, end));
                }
                start = Haystack.IndexOfInArr(grain, fragments, end);
                contextStart = Haystack.IndexOfInArr(grain, context, start >= minusChars ? start - minusChars : 0);
                contextEnd = contextStart + LengthOf(context);
            }
            return result;
        }

        public static int LengthOf(string[] grain)
        {
            return grain.Sum(g => g.Length);
        }
    }
}
