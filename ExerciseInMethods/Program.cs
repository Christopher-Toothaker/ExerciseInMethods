using System;

namespace ExerciseInMethods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Story();
            Sum();
            Product();
            Difference();
            Qutioent();
            Remainder();
        }

        public static void Story()

        {
            Console.WriteLine($"What is your name?");
            string name = Console.ReadLine();
            Console.Write($"Oh, so {name} is your name?");

            Console.WriteLine($" Then what is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"Alright. What about your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine($"I see... Very disappointing so far... ");
            Console.WriteLine($"((Their favorite animal is a simple {favAnimal} and their favorite color is {favColor}...))");
            Console.WriteLine($"((Terrible taste if you ask me.)) ");

            Console.WriteLine($"Lastly, {name}, do you have a favorite band you listen to?");
            string favBand = Console.ReadLine();
            Console.WriteLine($"Oh! You like {favBand} too?! This is absolutely wonderful! Come, We have much to talk about!");
            Console.WriteLine($"--End Scene--");
            Console.ReadLine();
        }

        public static void Sum()
        {
            Console.WriteLine($"Let's do some addition. Give me a number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Alright, now give me another.");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"Alright. {num1} and {num2} added together gives us... {sum}.");
            Console.ReadLine();
        }

        public static void Product()
        {
            Console.WriteLine($"Let's multiply some numbers. Pick a number.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Okay, and anther one.");
            int y = int.Parse(Console.ReadLine());
            int product = x * y;
            Console.WriteLine($"The product of {x} and {y} is {product}.");
            Console.ReadLine();
        }

        public static void Difference()
        {
            int sub1 = 38;
            Console.WriteLine($"Let's do some subtraction. Pick a number to subtract from {sub1}");
            int sub2 = int.Parse(Console.ReadLine());
            int difference = sub1 - sub2;
            Console.WriteLine($"The difference of {sub1} and {sub2} is {difference}");
            Console.ReadLine();
        }
        public static void Qutioent()

        {
            Console.WriteLine($"Let's divide some numbers. Pick the first one.");
            double div1 = int.Parse(Console.ReadLine());
            double div2 = 3;
            double quotient = div1 / div2;
            Console.WriteLine($"Okay. Let's divide that by {div2}, which should give us... {quotient}.");
            Console.ReadLine();
        }
        public static void Remainder()
        {
            int a = 6;
            int b = 12;
            int c = 20;

            int mod1 = b % a;
            int mod2 = c % b;
            int mod3 = c % a;
            
            Console.WriteLine($"Let's see the remainder of some numbers. Press Enter for each example.");
            Console.ReadLine();
            Console.WriteLine($"The remainder of {b} divided by {a} is {mod1}.");
            Console.ReadLine();
            Console.WriteLine($"For {c} divided by {b}, the remainder is {mod2}.");
            Console.ReadLine();
            Console.WriteLine($"And if we take {a} and divide into {c}, the remainder will be {mod3}.");
            Console.WriteLine("Press Enter to exit.");
        } 

    }
}
