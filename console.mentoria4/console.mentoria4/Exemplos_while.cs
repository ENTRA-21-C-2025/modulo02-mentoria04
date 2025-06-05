using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console.mentoria4
{
    public static class Exemplos_while
    {
        /// <summary>
        /// Demonstra o uso básico do WHILE com um contador
        /// Implementa uma contagem progressiva até um número definido pelo usuário
        /// Mostra como incrementar uma variável dentro do loop
        /// Exemplo fundamental de loop controlado por contador
        /// </summary>
        public static void ExemploContador()
        {
            Console.WriteLine("\n=== Exemplo 1: While com contador ===");
            Console.Write("Digite um número para contar até ele: ");
            int numero = int.Parse(Console.ReadLine());
            int contador = 1;

            Console.WriteLine($"Contando de 1 até {numero}");
            while (contador <= numero)
            {
                Console.WriteLine($"Contador: {contador}");
                contador++; // Incrementa o contador em 1
            }
        }

        /// <summary>
        /// Ilustra o uso do WHILE para verificação de senha
        /// Implementa um sistema de tentativas limitadas (3 tentativas)
        /// Demonstra controle de acesso com feedback ao usuário
        /// Mostra como usar o break para sair do loop quando a senha é correta
        /// Inclui contagem de tentativas restantes
        /// </summary>
        public static void ExemploSenha()
        {
            Console.WriteLine("\n=== Exemplo 2: While verificando senha ===");
            string senhaCorreta = "1234";
            int tentativas = 0;
            const int maxTentativas = 3;

            while (tentativas < maxTentativas)
            {
                Console.Write("Digite a senha (4 dígitos): ");
                string senha = Console.ReadLine();
                
                if (senha == senhaCorreta)
                {
                    Console.WriteLine("Senha correta! Acesso permitido.");
                    break;
                }
                else
                {
                    tentativas++;
                    int tentativasRestantes = maxTentativas - tentativas;
                    Console.WriteLine($"Senha incorreta! Você ainda tem {tentativasRestantes} tentativa(s).");
                }
            }

            if (tentativas == maxTentativas)
            {
                Console.WriteLine("Número máximo de tentativas excedido!");
            }
        }

        /// <summary>
        /// Demonstra o uso do break para interromper um loop
        /// Implementa um somador de números com condição de parada
        /// Mostra como usar while True com break para controle de fluxo
        /// Ilustra o uso de acumulador (soma) dentro do loop
        /// Permite ao usuário controlar quando parar o programa
        /// </summary>
        public static void ExemploBreak()
        {
            Console.WriteLine("\n=== Exemplo 3: Uso do break ===");
            Console.WriteLine("Digite números. Para parar, digite 0.");
            int soma = 0;

            while (true)
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                
                if (numero == 0)
                {
                    Console.WriteLine("Você digitou 0. Parando o programa...");
                    break;
                }
                
                soma += numero;
                Console.WriteLine($"Soma atual: {soma}");
            }

            Console.WriteLine($"Soma final: {soma}");
        }

        /// <summary>
        /// Ilustra o uso do continue para pular iterações
        /// Implementa um somador que aceita apenas números pares
        /// Demonstra como filtrar valores durante a iteração
        /// Mostra a combinação de break e continue no mesmo loop
        /// Inclui feedback sobre números ignorados (ímpares)
        /// </summary>
        public static void ExemploContinue()
        {
            Console.WriteLine("\n=== Exemplo 4: Uso do continue ===");
            Console.WriteLine("Vamos somar apenas números pares!");
            Console.WriteLine("Digite números. Para parar, digite 0.");
            int somaPares = 0;

            while (true)
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());
                
                if (numero == 0)
                {
                    Console.WriteLine("Você digitou 0. Parando o programa...");
                    break;
                }
                
                if (numero % 2 != 0) // Se o número for ímpar
                {
                    Console.WriteLine($"{numero} é ímpar, pulando...");
                        continue; // Pula para a próxima iteração
                }
                
                somaPares += numero;
                Console.WriteLine($"Soma dos números pares: {somaPares}");
            }
        }
    }
}
