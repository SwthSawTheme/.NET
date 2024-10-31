namespace DOTNET_FULL
{       
    internal class Calculator()
    {
        public int Calculate(string operador, int valor1, int valor2)
        {
            if (operador == "+")
            {
                return valor1 + valor2;
            }
            return 0;
        }
    }
}