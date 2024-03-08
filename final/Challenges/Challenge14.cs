namespace ejercicios.csharp
{
    public class Challenge14
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número para calcular su factorial:");
            int numero = int.Parse(Console.ReadLine());

            long factorial = CalcularFactorial(numero);

            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }

        static long CalcularFactorial(int numero)
        {
            if (numero < 0)
            {
                throw new ArgumentException("El número debe ser positivo para calcular el factorial.");
            }

        
            if (numero == 0)
            {
                return 1;
            }

            long resultado = 1;
            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
