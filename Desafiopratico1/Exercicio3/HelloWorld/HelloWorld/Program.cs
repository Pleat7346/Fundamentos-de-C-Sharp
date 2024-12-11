namespace HelloWorld;

class Program
{
    static void Main()
    {
        // Adicionando os valore

        Console.WriteLine("Digita o primeiro valor:");

        double PrimeiroValor = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digita o segundo valor:");

        double SegundoValor = Convert.ToDouble(Console.ReadLine());

        // Os resultado

        Console.WriteLine($"A soma entre esses dois números: {PrimeiroValor + SegundoValor}");

        Console.WriteLine($"A subtração entre os dois números: {PrimeiroValor - SegundoValor}");

        Console.WriteLine($"A multiplicação entre os dois números: {PrimeiroValor * SegundoValor}");
       
        if (SegundoValor != 0)
        {
            Console.WriteLine($"A divisão entre os dois números: {PrimeiroValor / SegundoValor}");
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }

        Console.WriteLine($"A média entre os dois números.: {(PrimeiroValor + SegundoValor) / 2}");
    }
}