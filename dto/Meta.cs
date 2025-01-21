using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Sphinx.dto
{
    [Serializable, XmlRoot("root")]
    public class Meta
    {
        [XmlElement(ElementName = "theme")]
        public MetaTheme[] themes;
    }

    [Serializable]
    public class MetaTheme
    {
        [XmlElement(ElementName ="haystack")]
        public MetaHaystack[] haystacks;

        [XmlAttribute()]
        public string name;
    }

    [Serializable]
    public class MetaHaystack
    {
        [XmlAttribute()]
        public string name;
        [XmlAttribute()]
        public string id;
    }
}
