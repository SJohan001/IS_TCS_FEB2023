using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColection
{
    internal class Alumno
    {
        public int idAlumno { get; set; }
        public string nombre { get; set; }
        public string matricula { get; set; }
        public double promedio { get; set; }
        public int idCarrera { get; set; }

        public void getDatosAlumno(List<Carrera> carreras)
        {
            Carrera carrera = carreras.FirstOrDefault(c => c.idCarrera == idCarrera);
            if (carrera != null)
            {
                Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} " +
                    "en la carrera {3} con ID {4}", 
                    nombre, matricula, promedio, carrera.nombre, idCarrera);
            }
            else
            {
                Console.WriteLine("Alumno {0} con matricula {1} y promedio {2} " +
                    "en una carrera no encontrada con ID {3}", 
                    nombre, matricula, promedio, idCarrera);
            }
        }
    }
}
