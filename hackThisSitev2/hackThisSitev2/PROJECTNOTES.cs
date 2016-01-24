using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackThisSitev2
{
    class PROJECTNOTES
    {
        #region Project 1 Notes

        #endregion

        #region Project 2 Notes

        #endregion

        #region Project 4 Notes

        #endregion

        #region Project 6 Notes

        /* Program Outline
         * 
         * Find the pixelWordColor that isn't pixelBaseColor using getPixel(x,y).
         * The intention here is to find the color that doesn't match the base image color.
         * (In this particular example, the base color is BLACK and the word color is GREEN).
         * 
         * After that specific pixel color is found, start recursive function that searches
         * all adjacent pixels to find similar colored pixels.
         * 
         * After all similar colored pixels are recursively found, create a new bitmap that 
         * contains only the similar colored pixels.
         * 
         * In order to create the similarly colored pixel bitmap, we will have to use the 
         * relative coordinates (x1-x2, y1-y2) in our new bitmap.
         * (SEE NOTES: "Bitmap Reading")
         * 
         * Run OCR algorithm to find corresponding letter to each bitmap. Store those letters
         * into a list. Reverse the list at the end and output.
         */

        /* Bitmap Reading
         * 
         * After creating our new bitmap we have two options. 
         * 
         * 1) We can assess using OCR for each degree (0-360) each bitmap letter we create.
         *      a) We match the alphabet (A-Z, a-z, 0-9) at each degree until a match is found
         *      
         * 2) We can use an algorithm to "shift" the letter before we run OCR on the image.
         *      b) After we shift, we match the alphabet once to find a match. If a match is 
         *         not found, we rotate 90 degrees and try again.
         *         
         * The Big N of each method (Worst Case Scenario):
         * 1) (360 * 62) * (N) * (OCR) =
         *    (#OfDegrees * #OfLettersInAlphabet) * (#OfLettersInImage) * (Cost of OCR)
         * 2) (L) * (62) * (4) * (OCR) = 
         *    (Cost of "shift") * (#OfLettersInAlphabet) * (#OfRotations) * (Cost of OCR)
         * 
         * The only benefit we could find in choosing 1 or 2 the potential to see which 
         * algorithm will run faster or use less memory. We may want to interchange the methods 
         * 1 and 2 for most efficiency in decrypting the letters.
         */

        #endregion

    }
}
