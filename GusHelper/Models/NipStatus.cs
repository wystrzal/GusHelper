using System.Xml.Serialization;

namespace GusHelper.Models
{
    public enum NipStatus
    {
        [XmlEnum("")]
        NoStatus,
        [XmlEnum("Uchylony")]
        Repealed,
        [XmlEnum("Unieważniony")]
        Canceled,
    }
}
