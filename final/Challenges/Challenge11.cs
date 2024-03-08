namespace ejercicios.csharp
{
    public class Challenge11
    {
        public void Run()
        {
            Console.WriteLine("Ingrese el primer número: ");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            double num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            double num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número: ");
            double num4 = int.Parse(Console.ReadLine());

            double promedio = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine(promedio);

        }
    }
}