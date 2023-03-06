internal class Program
{
    private static void Main(string[] args)
    {
        double C;
        double F;

        Console.Write("Digite uma temperatura em °C para converter para °F: ");
        C = double.Parse(Console.ReadLine());
        Console.WriteLine();

        F = ((C * 9) / 5) + 32;

        Console.WriteLine("A temperatura " + C.ToString("F2") + "°C é igual a " + F.ToString("F2") + "°F");
    }
}