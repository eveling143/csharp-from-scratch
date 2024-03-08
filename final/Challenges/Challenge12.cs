namespace ejercicios.csharp
{
    public class Challenge12
    {
        public void Run()
        {
            List<int> numeros = new List<int>();
            for (int i = 0;  i < 5; i++)
            {
                Console.WriteLine($"Introduce el número {i + 1}:");
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"El número más pequeño de la lista es: {numeros.Min()}");


        }
    }
}