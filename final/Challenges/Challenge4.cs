namespace ejercicios.csharp
{

    public class Challenge4
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número: ");
            int rad = int.Parse(Console.ReadLine());
            int decimales = 2;
            double resultado = 2 * Math.PI * rad;
            double redondeado = Math.Round(resultado, decimales);
            Console.WriteLine(redondeado);
            
        }
       
    }
}