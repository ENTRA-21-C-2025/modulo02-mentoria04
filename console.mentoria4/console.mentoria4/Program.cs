/// <summary>
/// Programa principal que demonstra o uso de estruturas de repetição através de um menu interativo.
/// Este programa apresenta diferentes exemplos de uso de for, foreach, while e do-while em C#.
/// 
/// Exemplos disponíveis:
/// 
/// For:
/// - Exemplo com Range Input: Permite ao usuário definir o início e fim da contagem
/// - Exemplo com Lista e Comparação: Demonstra busca em lista com comparação case-insensitive
/// - Exemplo com Contagem de Valores: Mostra contagem entre dois valores com troca automática
/// 
/// Foreach:
/// - Exemplo com Lista de Números: Demonstra iteração e soma de números em uma lista
/// - Exemplo com Lista de Palavras: Mostra contagem de palavras por tamanho
/// - Exemplo com Dicionário: Ilustra iteração em dicionário com chave-valor
/// 
/// While:
/// - Exemplo com Contador: Demonstra contagem progressiva até um número definido
/// - Exemplo com Senha: Implementa sistema de tentativas limitadas para senha
/// - Exemplo com Break: Mostra uso do break para interromper loop
/// - Exemplo com Continue: Demonstra uso do continue para pular iterações
/// 
/// Do-While:
/// - Jogo de Adivinhar Número: Implementa um jogo simples usando do-while
/// 
/// Cada exemplo demonstra diferentes aspectos e casos de uso das estruturas de repetição em C#.
/// </summary>
using console.mentoria4;

bool continuar = true;

while (continuar)
{
    Console.Clear();
    Console.WriteLine("=== Menu de Exemplos de Estruturas de Repetição ===");
    Console.WriteLine("\nExemplos com For:");
    Console.WriteLine("1. For - Exemplo com Range Input");
    Console.WriteLine("2. For - Exemplo com Contagem de Valores");
    
    Console.WriteLine("\nExemplos com Foreach:");
    Console.WriteLine("3. Foreach - Exemplo com Lista de Números");
    Console.WriteLine("4. Foreach - Exemplo com Lista de Palavras");
    Console.WriteLine("5. Foreach - Exemplo com Dicionário");
    
    Console.WriteLine("\nExemplos com While:");
    Console.WriteLine("6. While - Exemplo com Contador");
    Console.WriteLine("7. While - Exemplo com Senha");
    Console.WriteLine("8. While - Exemplo com Break");
    Console.WriteLine("9. While - Exemplo com Continue");
    
    Console.WriteLine("\nExemplos com Do-While:");
    Console.WriteLine("10. Do-While - Jogo de Adivinhar Número");
    
    Console.WriteLine("\n0. Sair");
    Console.Write("\nEscolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Exemplos_for.ExemploRangeInput();
            break;
        case "2":
            Exemplos_for.ExemploContagemValores();
            break;
        case "3":
            Exemplos_foreach.ExemploListaNumeros();
            break;
        case "4":
            Exemplos_foreach.ExemploListaPalavras();
            break;
        case "5":
            Exemplos_foreach.ExemploDicionario();
            break;
        case "6":
            Exemplos_while.ExemploContador();
            break;
        case "7":
            Exemplos_while.ExemploSenha();
            break;
        case "8":
            Exemplos_while.ExemploBreak();
            break;
        case "9":
            Exemplos_while.ExemploContinue();
            break;
        case "10":
            Exemplos_dowhile.JogoAdivinharNumero();
            break;
        case "0":
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (continuar)
    {
        Console.WriteLine("\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}