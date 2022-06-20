internal class Program
{
    private static void Main(string[] args)
    {
        //Exericios Basico de Media
        Console.WriteLine("Calculo de Pitagoras");

        Console.WriteLine("Digite a altura");
        double altura = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Digite a base");
        double body = Convert.ToDouble(Console.ReadLine());

        double valorTotal = (body*2)+ (altura*2) / 2;

        Console.WriteLine(valorTotal);
    }
}

