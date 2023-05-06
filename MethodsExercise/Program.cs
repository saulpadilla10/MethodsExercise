namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is DragonHawk! What is your name?");
            var myName = Console.ReadLine();

            Console.WriteLine($"Hi, {myName}, what color is your shirt?");
            var myShirt = Console.ReadLine();

            Console.WriteLine($"Wow! {myShirt} is my favorite color! What is your favorite animal?");
            var myPet = Console.ReadLine();

            Console.WriteLine($"Woah. {myPet}? That's my favorite too! What's you favorite band?");
            var myBand = Console.ReadLine();

            Console.WriteLine($"No. Way. {myBand}?!");
            Console.WriteLine($"So, what I learned from this, {myName}, is:");
          
            Console.WriteLine($"1. Your shirt color, {myShirt}. My favorite.");
            Console.WriteLine($"2. Favorite animal: {myPet}. My favorite.");
            Console.WriteLine($"3. Favorite Band: {myBand}. Also mine.");
            Console.WriteLine("And we are now best friends.");

        }
    }
}
