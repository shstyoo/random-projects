using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashTable
{
    class textTable
    {
        // Array of words to ignore
        private string[] _ignoreWords;

        // Method that will read in our text file
        public void readFile(string[] a, string _fileName)
        {
            // Copy the words that should be ignored
            if(global.ignore == true)
            {
                // Copy from array a[] to _ignoreWords
                for(int x = 0; x < a.GetLength(0); x++)
                {
                    _ignoreWords[x] = a[x];
                }
            }

            // Create our new dictionary
            Dictionary<string, int> textTable = new Dictionary<string, int>();
            
            // Int counter for our loop
            int keyValue = 0;

            // Open the file to read from
            string[] words = File.ReadAllText(_fileName).Split(' ');
            
            // Loop through the string array
            for (int x = 0; x < words.GetLength(0); x++)
            {
                if(textTable.ContainsKey(" "))
                {
                    // Do nothing!
                }
                else if(!textTable.ContainsKey(words[x]))
                {
                    textTable.Add(words[x], 1);
                }
                else if(textTable.ContainsKey(words[x]))
                {
                    textTable.TryGetValue(words[x], out keyValue);
                    textTable[words[x]] = keyValue + 1;
                }
            }

                // Loops through a file reader
                /*
                using (StreamReader sr = new StreamReader(_fileName))
                {
                    while (sr.Peek() >= 0)
                    {
                        string line = sr.ReadLine();
                        string[] words = line.Split(' ');
                        foreach (string word in words)
                        {
                            if(!textTable.ContainsKey(word))
                            {
                                keyValue = 1;
                            }
                            else if(textTable.TryGetValue(word, out keyValue))
                            {
                                textTable.Add(word, 0);
                                textTable[word] = keyValue + 1;
                            }
                        }
                    }
                }*/

            // Counter for top 20 words
            int count = 0;

            // Loop to print out our most used words
            if(global.ignore == true)
            {
                foreach (KeyValuePair<string, int> word in textTable.OrderByDescending(key => key.Value))
                {
                    if(word.Key == " " || word.Key == "" || count >= 20)
                    {
                        // Do nothing!
                    }
                    else
                    {
                        for (int x = 0; x < _ignoreWords.GetLength(0); x++)
                        {
                            if (word.Key == _ignoreWords[x])
                            {
                                // Do nothing!
                            }
                            else
                            {
                                Console.WriteLine("Word: {0}, Count {1}", word.Key, word.Value);
                                count++;
                            }
                        }
                    }
                }
            } 
            else if(global.ignore == false)
            {
                foreach (KeyValuePair<string, int> word in textTable.OrderByDescending(key => key.Value))
                {
                    if (word.Key == " " || word.Key == "" || count >= 20)
                    {
                        // Do nothing!
                    }
                    else
                    {
                        Console.WriteLine("Word: {0}, Count: {1}", word.Key, word.Value);
                        count++;
                    }
                }
            }
        }
    }
}
