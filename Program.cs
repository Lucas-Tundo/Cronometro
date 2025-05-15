using System;

namespace Cronometro {
    internal class  Program {
        public static void Main(string[] args) {
            Menu();
        }

        static void Menu() {
            Console.Clear();
            Console.WriteLine("S - Segundo => 10s = 10 segundos");
            Console.WriteLine("M - Minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
        }

        static void Start(int time) {
            int currentTime = 0;

            while (currentTime != time) {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometro finalizado... Voltando para o menu");
            Thread.Sleep(2500);
        }
    }
}