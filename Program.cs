using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, digite uma frase.");
            string frase = Console.ReadLine().Replace("r" , "l");
            Console.WriteLine(frase);
        }
    }
}
