using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqColection
{
    internal class ControlAlumnos
    {
        List<Carrera> carreras = new List<Carrera>();
        List<Alumno> alumnos = new List<Alumno>();

        public ControlAlumnos()
        {
            carreras.Add(new Carrera 
            { 
                idCarrera = 1, 
                nombre = "Ingeniería de software"
            });
            carreras.Add(new Carrera 
            { 
                idCarrera = 2, 
                nombre = "Redes y servicios de computo" 
            });

            alumnos.Add(new Alumno 
            { 
                idAlumno = 1, 
                nombre = "Juan Perez Sanchez", 
                matricula = "s00021684116", 
                promedio = 7.8, 
                idCarrera = 1 
            });
            alumnos.Add(new Alumno
            {
                idAlumno = 2,
                nombre = "Elian Patiño Marquez",
                matricula = "s05163096161",
                promedio = 7.5,
                idCarrera = 2
            });
            alumnos.Add(new Alumno
            {
                idAlumno = 3,
                nombre = "José Torres Jimenez",
                matricula = "s01516091618",
                promedio = 6.5,
                idCarrera = 2
            });
        }

        public void obternerAlumnosPorCarrera(int idCarrera)
        {
            IEnumerable<Alumno> resultado = from alumno in alumnos
                                            join carrera in carreras on alumno.idCarrera equals carrera.idCarrera
                                            where alumno.idCarrera == idCarrera
                                            select alumno;

            foreach(Alumno alumno in resultado)
            {
                alumno.getDatosAlumno(carreras);
            }
        }
    }
}