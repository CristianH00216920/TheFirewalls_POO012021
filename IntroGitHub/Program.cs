using System;

namespace IntroGitHub
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 0;

            Console.Write("Ingrese un valor para a: ");
            a = Int32.Parse(Console.ReadLine());

            Console.Write("Ingrese un valor para b: ");
            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"\nMultiplicando {a} * {b} igual: {multiplyNumber(a,b)} ");
        }

        public static int multiplyNumber(int a, int b)
        {
            return a * b;
        }

    }
}