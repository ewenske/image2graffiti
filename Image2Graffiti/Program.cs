using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking for image file.");

            if (args.Length == 0)
            {
                Console.WriteLine("Error: Please drag an image onto the exe file.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            string path          = args[0];
            string directoryName = Path.GetDirectoryName(path);
            string fileName      = Path.GetFileNameWithoutExtension(path);

            Image image;
            Bitmap bmp;

            Console.WriteLine("Attempting to load image into internal bitmap.");

            try
            {
                image = Bitmap.FromFile(path);

                bmp = new Bitmap(image);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Could not read image format.");           
                Console.WriteLine(e.ToString());
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            int width  = bmp.Width;
            int height = bmp.Height;

            Console.WriteLine("Checking bitmap dimensions.");

            if (height != 128 || (width != 128 && width != 256 & width != 512))
            {
                Console.WriteLine("Error: Source image is " + width + "x" + height + ", but needs to be 128x128, 256x128, or 512x128.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }

            Color[,] pixelColors = new Color[width, height];

            for (int y = 0; y < height; ++y)
            {
                for (int x = 0; x < width; ++x)
                {
                    pixelColors[x, y] = bmp.GetPixel(x, y);
                }
            }

            string outputPath = Path.Combine(directoryName, "output_" + fileName + ".bin");

            try
            {
                Console.WriteLine("Converting and saving to: " + outputPath);

                FileStream fs = new FileStream(outputPath, FileMode.Create);

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        byte r = pixelColors[x, y].R;
                        byte g = pixelColors[x, y].G;
                        byte b = pixelColors[x, y].B;
                        byte a = pixelColors[x, y].A;

                        int int1 = ((g / 16) << 4) + (b / 16);
                        int int2 = ((a / 16) << 4) + (r / 16);

                        fs.WriteByte((byte)int1);
                        fs.WriteByte((byte)int2);
                    }
                }

                fs.Close();

                Console.WriteLine("SUCCESS!!! Bin file was outputted at: " + outputPath);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Wrror writing file");
                Console.WriteLine(e.ToString());
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                return;
            }
        }
    }
}
