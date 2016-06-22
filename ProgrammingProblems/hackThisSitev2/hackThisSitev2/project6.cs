using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace hackThisSitev2
{
    class project6
    {
        private Bitmap imageToDecrypt;
        private Bitmap letterToOCR;
        private Color pixelBaseColor;
        private Color pixelWordColor;
        private List<int> pixelList = new List<int>();
        private bool searchComplete = false;

        public void analyzeFile()
        {
            readImageFile();

            for(int heightCounter = 0; heightCounter < imageToDecrypt.Height; heightCounter++)
            {
                for(int widthCounter = 0; widthCounter < imageToDecrypt.Width; widthCounter++)
                {
                    if(imageToDecrypt.GetPixel(widthCounter, heightCounter) == pixelWordColor)
                    {
                        cutLetter(widthCounter, heightCounter);
                    }
                }
            }
        }

        private void readImageFile()
        {
            imageToDecrypt = new Bitmap(globalVars.decryptImageLoc);

            #region Find Base and Word Pixel Colors

            pixelBaseColor = imageToDecrypt.GetPixel(0, 0);

            bool breakLoop = false;

            for(int counter = 0; counter < imageToDecrypt.Height; counter++)
            {
                for(int counter2 = 0; counter2 < imageToDecrypt.Width; counter2++)
                {
                    if(imageToDecrypt.GetPixel(counter2, counter) == pixelBaseColor)
                    {
                        // DO NOTHING
                    }
                    else if(imageToDecrypt.GetPixel(counter, counter2) != pixelBaseColor)
                    {
                        pixelWordColor = imageToDecrypt.GetPixel(counter, counter2);
                        breakLoop = true;
                        break;
                    }
                }

                if(breakLoop == true)
                {
                    break;
                }
            }

            #endregion

        }

        private void cutLetter(int x, int y)
        {
            if(searchComplete == true)
            {

            }
            else if(searchComplete == false)
            {

            }
        }

        private void letterToNewImage(int imageHeight, int imageWidth)
        {
            
        }

        private void OCR()
        {

        }
    }
}
