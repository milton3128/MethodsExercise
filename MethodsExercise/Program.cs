namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MethodEX();

            int added = Add(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtract(20, 7);
            Console.WriteLine(subtracted);

            int multiply = Multiply(2, 3);
            Console.WriteLine(multiply);

            int divide = Divide(4, 2);
            Console.WriteLine(divide);

            int result = Sum(2, 2, 2, 2, 2);
            Console.WriteLine(result);
        }

        public static void MethodEX()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Well, hello {userName}!. What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"Once upon a time {userName} was walking on the ocean shore.  {userName} saw {favColor} and a {favAnimal} flying every where while listening to {favBand}");

        }

        public static int Add( int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Subtract( int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public static int Multiply( int numOne, int numTwo)
        {
            return numOne * numTwo;
        }

        public static int Divide( int numOne, int numTwo)
        {
            return numOne / numTwo;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum; 
        }
    }
}
