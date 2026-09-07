using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad3_Variables_de_Instancia_y_Propiedades
{
    internal class LibroCalificaciones
    {
        private string nombreCurso;

        public LibroCalificaciones(string nombre)
        {
            nombreCurso = nombre;
        }

        public string NombreCurso
        {
            get
            { return nombreCurso; }

            set
            { nombreCurso = value; }

        }

        public void MostrarMensaje()
        {
          Console.WriteLine("\nBienvenido al libro de calificaciones para \n {0}", NombreCurso);
        }
    }
}
