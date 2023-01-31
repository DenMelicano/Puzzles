using System;
using System.Collections.Generic;
using System.Reflection;

namespace LinkedListFifthElementExtractor.App
{
    public class LinkedList
    {
        public int count;
        LinkedListNode head;

        public LinkedList()
        {
            count = 0;
            head = null;
        }

        public void AddNodeToFront(int data)
        {
            LinkedListNode node = new LinkedListNode(data); //TODO make test
            node.next = head;
            head = node;
            count++;
            
        }


        /* if you want to see the reverse sequence of the linked list
          - This was not implemented on the main program
         */
        public void PrintList()
        {
            LinkedListNode runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }


        public int ExtractNode()
        {
            LinkedListNode indexer = head;
            int ExtractIndex = 0;
            var results = 0;


            while (ExtractIndex != 5)
            {
                ExtractIndex++;
                if (ExtractIndex == 5)
                {
                    DisplayResult(indexer.data);
                    return results = indexer.data;
                }
                else
                {
                    indexer = indexer.next;
                }
                
            }
            return results = indexer.data;
        }

        private void DisplayResult(int data)
        {
            Console.WriteLine("The 5th node from tail is: " + data);
        }
    }
}
