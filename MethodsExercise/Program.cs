namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add(20, 5);
            //Subtract(20, 5);
            //Divide(20, 5);
            //Multiply(20, 5);

            //Story();

            int sum = AddAllNums(5, 20, 50, 100, 200, 25);
            Console.WriteLine(sum);
        }


        public static void Story()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("Where do you work?");
            string work = Console.ReadLine();

            Console.WriteLine("What kind of car do you drive?");
            string car = Console.ReadLine();

            Console.WriteLine($"There was a woman named {userName}, she was {age} years old.");
            Console.WriteLine($"She drove her {car} to {work}.");
            Console.WriteLine($"She loved to drive her {car}, but did not like driving it to {work}.");


     
        }
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
            return result;

        }


        public static int Subtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
            return result;
        }


        public static int Divide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
            return result;
        }

        public static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);
            return result;
        }


        public static int AddAllNums(params int[] nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                sum = +num;
            }

            return sum;
        }
    }
}
