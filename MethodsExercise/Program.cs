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

            Console.WriteLine($"Woah. {myPet} are my favorite too! What's you favorite band?");
            var myBand = Console.ReadLine();

            Console.WriteLine($"No. Way. {myBand} is my favorite! Did we just become best friends?!");
           
        }
    }
}
