# modulo02-mentoria04
## Estruturas de Repetição: for, foreach, while, break, continue

### O que são Loops? (Explicação Simples)

Imagine que você precisa fazer a mesma coisa várias vezes. Em vez de escrever o mesmo código várias vezes, usamos loops! São como instruções que dizem "repita isso até..." ou "faça isso tantas vezes". Vamos ver cada tipo usando exemplos dos nossos programas:

#### For (Para)
É como uma contagem: "Para cada número de 1 até 10, faça a multiplicação"
```csharp
// Exemplo da Tabuada:
for (int i = 1; i <= 10; i++)
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}
// Se numero = 5, o resultado será:
// 5 x 1 = 5
// 5 x 2 = 10
// 5 x 3 = 15
// ... e assim por diante até 10
```

#### While (Enquanto)
É como uma condição que continua enquanto for verdadeira: "Enquanto não acertar o número, continue tentando"
```csharp
// Exemplo do Jogo de Adivinhação:
while (tentativas < maxTentativas)
{
    // Pede um palpite
    // Verifica se acertou
    // Dá dicas se errou
    // Conta as tentativas
}
// Continua até acertar o número ou
// até acabar as tentativas
```

#### Foreach (Para Cada)
É como olhar cada letra de uma frase: "Para cada letra na frase, verifique se é vogal"
```csharp
// Exemplo do Contador de Vogais:
foreach (char letra in frase)
{
    // Verifica se a letra é vogal
    // Conta cada vogal encontrada
}
// Se a frase for "casa", vai verificar:
// c (não é vogal)
// a (é vogal, conta +1)
// s (não é vogal)
// a (é vogal, conta +1)
```

#### Do-While (Faça-Enquanto)
É como "faça pelo menos uma tentativa, e continue se errar"
```csharp
// Exemplo do Jogo de Adivinhação (versão alternativa):
do
{
    Console.Write("Digite seu palpite: ");
    palpite = int.Parse(Console.ReadLine());
    tentativas++;
    
    // Verifica se acertou
    // Dá dicas se errou
    
} while (palpite != numeroSecreto && tentativas < maxTentativas);
// Garante que o jogador faça pelo menos
// uma tentativa antes de verificar se continua
```

### Quando usar cada um?

- **For**: Use quando souber exatamente quantas vezes repetir (como na Tabuada, que sempre vai de 1 até 10)
- **While**: Use quando não souber quantas vezes vai repetir, mas souber quando parar (como no Jogo de Adivinhação, que continua até acertar ou acabar as tentativas)
- **Foreach**: Use quando precisar olhar cada item de uma lista ou cada caractere de um texto (como no Contador de Vogais, que verifica cada letra da frase)
- **Do-While**: Use quando precisar fazer algo pelo menos uma vez antes de verificar se continua (como uma versão alternativa do Jogo de Adivinhação, onde o jogador sempre faz pelo menos uma tentativa)

Este projeto demonstra o uso de estruturas de repetição em C# através de exemplos práticos e interativos, focando em diferentes cenários de iteração e controle de fluxo.

### Visão Geral do Projeto

O projeto é uma aplicação console que apresenta um menu interativo com diferentes exemplos de programação em C#. Cada exemplo foi desenvolvido para demonstrar conceitos específicos da linguagem, com foco em:

- Estruturas de repetição for
- Estrutura foreach
- Estrutura while/do-while
- Instruções break e continue
- Boas práticas de programação
- Documentação de código

### Estrutura do Projeto

```
console.mentoria4/
├── Program.cs (Menu principal)
├── Tabuada.cs
├── ContadorVogais.cs
└── JogoAdivinhacao.cs
```

### Como Executar

1. Clone o repositório
2. Abra o projeto no Visual Studio ou VS Code
3. Execute o projeto
4. Use o menu interativo para selecionar os diferentes exemplos

### Tecnologias Utilizadas

- C#
- .NET
- Console Application

