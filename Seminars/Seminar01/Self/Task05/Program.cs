// Your code here!
double u = double.Parse(Console.ReadLine());
double r = double.Parse(Console.ReadLine());
Console.WriteLine($"I: {Math.Round(u / r, 2)}");
Console.WriteLine($"P: {Math.Round(u * u / r, 2)}");
Console.ReadLine();