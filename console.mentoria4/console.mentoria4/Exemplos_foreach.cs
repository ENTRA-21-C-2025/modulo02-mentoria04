using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.mentoria4
{
    public class Exemplos_foreach
    {
        /// <summary>
        /// Demonstra o uso básico do foreach com uma lista de números
        /// Mostra como percorrer uma lista simples e somar seus valores
        /// Ideal para entender o conceito básico de iteração
        /// </summary>
        public static void ExemploListaNumeros()
        {
            Console.WriteLine("\n=== Exemplo 1: Foreach com lista de números ===");
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            int soma = 0;

            Console.WriteLine("Números na lista:");
            foreach (int numero in numeros)
            {
                Console.WriteLine($"Número atual: {numero}");
                soma += numero;
            }

            Console.WriteLine($"\nA soma de todos os números é: {soma}");
        }

        /// <summary>
        /// Ilustra como usar foreach com uma lista de strings
        /// Demonstra como contar palavras com um tamanho específico
        /// Mostra o uso de condicionais dentro do foreach
        /// </summary>
        public static void ExemploListaPalavras()
        {
            Console.WriteLine("\n=== Exemplo 2: Foreach com lista de palavras ===");
            List<string> palavras = new List<string> { "casa", "carro", "computador", "mesa", "livro" };
            
            Console.Write("Digite o tamanho da palavra que deseja contar: ");
            int tamanhoDesejado = int.Parse(Console.ReadLine());
            int contador = 0;

            Console.WriteLine("\nPalavras na lista:");
            foreach (string palavra in palavras)
            {
                Console.WriteLine($"Palavra: {palavra} (tamanho: {palavra.Length})");
                if (palavra.Length == tamanhoDesejado)
                {
                    contador++;
                }
            }

            Console.WriteLine($"\nExistem {contador} palavras com {tamanhoDesejado} letras");
        }

        /// <summary>
        /// Mostra como usar foreach com um dicionário
        /// Demonstra como acessar chaves e valores
        /// Útil para entender estruturas de dados mais complexas
        /// </summary>
        public static void ExemploDicionario()
        {
            Console.WriteLine("\n=== Exemplo 3: Foreach com dicionário ===");
            Dictionary<string, int> notas = new Dictionary<string, int>
            {
                { "João", 8 },
                { "Maria", 9 },
                { "Pedro", 7 },
                { "Ana", 10 }
            };

            Console.WriteLine("Notas dos alunos:");
            foreach (var aluno in notas)
            {
                string situacao = aluno.Value >= 7 ? "Aprovado" : "Reprovado";
                Console.WriteLine($"Aluno: {aluno.Key} - Nota: {aluno.Value} - Situação: {situacao}");
            }
        }
    }   
}
