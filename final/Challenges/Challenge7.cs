namespace ejercicios.csharp
{
    public class Challenge7
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Numero a dividir:");
                double n = double.Parse(Console.ReadLine());
                Console.WriteLine("Divisor:");
                double divisor = double.Parse(Console.ReadLine());
                Console.WriteLine($"Resultado: {n%divisor}");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir por cero!");
            }
            catch(Exception)
            {
                Console.WriteLine("Error al realizar la operacion!");
            }
        }
       
    }
     
}