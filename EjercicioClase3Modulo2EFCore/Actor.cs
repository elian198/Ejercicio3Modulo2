using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase3Modulo2EFCore
{
    [Table("actor")]
    public class Actor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nombre_Artistico { get; set; }
        public int Edad { get; set; }
        public string Nacionalidad { get; set; }
        public char Genero { get; set; }

        public Actor(string nombre, string apellido, string nombre_Artistico, int edad, string nacionalidad, char genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Nombre_Artistico = nombre_Artistico;
            Edad = edad;
            Nacionalidad = nacionalidad;
            Genero = genero;
        }

        public override string ToString()
        {
            return "Actor {" +
                " Id: " + Id + "," +
                " Nombre: " + Nombre + "," +
                " Apellido: " + Apellido + "," +
                " Nombre_Artistico: " + Nombre_Artistico +
                " Edad: " + Edad +
                " Nacionalidad: " + Nacionalidad +
                " Genero: " + Genero +
                "}";
        }
    } 
}
