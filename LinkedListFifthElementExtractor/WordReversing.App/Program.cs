namespace WordReversing.App
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            WordStack _wordStack = new WordStack();

            string result = string.Empty;

            Console.WriteLine("**Word Reverser**");
            Console.WriteLine("Enter a sentence or group of words you would like to be reversed in order: ");
            string str = Console.ReadLine();


            result = _wordStack.AggregateWords(str);
            System.Environment.Exit(0);
        }
    }
}
