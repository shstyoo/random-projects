using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;
using System.Drawing;
using System.Windows;

namespace hackThisSitev2
{
    class project4
    {
        private XmlDocument xmlFile;
        private XmlNodeList arcElementList;
        private XmlNodeList lineElementList;
        private Bitmap generatedBitmap;

        private void initializeXML()
        {
            xmlFile = new XmlDocument();
            xmlFile.Load(globalVars.xmlLocation);
        }

        private void initializeBitmap()
        {
            generatedBitmap = new Bitmap(600, 600);
            for (int heightCounter = 0; heightCounter < generatedBitmap.Height; heightCounter++)
            {
                for (int widthCounter = 0; widthCounter < generatedBitmap.Width; widthCounter++)
                {
                    generatedBitmap.SetPixel(widthCounter, heightCounter, Color.Black);
                }
            }
        }

        public void parseThroughXML()
        {
            initializeXML();
            initializeBitmap();

            // Read each ARC and LINE element into a List we can iterate through
            arcElementList = xmlFile.GetElementsByTagName("Arc");
            lineElementList = xmlFile.GetElementsByTagName("Line");

            // Loop through Arc List to print to bitmap
            for(int i = 0; i < arcElementList.Count; i++)
            {
                #region Arc Elements
                string XCenter = "";
                string YCenter = "";
                string radius = "";
                string arcExtend = "";
                string arcStart = "";
                string color = "";
                #endregion

                #region Arc Element Assigning
                XCenter = arcElementList.Item(i)["XCenter"].InnerXml;
                YCenter = arcElementList.Item(i)["YCenter"].InnerXml;
                radius = arcElementList.Item(i)["Radius"].InnerXml;
                arcExtend = arcElementList.Item(i)["ArcExtend"].InnerXml;
                arcStart = arcElementList.Item(i)["ArcStart"].InnerXml;
                if (arcElementList.Item(i)["Color"] == null)
                {
                    color = "white";
                }
                else if(arcElementList.Item(i)["Color"].InnerXml != null)
                {
                    color = arcElementList.Item(i)["Color"].InnerXml;
                }
                #endregion

                drawArcToBitmap(XCenter, YCenter, radius, arcExtend, arcStart, color);
            }

            // Loop through Line List to print to bitmap
            for(int i = 0; i < lineElementList.Count; i++)
            {
                #region Line Elements
                string _XStart = "";
                string _YStart = "";
                string _XEnd = "";
                string _YEnd = "";
                string _Color = "";
                #endregion

                #region Line Element Assigning
                _XStart = lineElementList.Item(i)["XStart"].InnerXml;
                _YStart = lineElementList.Item(i)["YStart"].InnerXml;
                _XEnd = lineElementList.Item(i)["XEnd"].InnerXml;
                _YEnd = lineElementList.Item(i)["YEnd"].InnerXml;
                if (lineElementList.Item(i)["Color"] == null)
                {
                    _Color = "white";
                }
                else if (lineElementList.Item(i)["Color"].InnerXml != null)
                {
                    _Color = lineElementList.Item(i)["Color"].InnerXml;
                }
                #endregion 

                drawLineToBitmap(_XStart, _XEnd, _YStart, _YEnd, _Color);
            }

            printGeneratedBitmap(generatedBitmap);
        }

        private void drawArcToBitmap(string xCenter, string yCenter, string radius, string arcExtend, string arcStart, string color)
        {
            #region Create Pen and Colors
            Pen penColor = new Pen(Color.FromName(color), 1);
            #endregion

            #region Converting String to Int
            float x = Convert.ToSingle(xCenter) - Convert.ToSingle(radius);
            float y = Convert.ToSingle(yCenter) - Convert.ToSingle(radius);
            float r = Convert.ToSingle(radius);
            float aE = Convert.ToSingle(arcExtend);
            float aS = Convert.ToSingle(arcStart);
            #endregion

            #region Converting to Height and Width
            float h = r * 2;
            float w = r * 2;
            #endregion

            using (var graphics = Graphics.FromImage(generatedBitmap))
            {
                graphics.DrawArc(penColor, x, y, h, w, aS, aE);
            }
        }

        private void drawLineToBitmap(string xStart, string xEnd, string yStart, string yEnd, string color)
        {
            #region Create Pen and Colors
            Pen penColor = new Pen(Color.FromName(color), 1);
            #endregion

            #region Converting String to Int
            float x1 = Convert.ToSingle(xStart);
            float x2 = Convert.ToSingle(xEnd);
            float y1 = Convert.ToSingle(yStart);
            float y2 = Convert.ToSingle(yEnd);
            #endregion 
            using (var graphics = Graphics.FromImage(generatedBitmap))
            {
                graphics.DrawLine(penColor, x1, y1, x2, y2);
            }
        }

        private void printGeneratedBitmap(Bitmap bitmapToPrint)
        {
            bitmapToPrint.RotateFlip(RotateFlipType.Rotate180FlipY);
            bitmapToPrint.Save("generatedImage.bmp");
            Console.WriteLine("Generated Bitmap Saved to \"generatedImage.bmp\"");
            Console.WriteLine("Press Enter to exit to Main Menu");
            Console.ReadLine();
        }
    }
}
