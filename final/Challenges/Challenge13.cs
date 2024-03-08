namespace ejercicios.csharp
{
    public class Challenge13
    {
        public void Run()
        {
            Console.WriteLine("Ingrese una palabra:");
        string palabra = Console.ReadLine();

        int contadorVocales = palabra.Count(caracter => "aeiouAEIOU".Contains(caracter));

        Console.WriteLine($"El número de vocales en la palabra ingresada es: {contadorVocales}");
        }
    }
}