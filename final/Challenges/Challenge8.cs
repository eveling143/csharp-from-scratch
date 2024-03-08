namespace ejercicios.csharp
{
    public class Challenge8
    {
        public void Run()
        {
           int suma = 0;
           for (int i = 2; i <= 50; i+= 2)
           {
            suma += i;
           }
           Console.WriteLine($"La suma de números pares entre el 1 y el 50 es: {suma}");
        }
       
    }
     
}