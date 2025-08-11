class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculator");
        
        Console.Write("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Choose operation:");
        Console.WriteLine("1 - Addition");
        Console.WriteLine("2 - Subtraction");
        Console.WriteLine("3 - Multiplication");
        Console.Write("Enter your choice (1-3): ");
        int choice = Convert.ToInt32(Console.ReadLine());
        
        int result = 0;
        
        switch (choice)
        {
            case 1:
                result = a + b;
                Console.WriteLine($"The sum is: {result}");
                break;
            case 2:
                result = a - b;
                Console.WriteLine($"The difference is: {result}");
                break;
            case 3:
                result = a * b;
                Console.WriteLine($"The product is: {result}");
                break;
            default:
                Console.WriteLine("Invalid operation choice");
                break;
        }
        
        Console.ReadKey();
    }
}