namespace WordReversing.App
{
    public class WordStack
    {
        public int WordCount = 0;

        public string AggregateWords(string str)
        {
            /* There is no actual reversing in this function, it only stacks the words in proper order and 
             passed it to WordReverser function. It also adds spaces in-between words, since the spaces
             will be removed during split.*/

            WordReverser _wordReverser= new WordReverser();

            string result = string.Empty;

            string[] wordArray = str.Split(" ");
            CheckWordCount(wordArray); // to return number of words stacked, for checking purposes.

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
        private void CheckWordCount(string[] WordArray)
        {
            //This function simply gives the count of stacked words    
            WordCount = WordArray.Length;
            
        }
        private void DisplayResult(string reversedWords)
        {
            Console.WriteLine("\n the reversed word is:\n {0}",reversedWords);
        }
    }
}
