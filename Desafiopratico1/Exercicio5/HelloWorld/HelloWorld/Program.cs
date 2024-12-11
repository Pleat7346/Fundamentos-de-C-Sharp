namespace HelloWorld;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a placa do veículo:");
        string placa = Console.ReadLine();

        
        bool validaPlaca = ValidarPlaca(placa);

        
        if (validaPlaca)
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }

    static bool ValidarPlaca(string placa)
    {
        
        string padrao = "^[A-Za-z]{3}[0-9]{4}$";

       
        return System.Text.RegularExpressions.Regex.IsMatch(placa, padrao);
    }
}
