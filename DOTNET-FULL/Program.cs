// C# Curso Completo para iniciantes
using DOTNET_FULL;

var valor1 = int.Parse(Console.ReadLine());
var valor2 = int.Parse(Console.ReadLine());
var operador = Console.ReadLine();

Calculator calculadora = new Calculator();

Console.WriteLine(calculadora.Calculate(operador, valor1, valor2));

Console.ReadLine();