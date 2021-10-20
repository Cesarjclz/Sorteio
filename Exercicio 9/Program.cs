using System;

namespace Exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {

            var e = new Random().Next(1, 5);

            switch (e) {
                case 1: Console.WriteLine("Você ganhou um PS4");
                    break;
                case 2: Console.WriteLine("Você ganhou um xbox");
                    break;
                case 3: Console.WriteLine("Você ganhou um celular");
                    break;
                case 4: Console.WriteLine("Você ganhou um PC");
                    break;


            
            
            }
            
            




        }
    }
}
