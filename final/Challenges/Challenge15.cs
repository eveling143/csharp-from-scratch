namespace ejercicios.csharp
{
    public class Challenge15
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            if (num >= 10 && num <= 20)
            {

                Console.WriteLine($"El número {num} está dentro del rango");

            }
            else
            {
                Console.WriteLine($"El número {num} está fuera del rango");
            }
        }
    }
}
