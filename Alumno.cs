using System;

namespace TC4_Alumnos
{
    class Alumno : Persona
    {       

        public int matricula;
        //Todos los alumnos son de la misma escuela (en este programa)
        static public string escuela = "CRESP";
        public Alumno(string nombre, string apellido, int matricula) : base(nombre, apellido)
        {
            this.matricula = matricula;
        }

        public override void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombre es {this.NombreCompleto} y soy estudiante en {Alumno.escuela} con matrícula {this.matricula}");
        }
    }
}