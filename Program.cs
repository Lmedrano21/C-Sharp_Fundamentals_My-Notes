Console.WriteLine("This is new calculator --Only sum");
Console.Write("Write first num: ");
// The ! operator tells the compiler that ReadLine() will not be null
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Write second num: ");
int num2 = int.Parse(Console.ReadLine()!);
int result = num1 + num2;
Console.WriteLine($"The result is {result}");