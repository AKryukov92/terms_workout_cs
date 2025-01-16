using Sphinx.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx
{
    internal class Haystack
    {
        private string wheat;
        private string name;
        private List<Riddle> riddles;
        public IList<Riddle> Riddles { get {  return riddles.AsReadOnly(); } }

        public Riddle getFreshRiddle(Random rnd, string haystackId, HaystackProgress progress)
        {
            if (progress.CurrentProgress() < progress.MaxProgress())
            {
                string key = progress.RiddlesProgress.Where(pair => !pair.Value.IsPartiallySolved())
                    .First().Key;
                return getRiddle(key);
            } 
            else
            {
                List<string> notFullySolvedRiddles = progress.RiddlesProgress.Where(r => !r.Value.IsFullySolved()).Select(r => r.Key).ToList();
                if (notFullySolvedRiddles.Count > 0)
                {
                    int next = rnd.Next(notFullySolvedRiddles.Count);
                    return getRiddle(notFullySolvedRiddles[next]);
                } else
                {
                    return null;
                }
            }
        }

        public static int IndexOfInArr(String[] arr, String[] subarr)
        {
            return IndexOfInArr(arr, subarr, 0);
        }

        public static int IndexOfInArr(string[] arr, string[] subarr, int fromIndex)
        {
            int remaining = fromIndex;
            int substracted = 0;
            int currentArrIndex = 0;
            while(remaining > arr[currentArrIndex].Length)
            {
                remaining -= arr[currentArrIndex].Length;
                substracted += arr[currentArrIndex].Length;
                currentArrIndex++;
            }
            int position = substracted;
            if (subarr.Length == 1)
            {
                for (int i = currentArrIndex; i < arr.Length; i++)
                {
                    int initial = arr[i].IndexOf(subarr[0], remaining);
                    remaining = 0;
                    if (initial >= 0)
                    {
                        position += initial;
                        return position;
                    }
                    position += arr[i].Length;
                }
                return -1;
            }
            for (int i = currentArrIndex; i< arr.Length - subarr.Length + 1; i++)
            {
                if (arr[i].Substring(remaining).EndsWith(subarr[0]))
                {
                    int initial = arr[i].Substring(remaining).LastIndexOf(subarr[0]);
                    position += remaining;
                    int checkIndex = i + 1;
                    bool found = true;
                    for (int j = 1; j < subarr.Length - 1; j++)
                    {
                        if (!subarr[j].Equals(arr[checkIndex]))
                        {
                            found = false; break;
                        }
                        checkIndex++;
                    }
                    if (found && arr[checkIndex].StartsWith(subarr[subarr.Length - 1]))
                    {
                        return position + initial;
                    }
                }
                position += arr[i].Length;
                remaining = 0;
            }
            return -1;
        }

        public Riddle getRiddle(string riddleId)
        {
            return riddles.Find(r => r.Id == riddleId);
        }

        public Riddle getRiddleByNeedle(string needle)
        {
            return riddles.Find(r => r.Needle == needle);
        }

        public void AddRiddle(Riddle riddle)
        {
            riddles.Add(riddle);
        }

    }
}
