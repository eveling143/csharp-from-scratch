namespace ejercicios.csharp
{
    public class Challenge10
    {
        public void Run()
        {
            Console.WriteLine("Ingresa una palabra: ");
            string palabra = (Console.ReadLine());
          
          int longitud = palabra.Length;
          Console.WriteLine($"La longitud de la palabra es: {longitud}");
        }
       
    }
     
}