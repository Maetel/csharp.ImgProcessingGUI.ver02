using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        const string convertedDir = "\\converted";
        
        List<string> imgFiles = new List<string>();
        List<string> imgFilesConverted = new List<string>();

        string filepath = "";
        string savedPath = "";
        bool isDropped = false;

        public Form1()
        {
            InitializeComponent();
            //files.AddFirst(new string[] { "" });
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            isDropped = true;
            string[] allFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int m_idx = 0;
            this.Display.Text = "";

            foreach ( string tempF in allFiles)
            {
                if ( tempF.Contains(".jpg") || tempF.Contains(".JPG"))
                {
                    imgFiles.Add(tempF);
                }
            }
            
            foreach (string filename in imgFiles)
            {
                this.Display.Text += ++m_idx + ". ";
                for (int ii = filename.LastIndexOf('\\')+1 ; ii < filename.Length; ii++)
                {
                    this.Display.Text +=  filename[ii];
                }
                this.Display.Text += "\r\n";
            }

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if ( !isDropped )
            {
                MessageBox.Show("Please drag files.");
                return;
            }

            this.Status.Text = "Converting...";

            int m_idx = 0;

            foreach ( string fileImg in imgFiles)
            {
                int m_pos = imgFiles[m_idx].LastIndexOf('\\');
                filepath = imgFiles[m_idx++].Substring(0, m_pos);
                //MessageBox.Show(m_idx + " " + filepath);
                savedPath = filepath + convertedDir + '\\';
                System.IO.Directory.CreateDirectory(savedPath);

                string m_filename = "";
                for (int ii = fileImg.LastIndexOf('\\') + 1; ii < fileImg.Length - 4; ii++)
                {
                    m_filename += fileImg[ii];
                }

                Bitmap i = Image.FromFile(fileImg) as Bitmap;
                var dpiX = i.HorizontalResolution;
                var dpiY = i.VerticalResolution;
                int iW = i.Width;
                int iH = i.Height;

                

                var temp = new Bitmap(iW / 2, iH, i.PixelFormat);
                temp.SetResolution(dpiX, dpiY);

                //MBDN code, 'GetEncoder' is a custom declared method
                //Trying to solve the problem; images drawn by 'Graphics' not being able to be opened on the photoshop app
                System.Drawing.Imaging.ImageCodecInfo jpgEncoder = this.GetEncoder(System.Drawing.Imaging.ImageFormat.Jpeg);
                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                System.Drawing.Imaging.EncoderParameters myEncoderParameters = new System.Drawing.Imaging.EncoderParameters(1);

                //180503-01 adjusted by adding (long)dpiX for the parameter, while dpiX is the original horizontal resolution of the referred image file.
                System.Drawing.Imaging.EncoderParameter myEncoderParameter = new System.Drawing.Imaging.EncoderParameter(myEncoder, (long)dpiX);
                myEncoderParameters.Param[0] = myEncoderParameter;

                /*
                using (var gr = Graphics.FromImage(temp))
                {
                    gr.DrawImageUnscaled(i, 0, 0, iW, iH);
                }
                temp.Save(savedPath + m_filename + "_L.jpg", jpgEncoder, myEncoderParameters);
                */
                using (var gr = Graphics.FromImage(temp))
                {
                    gr.Clear(Color.Transparent);
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    gr.DrawImage(i, new Rectangle(0, 0, iW, iH));
                }
                temp.Save(savedPath + m_filename + "_L.jpg", jpgEncoder, myEncoderParameters);
                using (var gr = Graphics.FromImage(temp))
                {
                    gr.Clear(Color.Transparent);
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    gr.DrawImage(i, new Rectangle(0, 0, iW, iH), new Rectangle(iW / 2, 0, iW, iH), GraphicsUnit.Pixel);
                }
                temp.Save(savedPath + m_filename + "_R.jpg", jpgEncoder, myEncoderParameters);



                /*0502-01. succeeded in diving into two. failed to keep the original resolution
                Bitmap i = Image.FromFile(fileImg) as Bitmap;
                var dpiX = i.HorizontalResolution;
                var dpiY = i.VerticalResolution;
                MessageBox.Show(dpiX + "   " + dpiY);
                int iW = i.Width;
                int iH = i.Height;
                Rectangle cropRectL = new Rectangle(0, 0, iW / 2, iH);
                Rectangle cropRectR = new Rectangle(iW / 2, 0, iW / 2, iH);
                Bitmap target = new Bitmap(i);

                target.Clone(cropRectL, target.PixelFormat).Save(savedPath + m_filename + "_L.jpg");
                target.Clone(cropRectR, target.PixelFormat).Save(savedPath + m_filename + "_R.jpg");
                */

                /*0502-02. succeeded in diving into two, keeping the original resolution, but failed in having the files opened on photoshop
                Bitmap i = Image.FromFile(fileImg) as Bitmap;
                var dpiX = i.HorizontalResolution;
                var dpiY = i.VerticalResolution;

                int iW = i.Width;
                int iH = i.Height;

                var temp = new Bitmap(iW/2, iH, i.PixelFormat);
                temp.SetResolution(dpiX, dpiY);

                using ( var gr = Graphics.FromImage(temp))
                {
                    gr.Clear(Color.Transparent);
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    gr.DrawImage(i, new Rectangle(0, 0, iW, iH));
                }
                temp.Save(savedPath + m_filename + "_L.jpg");
                using (var gr = Graphics.FromImage(temp))
                {
                    gr.Clear(Color.Transparent);
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    gr.DrawImage(i, new Rectangle(0, 0, iW, iH), new Rectangle(iW/2, 0, iW, iH), GraphicsUnit.Pixel);
                }
                temp.Save(savedPath + m_filename + "_R.jpg");
                */


                /*  0501version
                Bitmap i = Image.FromFile(fileImg) as Bitmap;
                i.Save(savedPath + m_filename + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                Rectangle cropRectL = new Rectangle(0, 0, i.Width/2, i.Height);
                Rectangle cropRectR = new Rectangle(i.Width / 2, 0, i.Width / 2, i.Height);

                Bitmap newImageL = new Bitmap(cropRectL.Width, cropRectL.Height);
                Bitmap newImageR = new Bitmap(cropRectR.Width, cropRectR.Height);

                Graphics gL = Graphics.FromImage(newImageL);
                Graphics gR = Graphics.FromImage(newImageR);

                gL.DrawImage(i, cropRectL.X, cropRectL.Y);
                string fileL = savedPath + m_filename + "_L.jpg";
                newImageL.Save(fileL, System.Drawing.Imaging.ImageFormat.Jpeg);

                gR.DrawImage(i, cropRectL, cropRectR, GraphicsUnit.Pixel);
                string fileR = savedPath + m_filename + "_R.jpg";
                newImageR.Save(fileR, System.Drawing.Imaging.ImageFormat.Jpeg);

                imgFilesConverted.Add(fileL);
                imgFilesConverted.Add(fileR);

                gL.Dispose();
                gR.Dispose();
                i.Dispose();
                newImageL.Dispose();
                newImageR.Dispose();
                */

            }

            this.toPDF();

            MessageBox.Show("Conversion Finished");

            this.setLog();
            this.initDisplay();

            this.Status.Text = "Drag and drop images";
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Initialize_Click(object sender, EventArgs e)
        {
            this.initDisplay();
        }

        private void initDisplay()
        {
            isDropped = false;
            this.Display.Text = "";
            imgFiles.Clear();
            imgFilesConverted.Clear();
        }

        private void toPDF()
        {
           //not to be done
        }

        private void setLog()
        {
            //MessageBox.Show("set log");
            string filePath = "c:\\ImageConversion0.2\\";
            System.IO.Directory.CreateDirectory(filePath);
            DateTime localdate = DateTime.Now;
            string curTime = localdate.ToString().Replace(":", "-");
            string fileName = (filePath + curTime + ".txt");

            //MessageBox.Show(fileName);

            string data = curTime + "\r\n";

            foreach( string s in imgFiles)
            {
                data += s + "\r\n";
            }

            System.IO.File.WriteAllText(fileName, data);
        }

        private System.Drawing.Imaging.ImageCodecInfo GetEncoder(System.Drawing.Imaging.ImageFormat format)
        {
            System.Drawing.Imaging.ImageCodecInfo[] codecs = System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders();
            foreach (System.Drawing.Imaging.ImageCodecInfo codec in codecs)
            {
                if ( codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
