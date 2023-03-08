using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroVitorias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escreva seu numero de vitorias");
            int vitorias = int.Parse(Console.ReadLine());
            Console.WriteLine("Você possue " + vitorias + " Vitorias");
            Console.WriteLine("Escreva seu numero de derrotas");
            int derrotas = int.Parse(Console.ReadLine());
            Console.WriteLine("Você possue " + derrotas + " Derrotas");

            int pontos = vitorias - derrotas;
            Console.WriteLine("Você possue um total de " + pontos + " pontos.");

            if (pontos >= 10)
            {
                Console.WriteLine("Seu time está bem");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("Seu time esta mal.");
                Console.ReadLine();
            }
          
            
        }
        

    }
}
