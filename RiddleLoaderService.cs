using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Collections;

namespace Sphinx
{
    public class RiddleLoaderService
    {
        public RiddleLoaderService()
        {

        }

        public string[] LoadHaystackNames()
        {
            string resxFile = @".\Haystacks.resx";
            List<string> names = new List<string>();
            using (ResXResourceReader resxReader = new ResXResourceReader(resxFile))
            {
                foreach (DictionaryEntry entry in resxReader)
                {
                    names.Add(entry.Key.ToString());
                }
                return names.ToArray();
            }
        }
    }
}
