using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hackThisSitev2
{
    class project1
    {
        private string[] words;
        private string[] wordBank;

        private void readWordsFromFile()
        {
            words = File.ReadAllLines(globalVars.wordsLocation);
            wordBank = File.ReadAllLines(globalVars.wordBankLoc);
        }

        public void unscrambleWords()
        {
            readWordsFromFile();

            for(int wordCounter = 0; wordCounter < words.Length; wordCounter++)
            {
                int wordLength = words[wordCounter].Length;

                int numberOfMatches = 0;

                for(int wordBankCounter = 0; wordBankCounter < wordBank.Length; wordBankCounter++)
                {
                    int wordBankLength = wordBank[wordBankCounter].Length;

                    if(wordLength == wordBankLength)
                    {
                        if (matchingLetters(words[wordCounter], wordBank[wordBankCounter]))
                        {
                            numberOfMatches++;
                            Console.WriteLine(wordBank[wordBankCounter]);
                            printWords(wordBank[wordBankCounter]);
                        }
                    }
                }

                if(numberOfMatches > 1)
                {
                    // Potentially add an exception for different words that use the same letters
                    // Think { "PALE", "LEAP", "PLEA" }
                    Console.WriteLine("Program doesn't know what to do.");
                    Console.WriteLine("Perhaps the word bank contains more than");
                    Console.WriteLine(" one word with different spellings e.g:");
                    Console.WriteLine("PALE, LEAP, PLEA");
                }
                else if (numberOfMatches == 1)
                {
                    // Program working as intended. Let the loop continue.
                }
                else
                {
                    Console.WriteLine("Error!! Program just outputted less than 1 results matching");
                    Console.WriteLine("Enter any key to exit");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("Unscrambling words completed. Output has been placed here, and");
            Console.WriteLine("at the project directory under \"matchedWords.txt\"");
            Console.ReadLine();
            displayAndProcessMenuOptions.mainMenuDisplay();
        }

        public bool matchingLetters(string word, string wordToCompare)
        {
            int letterMatchCounter = 0;

            for(int letterCounterWord = 0; letterCounterWord < word.Length; letterCounterWord++)
            {
                for(int letterCounterWordBank = 0; letterCounterWordBank < wordToCompare.Length; letterCounterWordBank++)
                {
                    if(word[letterCounterWord] == wordToCompare[letterCounterWordBank])
                    {
                        letterMatchCounter++;
                        wordToCompare = wordToCompare.Remove(letterCounterWordBank, 1);
                        break;
                    }
                }
            }

            if(letterMatchCounter == word.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void printWords(string wordToBePrinted)
        {
            using(StreamWriter writeToFile = File.AppendText("matchedWords.txt"))
            {
                writeToFile.Write(wordToBePrinted + ",");
            }
        }
    }
}
