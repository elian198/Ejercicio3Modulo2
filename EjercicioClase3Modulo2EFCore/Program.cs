using Microsoft.EntityFrameworkCore;

namespace EjercicioClase3Modulo2EFCore
{
    internal class Program
    {
        static void Main( string[] args )
        {
            #region Pasos previos
            //Ejecutar el script de base de datos en Management Studio para crear la base de datos y la tabla con datos
            //Instalar Microsoft.EntityFrameworkCore y Microsoft.EntityFrameworkCore.SqlServer
            //Crear las entidades necesarias
            //Crear el dbcontext
            //Configurar aqui el connection string e instanciar el contexto de la base de datos.
            #endregion
            #region ejercicio 1
            //Obtener un listado de todos los actores y actrices de la tabla actor

            #endregion
            var options = new DbContextOptionsBuilder<BDContext>();
            options.UseSqlServer("Data Source=DESKTOP-KICGD37;Initial Catalog=SimpleIMDB;Integrated Security=True;Trust Server Certificate=True");
            var context = new BDContext(options.Options);

            #region ejercicio 2
            //Obtener listado de todas las actrices de la tabla actor
            context.Actor.Where(actor => actor.Genero == 'F').ToList().ForEach(actor => Console.WriteLine(actor));
            #endregion

            #region ejercicio 3
            //Obtener un listado de todos los actores y actrices mayores de 50 años de la tabla actor
            Console.WriteLine("---------------------------------------------------------");
            context.Actor.Where(actor => actor.Edad > 50).ToList().ForEach(actor => Console.WriteLine(actor));
            #endregion

            #region ejercicio 4
            //Obtener la edad de la actriz "Julia Roberts"
            Console.WriteLine("---------------------------------------------------------");
            context.Actor.Where(actor => actor.Nombre == "Julia" && actor.Apellido == "Roberts")
                .ToList().ForEach(actor => Console.WriteLine("La Edad de Julia es: " + actor.Edad));
            #endregion

            #region ejercicio 5
            //Insertar un nuevo actor en la tabla actor con los siguientes datos:
            //nombre: Ricardo
            //apellido: Darin
            //edad: 67 años
            //nombre_artistico: Ricardo Darin
            //nacionalidad: argentino
            //género: Masculino.
           
            context.Actor.Add(new Actor("Ricardo", "Darin", "Ricardo Darin", 67, "argentino", 'M'));
            context.SaveChanges();
            #endregion

            #region ejercicio 6
            //obtener la cantidad de actores y actrices que no son de Estados Unidos.
            Console.WriteLine("---------------------------------------------------------");
            context.Actor.Where(actor => actor.Nacionalidad != "USA").ToList().ForEach(actor => Console.WriteLine(actor));
            #endregion

            #region ejercicio 7
            //obtener los nombres y apellidos de todos los actores maculinos.
            Console.WriteLine("---------------------------------------------------------");
            context.Actor.Where(actor => actor.Genero == 'M').ToList().ForEach(
                actor => Console.WriteLine("Actor: " + actor.Nombre + " " + actor.Apellido));
            #endregion
        }
    }
}