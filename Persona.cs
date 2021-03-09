using System;

namespace TC4_Alumnos
{
    class Persona
    {       
        public string apellido;
        public string nombre;

        public string NombreCompleto
        {
            get => this.nombre + " " + this.apellido;
        }

        private string colorFavorito;

        public string ColorFavorito
        {
            get => "color " + this.colorFavorito;
            set => this.colorFavorito = value;
        }

        // Método constructor
        public Persona(string nombre, string apellido)
        {       
            this.apellido = apellido;

            this.nombre = nombre;
        }

        public virtual void Presentarse()
        {
            Console.WriteLine("Hola, mi nombre es " + this.NombreCompleto);
        }
    }
}