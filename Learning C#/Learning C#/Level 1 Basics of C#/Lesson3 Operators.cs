// 🧮 Lesson 3: Operators in C#

namespace Complete_C_.Level_1
{
    public class Lesson3
    {
        static void MainMethod()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + ((double)a / b));
            Console.WriteLine("Remainder: " + (a % b));

            bool isGreater = a > b;

            Console.WriteLine("a is greater than b? " + isGreater);

            bool condition = (a > 0) && (b > 0);
            Console.WriteLine("Both conditions true? " + condition);
        }
    }
}
