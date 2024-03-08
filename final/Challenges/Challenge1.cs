namespace ejercicios.csharp
{
public class Challenge1
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número:");
            int num = int.Parse(Console.ReadLine());
            if(num > 0) Console.WriteLine(Math.Pow(num, 2));
            else if(num < 0) Console.WriteLine("Negativo");
            else Console.WriteLine("Es cero");
        }
    }
}
