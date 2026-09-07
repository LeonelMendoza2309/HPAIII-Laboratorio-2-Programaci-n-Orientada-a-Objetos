using Actividad3_Variables_de_Instancia_y_Propiedades;
internal class program
{
    static void Main(string[] args)
    {
        LibroCalificaciones myLibro = new LibroCalificaciones("CS101 Programacion en C#");
        LibroCalificaciones myLibro2 = new LibroCalificaciones("CS102 Estructurade datos");

        Console.WriteLine("El nombre del curso es: {0}", myLibro.NombreCurso);
        Console.WriteLine("El nombre del curso es: {0}", myLibro2.NombreCurso);

        Console.WriteLine("\nEscriba el nombre del curso porfavor: ");

        string cursNomb = Console.ReadLine();

        myLibro.NombreCurso = cursNomb;
        Console.WriteLine("\nEl nombre del curso es: {0}\n", myLibro.NombreCurso);

        myLibro.MostrarMensaje();
        myLibro2.MostrarMensaje();
    }
}