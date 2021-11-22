using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GusHelper.Utils
{
    public sealed class XmlDateTime : IXmlSerializable
    {
        public DateTime DateTime { get; set; }

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
                DateTime = XmlConvert.ToDateTime(date, "yyyy-MM-dd");
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            if (DateTime == DateTime.MinValue) return;
            writer.WriteRaw(XmlConvert.ToString(DateTime, "yyyy-MM-dd"));
        }

        public XmlSchema GetSchema() => null;
    }
}
