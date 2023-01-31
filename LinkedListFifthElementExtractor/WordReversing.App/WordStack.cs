namespace WordReversing.App
{
    public class WordStack
    {
        public string AggregateWords(string str)
        {
            WordReverser _wordReverser= new WordReverser();

            string result = string.Empty;

            string[] wordArray = str.Split(" ");

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (i != wordArray.Length - 1)
                {
                    result += _wordReverser.ReverseString(wordArray[i]);
                    result += " ";
                   
                }
                else
                {
                    result += _wordReverser.ReverseString(wordArray[i]);
                }
            }

            DisplayResult(result);
            return result;
        }

        private void DisplayResult(string reversedWords)
        {
            Console.WriteLine("\n the reversed word is:\n {0}",reversedWords);
        }
    }
}
