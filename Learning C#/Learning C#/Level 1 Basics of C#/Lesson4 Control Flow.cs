// Lesson 4: Control Flow in C# (if-else, switch-case)

namespace Complete_C_.Level_1
{
    public class Lesson4
    {
        public void MainMethod()
        {
            //int marks = 85;
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (marks >= 75)
            {
                Console.WriteLine("Very Good");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }

            //char grade = 'A';
            char grade = char.ToUpper(Console.ReadKey().KeyChar);

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Top grade");
                    break;
                case 'B':
                    Console.WriteLine("Above average");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                    break;
                default:
                    Console.WriteLine("Try Again");
                    break;

            }

        }
    }
}
