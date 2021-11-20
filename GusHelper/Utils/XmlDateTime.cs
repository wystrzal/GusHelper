using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GusHelper.Utils
{
    public class XmlDateTime : IXmlSerializable
    {
        public DateTime Date { get; set; }

        public void ReadXml(XmlReader reader)
        {
            if (reader.IsEmptyElement)
            {
                reader.ReadStartElement();
                return;
            }

            string date = reader.ReadInnerXml();
            if (!string.IsNullOrWhiteSpace(date))
            {
                Date = XmlConvert.ToDateTime(date, "yyyy-MM-dd");
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            if (Date == DateTime.MinValue)
            {
                return;
            }
            writer.WriteRaw(XmlConvert.ToString(Date, "yyyy-MM-dd"));
        }

        public XmlSchema GetSchema() => null;
    }
}
