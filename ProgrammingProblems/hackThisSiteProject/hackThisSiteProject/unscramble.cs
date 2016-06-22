using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackThisSiteProject
{
    class unscramble
    {

        public static void unscramble(int a)
        {
            // We will declare some heuristics for the search algorithm that will match
            // the unscrambled words

            // True/False for match
            bool match = false;

            // Vowels and other uncommon letters
            string[] vowel = { "a", "e", "i", "o", "u", "y", "z", "q" };

            // Nested for loops will allow the program to quickly find potential unscrambled words
            // If the word length is not the same, the program will skip the word as a potential candidate
            for(int x = 0; x < global.words.Length; x++)
            {
                for (int y = 0; y < global.wordList.Length; y++)
                {
                    if (global.words[x].Length == global.wordList[x].Length)
                    {
                        for (int i = 0; i < vowel.Length; i++)
                        {
                            if(vowel[i] == )
                        }
                    }
                    else
                    {
                        match = false;
                        break;
                    }
                }
            }
        }
    }
}
