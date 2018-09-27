using System;

namespace senai.operadores.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o tamanho da base");
            float lado = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o comprimento");
            float comprimento = float.Parse(Console.ReadLine());

            float area = (float)(lado * comprimento); 

            Console.WriteLine("A área é: " + area );
        }
    }
}
