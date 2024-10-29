// int a = 5;
// int b = 6;

// if (a < b)
// {
//     Console.WriteLine("A é maior que B");
// }

exploradorDeIf();

void exploradorDeIf()
{
    int a = 5;
    int b = 5;

    if (a == b && a + b == 10)
    {
        Console.WriteLine("A condição foi satisfeita!");
    } else
    {
        Console.WriteLine("A condição não foi satisfeita");
    }

    int c = 4;

    if ((a + b + c > 10) || (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }
}