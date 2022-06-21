class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Side 1 Length");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Side 2 Length");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The Hypotenuse is: " + Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)));

    }
}