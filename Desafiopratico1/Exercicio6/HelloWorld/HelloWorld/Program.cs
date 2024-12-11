using System.Globalization;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1 - Formato completo");
        Console.WriteLine("2 - Apenas a data (dd/MM/yyyy)");
        Console.WriteLine("3 - Apenas a hora (24 horas)");
        Console.WriteLine("4 - Data com o mês por extenso");

        string opcao = Console.ReadLine();
        DateTime agora = DateTime.Now;

        switch (opcao)
        {
            case "1":
                Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")));
                break;

            case "2":
                Console.WriteLine(agora.ToString("dd/MM/yyyy"));
                break;

            case "3":
                Console.WriteLine(agora.ToString("HH:mm"));
                break;

            case "4":
                Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;

            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
}