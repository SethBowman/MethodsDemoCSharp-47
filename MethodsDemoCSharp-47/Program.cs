namespace MethodsDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling a method (using a method)
            GreetPerson("Seth");
            GreetPerson("Mack");

            int twoPlusTwo = AddTwoNumbers(2, 2);
            int threePlusThree = AddTwoNumbers(3, 3);

            Console.WriteLine(twoPlusTwo);
            Console.WriteLine(threePlusThree);

            GetUserNameAndGreet();           
        }

        //Method definition (creating a method)
        //Disregard the keyword "static" until we get to that lesson
        //Pascal casing - EveryWordStartsWithCapital
        //Parts of a method
        //Access modifier - return type - method name - parameter list - scope/body (what the method does)
        public static void GreetPerson(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        public static int AddTwoNumbers(int numOne, int numTwo)
        {
            return numOne + numTwo;
            // * multiply
            // / divide
        }

        public static void GetUserNameAndGreet()
        {
            Console.WriteLine("Please enter your name:");

            string name = Console.ReadLine();

            Console.WriteLine($"Hey, {name}.");
        }
    }
}
