using System;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence:");
            string sentence = Console.ReadLine();

            string reversed = ReverseWordsInSentence(sentence);
            Console.WriteLine("Reversed sentence: " + reversed);
        }

        static string ReverseWordsInSentence(string sentence)
        {
            int n = sentence.Length;
            char[] sentenceAsChars = sentence.ToCharArray();

            int start = 0, end = 0;
            ReverseWords(sentenceAsChars, start, n - 1);

            for (int i = 0; i < n; i++)
            {
                if (sentenceAsChars[i] == ' ')
                {
                    end = i - 1;
                    ReverseWords(sentenceAsChars, start, end);
                    start = i + 1;
                }
            }

            ReverseWords(sentenceAsChars, start, n - 1);
            return new string(sentenceAsChars);
        }

        static void ReverseWords(char[] sentenceAsChars, int start, int end)
        {
            while (start < end)
            {
                char temp = sentenceAsChars[start];
                sentenceAsChars[start] = sentenceAsChars[end];
                sentenceAsChars[end] = temp;
                start++;
                end--;
            }
        }
    }
}