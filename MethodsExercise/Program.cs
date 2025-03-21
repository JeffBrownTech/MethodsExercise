namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();

            Console.WriteLine("What is your favorite book?");
            string book = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your pet's name?");
            string pet = Console.ReadLine();

            CreateStory(name, food, book, color, pet);
        }

        public static void CreateStory (string name, string food, string book, string color, string pet)
        {
            Console.WriteLine($"{name} sat under a tree wearing a {color} hoodie.");
            Console.WriteLine($"{name} shared some {food} with their pet, {pet}.");
            Console.WriteLine($"{name} flipped open {book} to read another chapter.");
        }
    }
}
