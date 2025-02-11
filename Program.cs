using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Write("Set...");
            Thread.Sleep(1000);
            Console.Write("Go...");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Menu()
        {

            string r = "sim";

            while (r == "sim")
            {
                Console.Clear();
                Console.WriteLine("S = segundo");
                Console.WriteLine("M = minuto");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine("Digite quanto tempo deseja contar:");

                string data = Console.ReadLine().ToLower();
                char type = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));
                int multiplier = 1;

                if (type == 'm')
                    multiplier = 60;

                if (time == 0)
                    System.Environment.Exit(0);

                PreStart(time * multiplier);

                Console.Clear();
                Console.WriteLine("Cronometrar novamente? (sim/nao)");
                r = Console.ReadLine();
            }

            Console.Clear();
            Thread.Sleep(1000);
            Console.WriteLine("Programa finalizado.");

        }
        static void Start(int time)
        {
            Console.Clear();
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"Time: {currentTime}");
                Thread.Sleep(1000);
            }


            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2000);
        }
    }
}