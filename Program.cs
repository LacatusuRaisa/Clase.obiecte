// See https://aka.ms/new-console-template for more information
using Clase.obiecte;


class Program
{

    static void Main(string[] args)
    {
        Car Ford = new Car("Mustang", "white", 2021, 100);
        Car Opel = new Car("Astra", "blue", 2020, 120);
        //Ford.name = "Mustang";
        // Ford.year = 2021;
        // Ford.color = "white";
        //Ford.maxSpeed = 100;

        //Opel.name = "Astra";
        //Opel.color = "blue";
        // Opel.year = 2020;
        // Opel.maxSpeed = 120;

        Console.WriteLine(Ford.name);
        Console.WriteLine(Ford.color);
        Console.WriteLine(Ford.year);
        Ford.fullThrottle();
        Console.WriteLine(Opel.name);
        Console.WriteLine(Opel.color);
        Console.WriteLine(Opel.year);
        Opel.fullThrottle();
        Console.ReadKey();


    }
}