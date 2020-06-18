using System;
using System.Collections.Generic;
using System.Linq;

namespace EnquireCodeProblems
{
    public static class EnquireCodeProblemSolutions
    {
        /// <summary>
        /// Finds the Fibonacci number that follows the passed value.
        /// </summary>
        /// <param name="x">A value that is between the nth and nth + 1 Fibbonacci numbers</param>
        /// <returns>The Fibonacci that follows the provided value</returns>
        /// <remarks>
        /// Uses recurssion to calculate a Fibonacci number.
        /// This will not perform as well as the looping solution because it recalculates previously found fibonacci numbers.
        /// </remarks>
        public static int NextFibonacciRecursive(int x)
        {
            int next = 0;
            int pos = 0;
            while(x >= next)
            {
                pos++;
                next = GetFibonacci(pos);
            }
            return next;
        }

        /// <summary>
        /// Finds the Fibonacci number that follows the passed value.
        /// </summary>
        /// <param name="x">A value that is between the nth and nth + 1 Fibbonacci numbers</param>
        /// <returns>The Fibonacci that follows the provided value</returns>
        /// <remarks>
        /// Stays in the same "stack frame" using a loop to calculate a Fibonacci number.
        /// </remarks>
        public static int NextFibonacciLoop(int x)
        {
            int f1 = 0;
            int f2 = 1;
            while (f2 <= x)
            {
                int temp = f1;
                f1 = f2;
                f2 = temp + f1;
            }
            return f2;
        }

        /// <summary>
        /// Calculates the Fibonacci number that is at the nth, 1 based, position.
        /// </summary>
        /// <param name="nth">The position of a Fibonacci number</param>
        /// <returns>The Fibonacci number at the nth postion</returns>
        public static int GetFibonacci(int nth)
        {
            if (nth < 1)
            {
                throw new ArgumentOutOfRangeException("The position of a Fibonacci number must be greater than zero");
            }
            if (nth == 1) //first is zero
            {
                return 0;
            }
            else if (nth == 2 || nth == 3) //second and third are fibs are 1
            {
                return 1;
            }
            else
            {
                return GetFibonacci(nth - 1) + GetFibonacci(nth - 2);
            }
        }

        /// <summary>
        /// Finds the words that are annograms of the provided original word.
        /// </summary>
        /// <param name="candidates">A collection of words, single continous string of letters, to check against.</param>
        /// <param name="word">The orginal word that will have zero or more annograms in candidates collection</param>
        /// <returns>The annograms of the original word</returns>
        /// <remarks>
        /// Sigh, a very convoluted way.
        /// </remarks>
        public static IEnumerable<string> GetAnnograms(IEnumerable<string> candidates, string word)
        {
            List<string> annograms = new List<string>();
            foreach(string str in candidates)
            {
                if (IsAnnogram(word, str))
                {
                    annograms.Add(word);
                }
            }
            return annograms;
        }

        /// <summary>
        /// Checks to see if two words have the letters, and same count of a specific letter, thereby making them annograms of each other.
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool IsAnnogram(string word1, string word2)
        {
            //TODO: Should the casing of the words match?
            //TODO: check to see if .NET's newish span would be a better fit than a raw array.
            if (word1.Length != word2.Length)
                return false;
            char[] word2Chars = word2.ToArray();
            for(int i = 0; i < word1.Length - 1; i++)
            {
                int firstIdx = GetFirstIndex(word1[i], word2Chars, 0, word1.Length - i);
                if (firstIdx == -1)
                    return false;
                char temp = word2Chars[firstIdx];
                word2Chars[firstIdx] = word2Chars[word1.Length - i - 1];
                word2Chars[word1.Length - i - 1] = temp;
            }
            return true;
        }

        /// <summary>
        /// Finds the first index of a character in an array of characters 
        /// </summary>
        /// <param name="letter">The letter to find.</param>
        /// <param name="word">The word, or array of chars, to search.</param>
        /// <param name="startPos">The starting position to begin the search.</param>
        /// <param name="count">The number of characters to search.</param>
        /// <returns>
        /// -1: Letter not found in the word
        /// Greater than zero: The index of the first occurence of a letter in a word.
        /// </returns>
        /// <remarks>
        /// Trying not to use my hardest to not use LINQ or other framework provided features.
        /// </remarks>
        public static int GetFirstIndex(char letter, char[] word, int startPos, int count)
        {
            for (int i = startPos; i < count; i++)
            {
                if (word[i] == letter)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
