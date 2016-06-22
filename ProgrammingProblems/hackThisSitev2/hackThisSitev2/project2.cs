using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace hackThisSitev2
{
    class project2
    {
        #region Private Variables
        private List<int> asciiEncoding = new List<int>();
        private List<string> morseEncoding = new List<string>();
        private List<string> decrypedMessage = new List<string>();
        private Bitmap imageToBeParsed;
        private Color pixelBaseColor;
        #endregion


        private void initializeBitmap()
        {
            imageToBeParsed = new Bitmap(globalVars.imageLocation);
            pixelBaseColor = imageToBeParsed.GetPixel(0, 0);
        }

        public void parseThruBitmap()
        {
            initializeBitmap();

            int startPositionX = 0;

            int hitCounter = 0;

            for(int heightCounter = 0; heightCounter < imageToBeParsed.Height; heightCounter++)
            {
                for(int widthCounter = 0; widthCounter < imageToBeParsed.Width; widthCounter++)
                {
                    Color pixelColor = imageToBeParsed.GetPixel(widthCounter, heightCounter);
                    if(pixelColor != pixelBaseColor)
                    {
                        asciiEncoding.Add(((widthCounter - startPositionX) + (100 * heightCounter)));
                        startPositionX = (widthCounter + (100 * heightCounter));
                        hitCounter++;
                    }
                }
            }

            convertAsciiToMorse(asciiEncoding);
            convertMorseToLetters(morseEncoding);
            printTestAscii();
            printTestMorse();
            Console.WriteLine("Here is the Decrypted Message:");
            globalFunc.createLineDivider();
            foreach (string value in decrypedMessage)
            {
                Console.Write(value);
            }
            printMessageToFile(decrypedMessage);
            globalFunc.createLineDivider();
            Console.WriteLine("This message has been saved to \"decryptedMessage.txt\"");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
            displayAndProcessMenuOptions.mainMenuDisplay();
        }

        public void convertAsciiToMorse(List<int> asciiEncoding)
        {
            string tempString = "";
            for(int counter = 0; counter < asciiEncoding.Count; counter++)
            {
                tempString += ((char)asciiEncoding[counter]).ToString();
            }
            morseEncoding = tempString.Split(' ').ToList();
        }

        public void convertMorseToLetters(List<string> morseEncoding)
        {
            string tempString;

            for (int counter = 0; counter < morseEncoding.Count; counter++)
            {
                if (globalVars.morseToLetterDict.ContainsKey(morseEncoding[counter]))
                {
                    globalVars.morseToLetterDict.TryGetValue(morseEncoding[counter], out tempString);
                    decrypedMessage.Add(tempString);
                }
            }
        }

        public void printMessageToFile(List<string> messageToPrint)
        {
            using (StreamWriter writeToFile = File.AppendText("decryptedMessage.txt"))
            {
                for (int counter = 0; counter < messageToPrint.Count; counter++)
                {
                    writeToFile.Write(messageToPrint[counter]);
                }
            }
        }

        #region Debugging Purposes
        public void printTestAscii()
        {
            globalFunc.createLineDivider();
            for(int counter = 0; counter < asciiEncoding.Count; counter ++)
            {
                Console.WriteLine(asciiEncoding[counter]);
            }
            globalFunc.createLineDivider();
            Console.ReadLine();
        }
        public void printTestMorse()
        {
            globalFunc.createLineDivider();
            for (int counter = 0; counter < morseEncoding.Count; counter++)
            {
                Console.WriteLine(morseEncoding[counter]);
            }
            globalFunc.createLineDivider();
            Console.ReadLine();
        }
        #endregion Debugging Purposes

    }
}
