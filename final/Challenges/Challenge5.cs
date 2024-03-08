namespace ejercicios.csharp
{

  public class Challenge5
    {
        public void Run()
        {
            Console.WriteLine("Ingrese un número entre 1 y 7:");
            int dia = int.Parse(Console.ReadLine());

            switch(dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miercoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                default: Console.WriteLine("Número fuera del rango laboral."); break;
            }
        }
       
    }
     
}