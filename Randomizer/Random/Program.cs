using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();

            static void Menu()
            {
                Console.WriteLine("Elija una opción\n1) Formar equipos random\n2) Asignar orden aleatorio\n3) Elegir ganador");
                int elección = Convert.ToInt32(Console.ReadLine());
                if (elección == 1)
                    Equipos();
                else if (elección == 2)
                    Orden();
                else if (elección == 3)
                    Ganador();
            }

            static void Equipos()
            {
                Console.WriteLine("En proceso");

                Console.WriteLine("Elija una opción\n1) Volver al menú principal\n2) Salir");
                int elección = Convert.ToInt32(Console.ReadLine());
                if (elección == 1)
                    Menu();
                else if (elección == 2)
                    Console.WriteLine("Hasta luego");
            }

            static void Orden()
            {
                List<string> people = new List<string>()
                    {
                        "Juan Carlos", "Elba Surero", "Dolores Delano", "Susana Oria",
                        "Elton Tito", "Lola Mento", "Elena Nito",
                        "Esteban Dido", "Aitor Menta"
                    };

                Random rnd = new Random();

                var shuffled = people.OrderBy(_ => rnd.Next()).ToList();

                Console.WriteLine(String.Join(", ", shuffled));

                Console.WriteLine("Elija una opción\n1) Volver al menú principal\n2) Salir");
                int elección = Convert.ToInt32(Console.ReadLine());
                if (elección == 1)
                    Menu();
                else if (elección == 2)
                    Console.WriteLine("Hasta luego");
            }

            static void Ganador()
            {
                string[] people = { "Juan Carlos", "Elba Surero", "Dolores Delano", "Susana Oria",
                                    "Elton Tito", "Lola Mento", "Elena Nito",
                                    "Esteban Dido", "Aitor Menta" };

                Random rnd = new Random();

                int mIndex = rnd.Next(people.Length);

                Console.WriteLine("El ganador es: {0}", people[mIndex]);

                Console.WriteLine("Elija una opción\n1) Volver al menú principal\n2) Salir");
                int elección = Convert.ToInt32(Console.ReadLine());
                if (elección == 1)
                    Menu();
                else if (elección == 2)
                    Console.WriteLine("Hasta luego");
            }
        }
    }
}
