using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JSRCustomGraffitiManager
{
    public partial class Form1 : Form
    {
        enum GraffitiSize {Small = 1, Large = 2, ExtraLarge = 4};

        string jsrSavePath;
        List<string> files;

        byte[] headerByteArray;

        public Form1()
        {
            InitializeComponent();

            string headerStr = "0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 5 0 0 0 89 79 85 82 83 38 0 0 0 84 104 105 115 32 105 115 32 116 104 101 32 103 114 97 102 102 105 116 105 32 116 104 97 116 32 121 111 117 32 99 114 101 97 116 101 100 46 0 128 0 0";
            string[] headerStrArray = headerStr.Split(' ');

            headerByteArray = new byte[headerStrArray.Length];

            for (int i = 0; i < headerStrArray.Length; ++i)
            {
                headerByteArray[i] = byte.Parse(headerStrArray[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadConfig();
            OpenJSRSavePath(jsrSavePath);
        }

        private void buttonOpenJSRSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialogEx folderDialog = new FolderBrowserDialogEx();
            folderDialog.Description = "Select the JSR User Data Folder:";
            folderDialog.ShowNewFolderButton = false;
            folderDialog.ShowEditBox = true;
            folderDialog.ShowFullPathInEditBox = true;
            folderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                OpenJSRSavePath(folderDialog.SelectedPath);
                SaveConfig();
            }
        }

        private void OpenJSRSavePath(string path)
        {
            jsrSavePath = path;
            if (SetupSaveSlots())
            {
                PopulateList();
            }
        }

        private void SaveConfig()
        {
            try
            {
                FileStream fs = new FileStream("config.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(jsrSavePath);
                sw.Close();
                fs.Close();
            }
            catch
            {
            }
        }

        private void LoadConfig()
        {
            try
            {
                FileStream fs = new FileStream("config.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                jsrSavePath = sr.ReadLine();
                sr.Close();
                fs.Close();
            }
            catch
            {
            }
        }

        private bool SetupSaveSlots()
        {
            comboBoxSaveSlots.Enabled = false;
            textBoxSaveFolder.Text = jsrSavePath;

            try
            {
                //Find all of the save slot directories
                string[] savePaths = Directory.GetDirectories(Path.Combine(jsrSavePath, "remote\\save\\"));       

                //We need save slots to edit graffiti, tell users to go create a save file first
                if (savePaths.Length <= 0)
                {
                    MessageBox.Show("There are no saved games yet. Go play the game and create a save first!");
                    return false;
                }

                comboBoxSaveSlots.Enabled = true;

                foreach (string s in savePaths)
                {
                    comboBoxSaveSlots.Items.Add(s.Substring(Path.Combine(jsrSavePath, "remote\\save\\").Length));
                }

                comboBoxSaveSlots.SelectedIndex = 0;

            }
            catch
            {
            }

            return true;
        }

        private void PopulateList()
        {
            pictureBoxS.Image  = null;
            pictureBoxL.Image  = null;
            pictureBoxXL.Image = null;

            labelNoGraffitiWarningL.Visible = false;
            labelNoGraffitiWarningS.Visible = false;
            labelNoGraffitiWarningXL.Visible = false;

            buttonReplaceS.Enabled  = false;
            buttonReplaceL.Enabled  = false;
            buttonReplaceXL.Enabled = false;

            try
            {
                string[] filePaths = Directory.GetFiles(Path.Combine(jsrSavePath, "remote\\save\\" + (string)comboBoxSaveSlots.SelectedItem));
                files = new List<string>();

                List<string> tagNames = new List<string>();
                tagNames.Add("jetset___sma");
                tagNames.Add("jetset___lar");
                tagNames.Add("jetset___xla");

                foreach (string s in filePaths)
                {
                    string fileName = Path.GetFileName(s);

                    if (fileName == "jetset___lar" || fileName == "jetset___sma" || fileName == "jetset___xla")
                    {
                        DisplayGraffiti(s);
                        tagNames.Remove(fileName);

                        if (fileName == "jetset___sma")
                        {
                            buttonReplaceS.Enabled = true;
                        }
                        else if (fileName == "jetset___lar")
                        {
                            buttonReplaceL.Enabled = true;
                        }
                        else if (fileName == "jetset___xla")
                        {
                            buttonReplaceXL.Enabled = true;
                        }
                    }
                }

                foreach (string s in tagNames)
                {
                    if (s == "jetset___sma")
                    {
                        labelNoGraffitiWarningS.Visible = true;
                    }
                    else if (s == "jetset___lar")
                    {
                        labelNoGraffitiWarningL.Visible = true;
                    }
                    else if (s == "jetset___xla")
                    {
                        labelNoGraffitiWarningXL.Visible = true;
                    }
                }
            }
            catch
            {
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImportGraffiti(openFileDialog1.FileName);
                PopulateList();
            }
        }

        private void ImportGraffiti(string path)
        {
            Image image;
            Bitmap bmp;

            try
            {
                image = Bitmap.FromFile(path);
                bmp = new Bitmap(image);
            }
            catch
            {
                MessageBox.Show("Could not read image.");
                return;
            }

            int width  = bmp.Width;
            int height = bmp.Height;

            if (height != 128 || (width != 128 && width != 256 & width != 512))
            {
                MessageBox.Show("Source image is " + width + "x" + height + ", but needs to be 128x128, 256x128, or 512x128.");
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

            string fileName = "";

            if (width == 128)
            {
                fileName = "jetset___sma";
            }
            else if (width == 256)
            {
                fileName = "jetset___lar";
            }
            else if (width == 512)
            {
                fileName = "jetset___xla";
            }

            string outputPath = Path.Combine(Path.Combine(jsrSavePath, "remote\\save\\" + (string)comboBoxSaveSlots.SelectedItem), fileName);

            if (File.Exists(outputPath))
            {
                if (MessageBox.Show("Overwrite " + outputPath + "?", "", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    return;
                }

                /*int i = 0;

                while (File.Exists(Path.Combine(Path.Combine(jsrSavePath, "remote\\save\\0"), fileName + i)))
                {
                    i++;
                }

                outputPath = Path.Combine(Path.Combine(jsrSavePath, "remote\\save\\0"), fileName + i);*/
            }

            FileStream fs = null;

            try
            {
                fs = new FileStream(outputPath, FileMode.Create);

                WriteHeader(fs);

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

                if (width == 128)
                {
                    while (fs.Position < smallFileSize)
                    {
                        fs.WriteByte(0);
                    }
                }
                else if (width == 256)
                {
                    while (fs.Position < largeFileSize)
                    {
                        fs.WriteByte(0);
                    }
                }
                else if (width == 512)
                {
                    while (fs.Position < xLargeFileSize)
                    {
                        fs.WriteByte(0);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error writing file. \n" + e.ToString());
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }

        private void WriteHeader(FileStream fs)
        {
            for (int i = 0; i < headerByteArray.Length; ++i)
            {
                fs.WriteByte(headerByteArray[i]);
            }
        }

        const int smallFileSize  = 34304;
        const int largeFileSize  = 67072;
        const int xLargeFileSize = 132608;

        private void DisplayGraffiti(string path)
        {
            FileStream fs = File.Open(path, FileMode.Open);

            GraffitiSize graffitiSize;

            if (fs.Length == smallFileSize)
            {
                graffitiSize = GraffitiSize.Small;
            }
            else if (fs.Length == largeFileSize)
            {
                graffitiSize = GraffitiSize.Large;
            }
            else if (fs.Length == xLargeFileSize)
            {
                graffitiSize = GraffitiSize.ExtraLarge;
            }
            else
            {
                //This isn't a graffiti file!
                return;
            }

            int imageWidth = 128 * (int)graffitiSize;
            
            //Read past the header
            while (fs.Position < 695)//1536)
            {
                fs.ReadByte();
            }

            //Read in the graffiti into an image
            Bitmap bmp = new Bitmap(imageWidth, 128);

            int i = 0;
            while (fs.Position < fs.Length && i < imageWidth * 128)
            {
                Color pixelColor;
                int r, g, b, a;
                int curByte1 = fs.ReadByte();
                int curByte2 = fs.ReadByte();

                g = (curByte1 >> 4) * 16;
                b = ((byte)(curByte1 << 4) >> 4) * 16;

                a = (curByte2 >> 4) * 16;
                r = ((byte)(curByte2 << 4) >> 4) * 16;

                pixelColor = Color.FromArgb(a, r, g, b);

                bmp.SetPixel(i % imageWidth, i / imageWidth, pixelColor);

                i++;
            }

            if (graffitiSize == GraffitiSize.Small)
            {
                pictureBoxS.Image = (Image)bmp;
            }
            else if (graffitiSize == GraffitiSize.Large)
            {
                pictureBoxL.Image = (Image)bmp;
            }
            else if (graffitiSize == GraffitiSize.ExtraLarge)
            {
                pictureBoxXL.Image = (Image)bmp;
            }

            fs.Close();
        }

        private void AttemptOpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ImportGraffiti(openFileDialog1.FileName);
                PopulateList();
            }
        }

        private void buttonReplaceS_Click(object sender, EventArgs e)
        {
            AttemptOpenFile();
        }

        private void buttonReplaceXL_Click(object sender, EventArgs e)
        {
            AttemptOpenFile();
        }

        private void buttonReplaceL_Click(object sender, EventArgs e)
        {
            AttemptOpenFile();
        }

        private void comboBoxSaveSlots_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            buttonHelp.Visible = false;
            labelProTip1.Visible = true;
            labelProTip2.Visible = true;
            labelProTip3.Visible = true;
        }
    }
}
