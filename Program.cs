using System;
using NarutoRPG.src.Entities;


namespace NarutoRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodNinja naruto = new GoodNinja("Naruto", 980, "Aldeia da Folha", "Rasengam");
            EvilNinja orochimaru = new EvilNinja("Orochimaru", 150, "Renegado", "", "Reencarnação do Mundo Impuro", 1580);
            GoodNinja sassuke = new GoodNinja("Sassuke", 580, "Renegado", "Bola de fogo");
            GoodNinja gaara = new GoodNinja("Gaara", 120, "Aldeia da Areia", "Caixão de areia");
            GoodNinja roockLee = new GoodNinja("Roock Lee", 300, "Aldeia da folha", "Furacão da folha");

            Random randomNumber = new Random();

            int aleatorio = randomNumber.Next(1, 101);
            int aleatorio2 = randomNumber.Next(1, 101);
            

            Console.WriteLine("Fight!");
            naruto.Attack(aleatorio);
            Console.ReadKey();
            Console.Clear();
            naruto.Duelo(aleatorio);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Ataque sofrido de {aleatorio} pontos ** {orochimaru.Defense(aleatorio)}");
            Console.ReadKey();
            Console.Clear();
            orochimaru.Attack(aleatorio2);
            Console.ReadKey();
            Console.Clear();
            naruto.Duelo(aleatorio2);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Ataque sofrido de {aleatorio2} pontos ** {naruto.Defense(aleatorio2)}");

            Console.WriteLine("Aluta terminou!\nAperte qualquer tecla para sair.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
