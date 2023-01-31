

using System.Security.Cryptography.X509Certificates;

namespace LinkedListFifthElementExtractor.App
{
    public class Validation
    {
        LinkedList _linkedList = new LinkedList();
        int count = 0;

        public void InputValidation(string input)
        {
           
           int num = -1;

           if(input != "x")
            {
                if (!int.TryParse(input, out num))
                {
                    if (input != "q")
                    {
                        Console.WriteLine("Invalid Input. Please try again!");
                    }
                    else
                    {
                        if (count < 5)
                        {
                            Console.WriteLine("Node is less than 5; Add more!");
                        }
                        else
                        {
                            //Extracting the 5th element from the tail
                            _linkedList.ExtractNode(); // updated the method signature : remove input count
                            System.Environment.Exit(0);
                        }

                    }
                }
                else
                {
                    _linkedList.AddNodeToFront(num);
                    count++;
                }
            }
            

           
        }

    }
}
