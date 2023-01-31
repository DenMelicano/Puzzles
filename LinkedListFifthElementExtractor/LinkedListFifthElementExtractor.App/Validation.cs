

using System.Security.Cryptography.X509Certificates;

namespace LinkedListFifthElementExtractor.App
{
    public class Validation
    {
        LinkedList _linkedList = new LinkedList();
        public int count = 0;

        public string InputValidation(string input)
        {
            string status = string.Empty;
           int num = -1;

           if(input != "x")
            {
                if (!int.TryParse(input, out num))
                {
                    if (input != "q")
                    {
                        Console.WriteLine("Invalid Input. Please try again!");
                        status = "Non-Numerical";
                       
                    }
                    else
                    {
                        if (count < 5)
                        {
                            Console.WriteLine("Node is less than 5; Add more!");
                            status = "Insufficient Node";
                           

                        }
                        else
                        {
                            //Extracting the 5th element from the tail
                            status = "Success";
                            
                            _linkedList.ExtractNode(); // updated the method signature : remove input count
                            return status;
                            System.Environment.Exit(0);
                        }

                    }
                }
                else
                {
                    status = "Node Added";
                    
                    _linkedList.AddNodeToFront(num);       
                    count++;
                    return status;
                }
            
            }
            else
            {
                status = "Program Terminated";
            }
            
            return status;
            System.Environment.Exit(0);
        }

    }
}
