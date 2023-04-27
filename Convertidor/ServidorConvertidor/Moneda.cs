using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServidorConvertidor
{
    [DataContract]
    internal class Moneda
    {
        [DataMember]
        public double peso { get; set; }
        [DataMember]
        public double dolar { get; set; }
    }
}
