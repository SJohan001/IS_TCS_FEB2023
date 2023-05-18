// See https://aka.ms/new-console-template for more information

using System.Linq;
using LinqColection;


// Imprimir numeros pares

/*int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
Console.WriteLine("A continuación te mostramos lo numeros pares que existen en el arreglo");

/* Sin LINQ
List<int> numerosPares = new List<int>();
foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        numerosPares.Add(numero);
    }
}*/

// Con LINQ
/*IEnumerable<int> numerosPares = from numero in numeros 
                                where numero % 2 == 0 select numero;
//En la variable numero guardará lo que busque en numeros,
//pero solo si el residuo de numero es 0 se recupera numero y es enviado a numerosPares

// Impresión numeros pares
foreach (int numero in numerosPares)
{
    Console.WriteLine(numero);
}*/


// Ejemplo ControlAlumno objetos

ControlAlumnos controlAlumnos = new ControlAlumnos();
controlAlumnos.obternerAlumnosPorCarrera(2);