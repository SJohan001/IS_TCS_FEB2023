using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServidorConvertidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioMoneda : IServicioMoneda
    {
        Moneda IServicioMoneda.dolar_Peso(double dolar)
        {
            Moneda moneda = new Moneda();
            moneda.dolar = dolar;
            moneda.peso = dolar * 18.18;
            return moneda;
        }

        Moneda IServicioMoneda.peso_Dolar(double peso)
        {
            Moneda moneda = new Moneda();
            moneda.peso = peso;
            moneda.dolar = peso / 18.18;
            return moneda;
        }
    }
}
