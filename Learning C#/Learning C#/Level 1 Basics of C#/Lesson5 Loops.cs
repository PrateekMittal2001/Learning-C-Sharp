// Lesson 5: Loops in C#

namespace Complete_C_.Level_1
{
    public class Lesson5
    {
        public void MainMethod()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int j = 5;
            while (j >= 1)
            {
                Console.WriteLine("Count: " + j);
                j--;
            }

            int k = 1;
            do
            {
                Console.WriteLine("Running");
                k++;
            } while (k <= 3);

            string[] fruits = { "Apple", "Mango" }; ;
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
            }

        }
    }
}
