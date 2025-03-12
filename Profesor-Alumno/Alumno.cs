using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor_Alumno
{
    internal class Alumno
    {
        private int nl;
        private string nombre;
        private ArrayList materias = new ArrayList();
        private ArrayList calificaciones = new ArrayList();

        public int Nl { get => nl; set => nl = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public ArrayList Materias { get => materias; set => materias = value; }
        public ArrayList Calificaciones { get => calificaciones; set => calificaciones = value; }

        public void agregarMaterias(string materia)
        {
            materias.Add(materia);
        }

        public void agregarCalificaciones(int calificacion)
        {
            calificaciones.Add(calificacion);
        }
    }
}
