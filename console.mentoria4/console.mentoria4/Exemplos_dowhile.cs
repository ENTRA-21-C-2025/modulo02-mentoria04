using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.mentoria4
{
    public static class Exemplos_dowhile
    {
        /// <summary>
        /// Jogo interativo de adivinhação onde o usuário tenta descobrir um número secreto.
        /// - Número secreto está entre 1 e 10
        /// - Fornece feedback se o palpite é maior ou menor
        /// - Usa do-while para garantir pelo menos uma tentativa
        /// - Termina quando o número é acertado
        /// </summary>
        public static void JogoAdivinharNumero()
        {
            // Número que o usuário precisa adivinhar
            int numeroSecreto = 7;
            int tentativa;

            Console.WriteLine("Bem-vindo ao jogo de adivinhar o número!");
            Console.WriteLine("Tente adivinhar um número entre 1 e 10.");

            do
            {
                Console.Write("\nDigite seu palpite: ");
                tentativa = int.Parse(Console.ReadLine());

                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("Tente um número maior!");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("Tente um número menor!");
                }
                else
                {
                    Console.WriteLine("Parabéns! Você acertou o número!");
                }

            } while (tentativa != numeroSecreto);

            Console.WriteLine("\nFim do jogo!");
        }
    }
}
