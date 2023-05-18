using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColection
{
    internal class Carrera
    {
        public int idCarrera { get; set; }
        public string nombre { get; set; }

        public void getDatosCarrera()
        {
            Console.WriteLine("Carrera {0} con ID {1}",nombre,idCarrera);
        }
    }
}
