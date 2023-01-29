
namespace TriangleTypeAnalyzer.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation _validation = new Validation();

            string input1,input2,input3 = null;
            bool status = false;

            Console.WriteLine("**Triangle Type Detector**");
            Console.WriteLine("The program will analyze the type of triangle base on user input.");
            Console.WriteLine("User is required to enter integer values for the three (3) sides of the triangle");
            

            while (status == false)
            {
                Console.WriteLine("\nPlease input first side:");
                input1 = Console.ReadLine().ToLower();

                Console.WriteLine("Please input second side:");
                input2 = Console.ReadLine().ToLower();

                Console.WriteLine("Please input third side:");
                input3 = Console.ReadLine().ToLower();

                //Checking of user input
                status = _validation.InputValidation(input1, input2, input3);
            }

            
        }
            
    }
}
