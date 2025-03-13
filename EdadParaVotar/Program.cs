using System;

namespace EdadParaVotar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Validar si el usuario puede votar
            //Andy Garzón
            int edad;
            do
            {
                Console.Write("¿Cuál es tu edad? ");
                edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("¡Puedes votar!");
                }
                else
                {
                    Console.WriteLine("No tienes la edad para votar.");
                }

            } while (edad <= 18); //Repite el programa hasta que se cumpla con la edad 
        }
    }
}
