using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Un patrón de diseño llamado Singleton.
            El patrón Singleton se utiliza para garantizar que solo exista
            una instancia de una clase y proporcionar un punto de acceso
            global a esa instancia.*/

            //Creacion de las Instancias
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Singleton s3 = Singleton.Instance;

            /* Se crean tres instancias de la clase Singleton utilizando la propiedad estática Instance. 
             La propiedad Instance es la forma en que el patrón Singleton asegura 
             que solo exista una instancia de la clase*/

            //-----------------------------------------------------//

            Console.WriteLine("Validacion de instancias");
            Console.WriteLine("--------------------------------");
            if (s1 == s2)
                Console.WriteLine("Instancias iguales");
            else Console.WriteLine("Instancias diferentes");

            /* Aquí se realiza una validación para verificar si las instancias 
               s1 y s2 son iguales.Dado que ambas instancias se crearon
               utilizando Singleton.Instance, deberían ser la misma instancia.
               Por lo tanto, se imprimirá "Instancias iguales.*/

            //----------------------------------------//

            // Mensaje de las instancias
            Console.WriteLine("\nMensaje de varias instancias");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mensaje de s1: " + s1.mensaje);
            Console.WriteLine("Mensaje de s2: " + s2.mensaje);
            Console.WriteLine("Mensaje de s3: " + s3.mensaje);

            /* Se muestra el mensaje asociado con cada instancia. 
               En el patrón Singleton, todas las instancias comparten el mismo estado y comportamiento, 
               por lo que el mensaje será el mismo para todas las instancias. 
               Aquí se imprimirá el mensaje asociado con cada instancia, 
              que probablemente será un valor predeterminado establecido dentro de la clase Singleton.*/

            //----------------------------------------//


            // Cambio del mensaje
            Console.WriteLine("\nCambio de Mensajes");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mensaje de s1: " + s1.mensaje);
            Singleton.Instance.mensaje = "Hola Marte";
            Console.WriteLine("Mensaje de s2: " + s2.mensaje);
            s2.mensaje = "Hola Jupiter";
            Console.WriteLine("Mensaje de s3: " + s3.mensaje);

            /* 
               En esta parte realiza un cambio en el mensaje asociado con la instancia s1. 
               Después de cambiar el mensaje, se imprime nuevamente el mensaje asociado con s2 y s3.
               Dado que todas las instancias comparten el mismo estado,
               el cambio realizado en s1 se reflejará en las otras instancias. 
               Por lo tanto, los mensajes asociados con s2 y s3 también cambiarán.

               El objetivo del patrón Singleton es asegurarse de que solo exista una instancia 
               de una clase determinada durante la vida útil de la aplicación
               y proporcionar un acceso global a esa instancia.

             */

            Console.ReadLine();
        }
    }
}
