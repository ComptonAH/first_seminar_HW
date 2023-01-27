Console.Write("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max>number2)
{
    if (max>number3)
    {
        Console.Write($"the max number is {max}");
    }
    else
    {
        max = number3;
        Console.Write($"the max number is {max}");
    }
}
else
{
    max = number2;
    if (max>number3)
    {
        Console.Write($"the max number is {max}"); 
    }
    else
    {
        max = number3;
        Console.Write($"the max number is {max}");
    }
}