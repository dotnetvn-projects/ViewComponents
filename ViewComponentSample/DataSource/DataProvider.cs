using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ViewComponentSample.DataSource.Data;

namespace ViewComponentSample.DataSource
{
    public class DataProvider
    {
        public async Task<GirlList> ReadSampleData()
        {
            var task = Task.Factory.StartNew(() => {
                XmlSerializer ser = new XmlSerializer(typeof(GirlList));

                XmlDocument doc = new XmlDocument();
                doc.Load(@"DataSource\SampleData.xml");
                string xmlcontents = doc.InnerXml;

                using (StringReader sr = new StringReader(xmlcontents))
                {
                    return (GirlList)ser.Deserialize(sr);
                }
            });

            var result = await task;

            return result;
        }
    }
}
