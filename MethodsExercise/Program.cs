namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        public static int Alltogether(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 * num3 / num4;
        }


        static void Main(string[] args)
        {

            var answerTrue = Sum(2, 6);
            var idkSomething = Multiply(60, 2, 4);
            var release = Subtract(1000, 1);
            var share = Divide(10000, 3);
            var savings = Modulus(100, 33);
            var tour = Alltogether(2, 4, 6, 8);

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
