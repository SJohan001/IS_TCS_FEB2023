using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using ServiciosLinqEscolar.Modelo;

namespace ServiciosLinqEscolar
{
    [DataContract]
    public class Mensaje
    {
        [DataMember]
        public Boolean error { get; set; }
        
        [DataMember]
        public String mensaje { get; set; }
        
        [DataMember]
        public usuario usuarioLogin { get; set; }
    }
}