using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor_Alumno
{
    internal class Profesor
    {
        private string nombre;
        private Alumno alumno= new Alumno();

        public string Nombre { get => nombre; set => nombre = value; }
        internal Alumno Alumno { get => alumno; set => alumno = value; }

        public void capturarDatosAlumno()
        {
            Console.WriteLine("Agregue número de lista del alumno:");
            alumno.Nl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Agregue nombre del alumno:");
            alumno.Nombre = Console.ReadLine();
        }

        public void capturarMaterias(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string ma;
                Console.WriteLine("Ingrese nombre de materia "+(i+1));
                ma = Console.ReadLine();
                alumno.agregarMaterias(ma);
            }
        }

        public void capturarCalificaciones(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int cal;
                Console.WriteLine("Ingrese calificación de materia " + alumno.Materias[i]);
                cal = Convert.ToInt32(Console.ReadLine());
                alumno.agregarCalificaciones(cal);
            }
           
        }
    }
}
