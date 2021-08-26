using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoDigitado, textoExibido, nomeDigitado;
            Console.Write("Por favor, digite seu nome: ");
            nomeDigitado = Console.ReadLine();

            Console.WriteLine($"Olá {nomeDigitado}. Vou GRITAR o que você digitar.");

            Console.Write("Digite o que quiser: ");
            textoDigitado = Console.ReadLine();

            textoExibido = textoDigitado.ToUpper();

            Console.WriteLine("Eu grito: ");
            Console.WriteLine($"{textoExibido} !!!");

            Console.WriteLine($"Você digitou: {textoDigitado}");

        }
    }
}
