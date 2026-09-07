using System;
namespace LibroCalificaciones_2
{
    public class LibroPruebaCalificaciones
    {
        static void Main(string[] args)
        {
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();
            
            //Pide el nombre del curso y lo recibe como entrada
            Console.WriteLine("Ingrese el nombre del curso: ");

            string nombreCurso = Console.ReadLine();//lee una linea de Texto
            Console.WriteLine();//Imprime en pantalla una linea en blanco
            //llama el metodo MostraMensaje de MiLibroCalificaciones
            //y pasa el nombre del curso como argumento

            MyLibro.MostrarMensaje(nombreCurso);
        }
    }
}
