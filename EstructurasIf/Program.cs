using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasIf
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;

            //Leemos el nombre que va a ser escrito por el usuario

            Console.Write("Dime tu nombre:");
            nombre = Console.ReadLine();

            //Verificamos el valor del nombre y lo sacamos por pantalla
            if (nombre == "Luis")
            {
                Console.WriteLine("Bienvenido luis");

            }
            else if (nombre == "Pepe")
                Console.WriteLine("Hola pepe, cuanto tiempo");
            else {
                Console.WriteLine("Bienvenido {0}", nombre);
            
            }

            //Vamos a hacer lo mismo con un switch

            switch (nombre) { 
                case "Luis":
                    Console.WriteLine("Bienvenido luis");
                    break;
                case "Pepe":
                    Console.WriteLine("Bienvenido pepe");
                    break;
                default:
                    Console.WriteLine("Bienvenido {0}", nombre);
                    break;
            } 


            Console.ReadLine();
        }
    }
}
