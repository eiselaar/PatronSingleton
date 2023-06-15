using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Singleton
{
    internal class Singleton
    {


        /* 
           Aqui se declara una variable estática instance que se utilizará para almacenar 
           la única instancia de la clase Singleton.
           La variable se inicializa como null, lo que indica que no se ha
           creado ninguna instancia todavía.
        
         */

        private static Singleton instance = null;

        //--------------------------------------------//

        /*
         Se declara una variable pública mensaje que representa el mensaje asociado con la instancia de Singleton. 
         En este caso, se inicializa como una cadena vacía,
         pero posteriormente se establece en "Hola Mundo" en el constructor privado

         */

        public string mensaje = "";

        //--------------------------------------------//

        /* 
         Este es el constructor privado de la clase Singleton.
         Es privado para evitar que se puedan crear instancias de la clase directamente desde fuera de la clase. 
         En este caso, el constructor establece el mensaje como "Hola Mundo" para la instancia creada. */
        private Singleton()
        {
            mensaje = "Hola Mundo";
        }

        //--------------------------------------------//

        /*
         Esta es una propiedad estática Instance que proporciona un punto de acceso global
         a la instancia única de la clase Singleton. 
         La propiedad get comprueba si la variable instance es null. 
         Si es null, crea una nueva instancia de Singleton llamando al constructor privado. Luego devuelve la instancia actual 
         o recién creada. 
         Si instance ya tiene una instancia asignada, simplemente devuelve esa instancia existente.

        La propiedad Instance es la forma en que se garantiza que solo exista una instancia de la clase Singleton en todo el programa. 
        Cuando se accede a Singleton.Instance, siempre se devuelve la misma instancia única, 
        evitando la creación de múltiples instancias.*/
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }

        }
    }
}
