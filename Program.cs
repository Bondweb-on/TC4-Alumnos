using System;
using System.Collections.Generic;

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

            //Alumnos

            Alumno alumno1 = new Alumno("José", "Talamantes", 2759);
            Console.WriteLine("Primer alumno: " + alumno1.NombreCompleto);
            alumno1.Presentarse();

            //Materias

            Materia programacionI = new Materia("Programación I", 2);
            Console.WriteLine("La materia de " + programacionI.nombre + " se ve en " + programacionI.NombreSemestre);
            
            Materia inteligenciaArtificial = new Materia("Inteligencia Artificial", 7);
            Console.WriteLine("La materia de " + inteligenciaArtificial.nombre + " se ve en " + inteligenciaArtificial.NombreSemestre);

            // Lista
            // - <> operador diamante
            // - <Materia> contiene Materias
            // - Requiere inicialización!  
            List<Materia> materiasDeInteres = new List<Materia>();
            materiasDeInteres.Add(programacionI);
            materiasDeInteres.Add(inteligenciaArtificial);
            materiasDeInteres.Add(new Materia("Sistemas Interactivos I", 7));

            Console.WriteLine("La materia de " + materiasDeInteres[2].nombre + " se ve en " + materiasDeInteres[2].NombreSemestre);
            Console.WriteLine("Me interesan " + materiasDeInteres.Count + " materias");

            for (int i = 0; i < materiasDeInteres.Count; i++)
            {
                Console.WriteLine(materiasDeInteres[i].nombre);   
            }
            Console.WriteLine("...");
            materiasDeInteres.Remove(programacionI);
            Console.WriteLine("Ahora me interesan " + materiasDeInteres.Count + " materias");
            Console.WriteLine("Primer materia ahora es: " + materiasDeInteres[0].nombre);

            // Primer acercamiento; indicar indice a remover
            // materiasDeInteres.RemoveAt(1);

            // Segundo acercamiento; arrepentirnos y "crear" la variable
            // Materia sistemasInteractivosI = materiasDeInteres[1];
            // materiasDeInteres.Remove(sistemasInteractivosI);

            // Tercer acercamiento; buscar la variable a borrar
            Materia materiaABorrar = null;
            for (int i = 0; i < materiasDeInteres.Count; i++)
            {
                if (materiasDeInteres[i].nombre == "Sistemas Interactivos I")
                {
                    // Encontramos la materia que buscamos
                    // materiasDeInteres.RemoveAt(i);
                    // materiasDeInteres.Remove(materiasDeInteres[i]);
                    materiaABorrar = materiasDeInteres[i];

                    // Como ya la encontré, puedo interrumpir el ciclo
                    break;
                }
            }
            // Verificar si se encontró o no
            if (materiaABorrar != null)
            {
                // Si se encontró 
                materiasDeInteres.Remove(materiaABorrar);
            }


            Console.WriteLine("Ahora me interesan " + materiasDeInteres.Count + " materias");
            Console.WriteLine("Primer materia ahora es: " + materiasDeInteres[0].nombre);
        }
    }
}
