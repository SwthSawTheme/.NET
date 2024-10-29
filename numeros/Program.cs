//meuprimeiroMetodo();
OrderDePrecedencia();
// void meuprimeiroMetodo()
// {
//     int a = 18;
//     int b = 2;

//     // Adição
//     int c = a + b;
//     Console.WriteLine(c);

//     //subtração
//     c = a - b;
//     Console.WriteLine(c);

//     //multiplicação
//     c = a * b;
//     Console.WriteLine(c);

//     //divisão
//     c = a / b;
//     Console.WriteLine(c);
// }

void OrderDePrecedencia()
{
    int a = 2;
    int b = 2;
    int c = a + (a*b);

    Console.WriteLine(c);
}