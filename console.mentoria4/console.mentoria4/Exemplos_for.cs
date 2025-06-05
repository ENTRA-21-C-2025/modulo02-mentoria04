using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.mentoria4
{
    public static class Exemplos_for
    {
        /// <summary>
        /// Demonstra o uso do FOR com range dinâmico
        /// Permite ao usuário definir o início e fim da contagem
        /// Mostra como usar Console.ReadLine() para controlar o range do loop
        /// Útil para contagens personalizadas
        /// </summary>
        public static void ExemploRangeInput()
        {
            Console.WriteLine("\n=== Exemplo 1: For com range usando input ===");
            Console.Write("Digite o número inicial: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite o número final: ");
            int fim = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nContando de {inicio} até {fim}:");
            for (int numero = inicio; numero <= fim; numero++)
            {
                Console.WriteLine($"Número: {numero}");
            }
        }

        /// <summary>
        /// Mostra como fazer uma contagem entre dois valores
        /// Implementa lógica para garantir que a contagem seja sempre crescente
        /// Demonstra o uso de variáveis de controle no FOR
        /// Inclui tratamento para valores invertidos (troca A e B se necessário)
        /// </summary>
        public static void ExemploContagemValores()
        {
            Console.WriteLine("\n=== Exemplo 3: Contagem entre dois valores ===");
            Console.Write("Digite o primeiro valor (A): ");
            int valorA = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor (B): ");
            int valorB = int.Parse(Console.ReadLine());

            // Garantindo que valorA seja menor que valorB
            if (valorA > valorB)
            {
                int temp = valorA;
                valorA = valorB;
                valorB = temp;
            }

            Console.WriteLine($"\nContando de {valorA} até {valorB}:");
            for (int i = valorA; i <= valorB; i++)
            {
                Console.WriteLine($"Valor atual: {i}");
            }
        }
    }
}
