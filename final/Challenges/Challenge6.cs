namespace ejercicios.csharp
{
    public class Challenge6
    {
        public void Run()
        {
            Console.WriteLine("Ingrese su salario mensual: ");
            double sal = double.Parse(Console.ReadLine());
            if (sal > 12000)
            {
                double valor = sal - 12000;
                double impuesto = valor * 0.15;
                Console.WriteLine($"La cantidad de impuesto a pagar es: {impuesto} ");
            }
            else Console.WriteLine("No debe impuestos");

        }


    }
}