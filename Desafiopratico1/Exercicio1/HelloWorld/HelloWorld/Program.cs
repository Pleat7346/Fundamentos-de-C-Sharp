/*
    1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:
       Olá, Welisson! Seja muito bem-vindo!
*/

namespace HelloWorld;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome de usuário:");

        string name = Console.ReadLine();

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }
}