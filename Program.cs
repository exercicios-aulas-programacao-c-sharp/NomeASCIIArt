using System;
using Figgle;

namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nomeTextao;
            
            Console.Write("Digite seu nome...: ");
            
            nome = Console.ReadLine();           
            nomeTextao = FiggleFonts.Standard.Render(nome);

            Console.WriteLine(nomeTextao);

        }
    }
}
