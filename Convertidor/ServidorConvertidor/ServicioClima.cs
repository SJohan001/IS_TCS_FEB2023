using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServidorConvertidor
{
    internal class ServicioClima : IServicioClima
    {
        public Clima celcius_Fahrenheit(double celcius)
        {
            Clima clima = new Clima();
            clima.celcius = celcius;
            clima.fahrenheit = (celcius * 1.8) + 32;
            return clima;
        }

        public Clima fahrenheit_Celcius(double fahrenheit)
        {
            Clima clima = new Clima();
            clima.fahrenheit = fahrenheit;
            clima.celcius = ((fahrenheit - 32) * 5) / 9;
            return clima;
        }
    }
}
