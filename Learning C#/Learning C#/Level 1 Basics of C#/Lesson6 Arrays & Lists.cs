// 📦 Lesson 6: Arrays & Lists in C#

namespace Complete_C_.Level_1
{
    public class Lesson6
    {
        public void MainMethod()
        {
            // Array
            int[] numbers = new int[5]; // declares an array of 5 integers
            string[] fruits = { "Apple", "Banana", "Cherry" }; // declare and initialize

            string[] cars = { "Tesla", "BMW", "Audi" };
            Console.WriteLine("First car: " + cars[0]); // Tesla

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Car " + (i + 1) + ": " + cars[i]);
            }


            //Lists
            List<string> animals = new List<string>();
            animals.Add("Cat");
            animals.Add("Dogs");

            List<int> scores = new List<int> { 90, 85, 100 };

            scores.Add(75);             // Add new item
            scores.Remove(85);          // Remove item
            scores.Insert(1, 88);       // Insert at index

            foreach (int score in scores)
            {
                Console.WriteLine("Score: " + score);
            }


            string[] favMovies = { "AOT", "DS", "OPM" };
            for (int i = 0; i < favMovies.Length; i++)
            {
                Console.WriteLine(favMovies[i]);
            }

            List<string> cities = new List<string>() { "Delhi", "Dehradun", "Mumbai" };
            cities.Add("Himachal Pradesh");
            cities.Remove("Dehradun");
            cities.Insert(0, "Uttrakhand");
            

            foreach(string city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
