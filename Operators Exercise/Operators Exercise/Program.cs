using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        //----------Exercise 1------------
        var a = 17;
        var b = 4;
        var quotient = a / b;
        var remainder = a % b;

        Console.WriteLine(a + b);
        Console.WriteLine(a - b);
        Console.WriteLine(a * b);
        Console.WriteLine(a / b);
        Console.WriteLine(a % b);

        Console.WriteLine(a + " / " + b + " is " + quotient + " remainder " + remainder);


        //------------- Exercise 2--------------

        Console.WriteLine("Enter the radius of your cirlce:");
        var userInput = Console.ReadLine();

        var radius = double.Parse(userInput);

        Console.WriteLine(AreaOfCirle(radius) + " is the radius of your circle");



        static double AreaOfCirle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
            
           


        }
    }
} 