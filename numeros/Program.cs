﻿//meuprimeiroMetodo();
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
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);   
}