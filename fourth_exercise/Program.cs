Console.Write("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;

while (count<=N)
{
    if (count%2==0)
    {
        Console.Write($"{count} ");
    }
    count++;
}