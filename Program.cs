using System;
using System.Linq;

namespace RetPreenchido
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, alt, lar;

            Console.WriteLine("--- Tamanho do Retângulo ---");
            inicio:
            Console.Write("Largura..: ");
            lar = int.Parse(Console.ReadLine());

            Console.Write("Altura...: ");
            alt = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            c = 1;
            if(alt > 0 && alt <=10 && lar > 0 && lar <= 10)
            {
                while(c <= alt)
                {
                    string ret = string.Concat(Enumerable.Repeat("*",lar));
                        Console.WriteLine(ret);

                    c++;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Digite ambos valores entre 1 e 10");
                Console.ResetColor();
                goto inicio;
            }
        }
    }
}
