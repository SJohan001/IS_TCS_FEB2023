using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServidorConvertidor
{
    [ServiceContract]
    internal interface IServicioClima
    {
        [OperationContract]
        Clima fahrenheit_Celcius(double fahrenheit);
        [OperationContract]
        Clima celcius_Fahrenheit(double celcius);
    }
}
