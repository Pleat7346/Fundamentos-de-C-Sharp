/*
    2. Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo. 
*/

namespace HelloWorld;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu primeiro nome:");

        string PrimeiroName = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome:");

        string Sobrenome = Console.ReadLine();

        Console.WriteLine($"{PrimeiroName} { Sobrenome}");
    }
}