using System;

namespace MethodExercise
{
    class Program
    {
        public static string Name()
        {
            string name = Console.ReadLine();
            return name;
        }
        public static string Color()
        {
            string color = Console.ReadLine();
            return color;
        }

        public static string Element()
        {
            string element = Console.ReadLine();
            return element;
        }

        public static string Animal()
        {
            string animal = Console.ReadLine();
            return animal;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello, what is your name?");
            string name = Name();
            Console.WriteLine("Welcome, {0}! We would like to get to know a little more about you.", name);
            Console.WriteLine("What is your favorite color?");
            string color = Color();

            Console.WriteLine("What is your favorite element?");
            string element = Element();
            Console.WriteLine("What is your favorite animal?");
            string animal = Animal();

            Console.WriteLine("");
            Console.WriteLine("Character Sheet:");
            Console.WriteLine("    Name: " + name);
            Console.WriteLine("    Favorite color: " + color);
            Console.WriteLine("    Favorite element: " + element);
            Console.WriteLine("    Favorite animal: " + animal);

            if (color == "Gold")
                color = "Golden";

            Console.WriteLine("");

            Console.WriteLine($"Avatar Character: {name} the {element}-bender, master of the {color} {animal} technique!");
            //Console.Clear();
            //Console.WriteLine($"How many years have you trained, {color} {animal} master?");

            Console.Clear();
            Console.WriteLine(Sum(1, 3, 5, 7, 9));
            Console.WriteLine(Subtract(100, 50));
            Console.WriteLine(Multiplication(5, 5));
            Console.WriteLine(Divide(100, 5));
            Console.WriteLine(Remainder(100, 11));
        }

        public static int Sum(params int[] args)
        {
            int sum = 0;
            foreach (var item in args)
            {
                sum += item;
            }
            return sum;
            //int sum = num1 + num2;
            //return sum;
            //return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplication(int x, int y)
        {
            return x * y;
        }
        public static int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }
        public static int Remainder(int numerator, int denominator)
        {
            return numerator % denominator;
        }
    }
}
