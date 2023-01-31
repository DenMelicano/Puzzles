namespace WordReversing.App
{
    public class WordReverser
    {
        public string ReverseString(string input)
        {
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
