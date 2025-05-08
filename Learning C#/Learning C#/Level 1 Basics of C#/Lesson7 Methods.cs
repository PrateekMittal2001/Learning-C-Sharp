// 🧱 Lesson 7: Methods in C#

//✅ Why Use Methods?
// Reusability: Write once, use multiple times

// Readability: Break down complex logic into manageable parts

// Modularity: Makes debugging and testing easier


// 1.Defining a Method
// 📌 Syntax:
// return_type MethodName(parameter_list)
// {
//    // code
//    return value; // if return_type is not void
// }

// void GreetUser(string name)
// {
//     Console.WriteLine("Hello, " + name);
// }


// 2.Method with Return Value
// int Add(int a, int b)
// {
//     return a + b;
// }
 
// int result = Add(5, 3);
// Console.WriteLine("Sum: " + result);


// 3.Method Overloading
// You can define multiple methods with the same name but different parameter types or counts.

// int Multiply(int a, int b) => a * b;
// double Multiply(double a, double b) => a * b;


//🔹 4.Static vs Non-static
// Static method: belongs to the class
// Non-static method: belongs to an instance (object)

// Static method
// static void SayHi() => Console.WriteLine("Hi");

// Non-static method
// void SayBye() => Console.WriteLine("Bye");




namespace Complete_C_.Level_1
{
    public class Lesson7
    {
        public static int Square(int x)
        {
            return x * x;
        }

        public static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        public static void PrintGreeting(string name)
        {
            Console.WriteLine("Welcome, " + name);
        }

        public static void MainMethod()
        {
            int ans = Square(20);
            Console.WriteLine(ans);

            Console.WriteLine("6 is even? " + IsEven(6));
            Console.WriteLine("9 is even? " + IsEven(9));

            PrintGreeting("Prateek");
        }
    }
}
