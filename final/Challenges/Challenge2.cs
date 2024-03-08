namespace ejercicios.csharp
{
    public class Challenge2
    {
        public void Run()
        {
            Console.WriteLine("Ingrese primer número: ");
            double num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo número: ");
            double num2 = int.Parse(Console.ReadLine());
           if (num1 > num2) Console.WriteLine(num1 + num1);
            else if (num2 > num1 ) Console.WriteLine(num2 + num2 + num2);
            else Console.WriteLine(num1 + num2);
        }
       
    }
     
}
