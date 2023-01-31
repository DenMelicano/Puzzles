namespace WordReversing.App
{
    public class WordReverser
    {
        public string ReverseString(string input)
        {
            /* This function only reverses per word. the WordStack class assures that words are splitted before 
             passed on this function*/

            string result = "";
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }

            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            return result;
        }
    }
}
