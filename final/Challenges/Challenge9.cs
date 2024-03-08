namespace ejercicios.csharp
{

    public class Challenge9
    {
        public void Run()
        {
            Console.WriteLine("Ingrese los valores para la primera fracción:");
            Console.Write("Numerador: ");
            int numerador1 = int.Parse(Console.ReadLine());
            Console.Write("Denominador: ");
            int denominador1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese los valores para la segunda fracción:");
            Console.Write("Numerador: ");
            int numerador2 = int.Parse(Console.ReadLine());
            Console.Write("Denominador: ");
            int denominador2 = int.Parse(Console.ReadLine());


            Fraccion fraccion1 = new Fraccion(numerador1, denominador1);
            Fraccion fraccion2 = new Fraccion(numerador2, denominador2);


            Fraccion diferencia = Fraccion.Diferencia(fraccion1, fraccion2);


            Console.Write("\nLa diferencia entre las fracciones es: ");
            diferencia.ImprimirFraccion();
        }
        class Fraccion
        {
            private int numerador;
            private int denominador;


            public Fraccion(int numerador, int denominador)
            {
                this.numerador = numerador;
                this.denominador = denominador;
            }


            public static Fraccion Diferencia(Fraccion fraccion1, Fraccion fraccion2)
            {
                // Verificar si las fracciones son iguales
                if (fraccion1.numerador == fraccion2.numerador && fraccion1.denominador == fraccion2.denominador)
                {
                    return new Fraccion(0, 0);
                }
                else
                {
                    // Calcular la diferencia
                    int nuevoNumerador = fraccion1.numerador * fraccion2.denominador - fraccion2.numerador * fraccion1.denominador;
                    int nuevoDenominador = fraccion1.denominador * fraccion2.denominador;
                    return new Fraccion(nuevoNumerador, nuevoDenominador);
                }
            }


            public void ImprimirFraccion()
            {
                if (this.numerador == 0)
                {
                    Console.WriteLine("0");
                }
                else if (this.numerador % this.denominador == 0)

                {
                    double result = this.numerador / this.denominador;
                    Console.WriteLine(result);

                }
                else
                {
                    Console.WriteLine($"{this.numerador}/{this.denominador}");

                }
            }
        }
    }
}