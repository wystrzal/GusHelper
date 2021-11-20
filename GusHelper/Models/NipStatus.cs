using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
