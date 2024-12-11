namespace HelloWorld;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma ou mais palavras:");

        string PalavraDigitada = Console.ReadLine();

        int Contador = 0;

        foreach (char PalavraSemEspaco in PalavraDigitada)
        {
            if (!char.IsWhiteSpace(PalavraSemEspaco))
            {
                Contador++;
            }
        }
        Console.WriteLine($"A quantidade de caracteres (sem contar espaços) é: {Contador}");
    }
}