## Exemplos Detalhados

### 1. Gerador de Tabuada (Tabuada)

Este exemplo demonstra o uso de loops aninhados para gerar tabuadas:

#### Explicação Simples
O programa pede um número e mostra sua tabuada de 1 até 10. É como fazer uma tabela de multiplicação, onde mostramos todas as multiplicações daquele número.

#### Exemplo de Código
```csharp
public class Tabuada
{
    public void GerarTabuada()
    {
        Console.Write("Digite um número para ver sua tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine($"{numero} x {i} = {resultado}");
        }
    }
}
```

#### Conceitos Demonstrados
- Estrutura for
- Loops aninhados
- Formatação de saída
- Controle de fluxo com break
- Interação com o usuário via console

### 2. Contador de Vogais (ContadorVogais)

Exemplo focado em contar vogais em uma string usando foreach:

#### Explicação Simples
O programa conta quantas vezes cada vogal (a, e, i, o, u) aparece em uma frase que você digitar. É útil para analisar textos e ver quais vogais são mais comuns.

#### Exemplo de Código
```csharp
public class ContadorVogais
{
    public void ContarVogais()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine().ToLower();
        
        int[] contador = new int[5]; // [a, e, i, o, u]
        char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

        foreach (char letra in frase)
        {
            switch (letra)
            {
                case 'a': contador[0]++; break;
                case 'e': contador[1]++; break;
                case 'i': contador[2]++; break;
                case 'o': contador[3]++; break;
                case 'u': contador[4]++; break;
            }
        }

        Console.WriteLine("\nContagem de vogais:");
        for (int i = 0; i < vogais.Length; i++)
        {
            Console.WriteLine($"Vogal {vogais[i]}: {contador[i]} vezes");
        }
    }
}
```

#### Conceitos Demonstrados
- Estrutura foreach
- Manipulação de strings
- Arrays e coleções
- Contadores e acumuladores
- Formatação de resultados

### 3. Jogo de Adivinhação (JogoAdivinhacao)

Demonstração de um jogo simples usando while e controle de fluxo:

#### Explicação Simples
O programa pensa em um número entre 1 e 100, e você precisa adivinhar qual é. A cada tentativa, ele te diz se o número é maior ou menor. É um jogo divertido para praticar loops e condições!

#### Exemplo de Código
```csharp
public class JogoAdivinhacao
{
    public void Jogar()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101);
        int tentativas = 0;
        int maxTentativas = 10;

        Console.WriteLine("Bem-vindo ao Jogo da Adivinhação!");
        Console.WriteLine($"Tente adivinhar o número entre 1 e 100. Você tem {maxTentativas} tentativas.");

        while (tentativas < maxTentativas)
        {
            Console.Write("\nDigite seu palpite: ");
            if (!int.TryParse(Console.ReadLine(), out int palpite))
            {
                Console.WriteLine("Por favor, digite um número válido!");
                continue;
            }

            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("O número é MAIOR!");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("O número é MENOR!");
            }
            else
            {
                Console.WriteLine($"\nParabéns! Você acertou em {tentativas} tentativas!");
                break;
            }

            Console.WriteLine($"Tentativas restantes: {maxTentativas - tentativas}");
        }

        if (tentativas == maxTentativas && palpite != numeroSecreto)
        {
            Console.WriteLine($"\nGame Over! O número era {numeroSecreto}");
        }
    }
}
```

#### Conceitos Demonstrados
- Estrutura while
- Instruções break e continue
- Geração de números aleatórios
- Validação de entrada
- Controle de fluxo complexo

### Observações Finais

- Todos os exemplos são interativos e solicitam entrada do usuário
- O código inclui documentação XML para melhor compreensão
- Os exemplos utilizam recursos modernos do C#
- O menu principal permite fácil navegação entre os exemplos
- Cada exemplo demonstra diferentes aspectos das estruturas de repetição
- O código segue as melhores práticas de programação e convenções do C#
