namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dateconverted = new DateOnly();
            string nameImput;
            string birthdayImput;

            Console.WriteLine("¡Bienvenido al calculador de años!");
            Console.WriteLine("Escribe tu nombre: ");
            nameImput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameImput}");

            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy:");
            birthdayImput = Console.ReadLine();
            bool IsDateValid = DateOnly.TryParse(birthdayImput,out dateconverted);
            if(IsDateValid == false) Console.WriteLine($"La fecha que envío no es valida, dato erroneo: {birthdayImput}");
            var person = new Person{
             Name = nameImput,
             Birthday = dateconverted,
             Age = DateTime.Now.Year - dateconverted.Year
            };
            Console.WriteLine($"Tu nombre es: {person.Name}");
            Console.WriteLine($"Tu fecha de nacimiento es: {person.Birthday}");
            Console.WriteLine($"Tu edad es: {person.Age}  años!");

            Console.ReadLine();

        }
    }

    public class Person
    {

        public string Name { get; set; }

        public int Age { get; set; }

        public DateOnly Birthday { get; set; }
    }

}