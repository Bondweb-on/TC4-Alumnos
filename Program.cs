using System;

namespace TC4_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Jonathan", "Hernandéz");
            Console.WriteLine(persona1.NombreCompleto);
            persona1.Presentarse();

            persona1.apellido = "Rodríguez";
            Console.WriteLine(persona1.NombreCompleto);
            persona1.Presentarse();

            persona1.ColorFavorito = "Rojo";

            Console.WriteLine(persona1.ColorFavorito);

            Alumno alumno1 = new Alumno("José", "Talamantes", 2759);
            Console.WriteLine("Primer alumno: " + alumno1.NombreCompleto);
            alumno1.Presentarse();
           
        }
    }
}
