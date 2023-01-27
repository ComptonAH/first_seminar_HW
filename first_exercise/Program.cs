Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write($"max = {number1}");
}
else
{
    Console.Write($"max = {number2}");
}