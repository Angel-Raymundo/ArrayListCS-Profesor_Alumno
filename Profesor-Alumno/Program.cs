using System;
using System.Data;
using Profesor_Alumno;

int numMat;
Dictionary<string, string> diccionario = new Dictionary<string, string>();

Profesor p = new Profesor();
Console.WriteLine("Ingrese nombre Profesor: ");
p.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese los datos del alumno: \n ¿Cuantas materias tiene? ");
numMat = Convert.ToInt32(Console.ReadLine());
p.capturarDatosAlumno();
p.capturarMaterias(numMat);
p.capturarCalificaciones(numMat);


Console.WriteLine("\nMostrando datos...");
Console.WriteLine("==================");
Console.WriteLine("Nombre profesor: " + p.Nombre);
Console.WriteLine("\n===Datos alumno:=== ");
Console.WriteLine("NL alumno: " + p.Alumno.Nl);
Console.WriteLine("Nombre alumno: " + p.Alumno.Nombre);
Console.WriteLine("\n===Materias===");


for (int i = 0; i < p.Alumno.Materias.Count; i++)
{
    diccionario.Add(p.Alumno.Materias[i].ToString(), p.Alumno.Calificaciones[i].ToString());

}

foreach (var elementos in diccionario)
    Console.WriteLine(elementos.ToString());