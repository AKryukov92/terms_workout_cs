using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Collections;
using System.IO;
using System.Xml.Serialization;
using Sphinx.dto;
using System.Xml;

namespace Sphinx
{
    public class RiddleLoaderService
    {
        public RiddleLoaderService()
        {

        }

        public Meta LoadMeta()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Meta));
            using (Stream reader = new FileStream("./haystacks/meta.xml", FileMode.Open))
            {
                return (Meta)serializer.Deserialize(reader);
            }
        }

        public Haystack LoadHaystack(string haystackId)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Haystack));
            using (Stream reader = new FileStream("./haystacks/" + haystackId + ".xml", FileMode.Open))
            {
                Haystack haystack = (Haystack)serializer.Deserialize(reader);
                if (haystack.Riddles.Count == 0)
                {
                    throw new Exception("Задача не содержит вопросов");
                }
                return haystack;
            }
        }
    }
}
