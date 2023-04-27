using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServidorConvertidor
{
    [ServiceContract]
    internal interface IServicioMoneda
    {
        [OperationContract]
        Moneda peso_Dolar(double peso);
        [OperationContract]
        Moneda dolar_Peso(double dolar);
    }
}
