using System;

namespace InlamningMetod6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool shutdowm = false;

            while (shutdowm != true)
            {
                Console.WriteLine("Välj det alternativ du vill använda dig utav");
                Console.WriteLine("1. Addera tre tal");
                Console.WriteLine("2. Största talet utav två tal");
                Console.WriteLine("3. Avsluta programmet");
                int menyChoice = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (menyChoice)
                {
                    case 1:
                        MenyvalAddera();
                        break;

                    case 2:
                        MenyvalStörstaTalet();
                        break;

                    case 3:
                        shutdowm = MenyvalAvslutaProgram();
                        break;
                }
            }

        }

        static void MenyvalAddera()
        {
            Console.WriteLine("Skriv 3 tal du vill addera");
            int[] userInputAdd = new int[3];

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Skriv tal {i+1}");
                userInputAdd[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine($"Summan utav {userInputAdd[0]}, {userInputAdd[1]} och {userInputAdd[2]} är {Addera(userInputAdd)}");
            Console.ReadLine();
            Console.Clear();
        }

        static int Addera(int[] sum)
        {
            int summa = sum[0] + sum[1] + sum[2];
            return summa;

        }

        static void MenyvalStörstaTalet()
        {
            Console.WriteLine($"Skriv in 2 tal, så kommer programmet hitta det största talet utav dem");
            int[] userInputLargest = new int[2];

            for(int i = 0;i < 2;i++)
            {
                Console.WriteLine($"Skriv tal {+1}");
                userInputLargest[i] = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine($"Det största talet utav {userInputLargest[1]} och {userInputLargest[1]} är {Störst(userInputLargest)}");
            Console.ReadLine();
            Console.Clear();
        }

        static int Störst(int[] largest)
        {
            if (largest[0] >= largest[1])
            {
                return largest[0];
            }
            else
            {
                return largest[1];
            }
        }

        static bool MenyvalAvslutaProgram()
        {
            return true;
        }


    }

}
