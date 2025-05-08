namespace Complete_C_.Level_1
{
    public class Challenge_1
    {
        public static void MainMethod()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            numbers.Sort();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
