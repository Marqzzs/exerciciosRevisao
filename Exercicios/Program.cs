//Exercício 1
//Escreva um programa que peça ao usuário para digitar um número inteiro e informe se o
//número é par ou ímpar. Utilize uma estrutura condicional if/else para realizar o teste.

Console.WriteLine($"Informe um numero!");
Console.WriteLine($"E direi se esse numero e par ou impar");

int numberP = int.Parse(Console.ReadLine()!);

if (int.IsEvenInteger(numberP))
{
    Console.WriteLine($"E par");
}
else
{
    Console.WriteLine($"E impar");
}

// Exercício 2
// Crie um programa que permita que o usuário cadastre 5 nomes em um vetor. Após o
// cadastro, o programa deve imprimir na tela os nomes cadastrados em ordem alfabética.
// Utilize um laço for para o cadastro e um método de ordenação de sua preferência (por
// exemplo, bubble sort) para ordenar os nomes.

string[] lNomes = new string[5];

Console.WriteLine($"Insira 5 nomes e eu direi em ordem alfabetica");

for (var i = 0; i < 5; i++)
{
    Console.Write($"Nome {i + 1}: ");
    lNomes[i] = Console.ReadLine()!;
}

Array.Sort(lNomes);

Console.WriteLine("\nNomes em ordem alfabética:");
for (var i = 0; i < lNomes.Length; i++)
{
    Console.WriteLine(lNomes[i]);
}

// Exercício 3
// Crie um programa que calcule a soma dos números pares de um vetor de 10 elementos.
// Utilize um laço for para percorrer o vetor e uma estrutura condicional if para identificar
// os números pares.

int[] numbers = new int[10];
int sumOfEvens = 0;

Console.WriteLine($"Insira 10 numeros e somarei os numeros pares");

for (var i = 0; i < 10; i++)
{
    Console.Write($"Number {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine()!);
}

for (var i = 0; i < 10; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sumOfEvens += numbers[i];
    }
}

Console.WriteLine($"\nA soma dos números pares é: {sumOfEvens}");

// Exercício 4
// Crie uma função que recebe um número como parâmetro e retorna a tabuada desse
// número até o número 10. Utilize um laço for para gerar os múltiplos do número.

Console.WriteLine($"Insira um numero para fazer a tabuada do mesmo");

int number = int.Parse(Console.ReadLine()!);

for (var i = 1; i <= 10; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}");
}

// Exercício 5
// Crie um programa que peça ao usuário para digitar um texto e conte quantas vezes cada
// letra do alfabeto aparece no texto.

Dictionary<char, int> letterCounts = new Dictionary<char, int>();


for (char c = 'a'; c <= 'z'; c++)
{
    letterCounts[c] = 0;
}

Console.Write("Digite um texto: ");
string input = Console.ReadLine()!.ToLower();


foreach (char c in input)
{
    if (char.IsLetter(c))
    {
        letterCounts[c]++;
    }
}

Console.WriteLine("\nContagem de letras:");
foreach (var pair in letterCounts)
{
    if (pair.Value > 0)
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}