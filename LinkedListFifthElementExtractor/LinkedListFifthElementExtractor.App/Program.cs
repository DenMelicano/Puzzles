
using LinkedListFifthElementExtractor.App;

namespace LinkedListfifthElementExtractor.App
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Validation _validation = new Validation();

            //User Prompt
            Console.WriteLine("**Linked List Extractor**");
            Console.WriteLine("Enter a value");
            Console.WriteLine("Press 'q' to extract the 5th element/node from the link");
            Console.WriteLine("or 'x' to exit the program");
            string input = null;
           
            //User inputs data
            while(input != "x")
            {
                input = Console.ReadLine().ToLower(); // converts all sting input to lowercase
                _validation.InputValidation(input);   // process input for data validation          
            }

        }
    } 
   
}
