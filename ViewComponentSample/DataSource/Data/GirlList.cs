using System.Collections.Generic;
using System.Xml.Serialization;

namespace ViewComponentSample.DataSource.Data
{
    [XmlRoot("GirlList")]
    public class GirlList
    {
        [XmlElement("GirlInfoItem")]
        public List<GirlInfo> GirlInfoItems { get; set; }
    }
}
