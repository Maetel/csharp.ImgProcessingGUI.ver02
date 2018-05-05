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

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        
        const string rotatedDir = "\\rotated";
        const int exifOrientationID = 0x112;
        System.Drawing.Imaging.PropertyItem g_ImgInfo = null;

        List<string> imgFiles = new List<string>();
        List<string> imgFilesConverted = new List<string>();
        List<string> convertedPaths = new LisWt<string>();

        string filepath = "";
        string savedPath = "";
        bool isDropped = false;
        bool isDefImgDropped = false;
        bool isTitleEdited = false;
        int g_lang = 1;


        public MainWindow()
        {
            InitializeComponent();
            resetLanguage();
            //files.AddFirst(new string[] { "" });
            
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            if (!isDropped)
            { 
                MessageBox.Show(g_lang == 0 ? "Please drag files first" : "변환될 이미지를 입력해주세요");
                return;
            }
            else if (this.chkMergePDF.Checked && this.etxtPDFTitle.Text.Equals(""))
            {
                MessageBox.Show(g_lang == 0 ? "Please input the pdf title" : "PDF 제목을 입력해주세요");
                return;
            }

            this.lblStatus.Text = g_lang == 0 ? "Converting..." : "변환 중...";
            this.Display.Enabled = false;

            int m_idx = 0;

            foreach ( string fileImg in imgFiles)
            {
                int m_pos = imgFiles[m_idx].LastIndexOf('\\');
                filepath = imgFiles[m_idx++].Substring(0, m_pos);
                //MessageBox.Show(m_idx + " " + filepath);
                savedPath = filepath + rotatedDir + '\\';



                System.IO.Directory.CreateDirectory(savedPath);

                string m_filename = "";
                for (int ii = fileImg.LastIndexOf('\\') + 1; ii < fileImg.Length - 4; ii++)
                {
                    m_filename += fileImg[ii];
                }

                //this.lblStatus.Text = "Converting " + m_filename;

                //by giving 'true' as the second parameter, i gain the 'use embedded color management' option, 180503
                Bitmap i = System.Drawing.Image.FromFile(fileImg, true) as Bitmap;
                //Bitmap i = System.Drawing.Image.FromFile(fileImg) as Bitmap;
                var dpiX = i.HorizontalResolution;
                var dpiY = i.VerticalResolution;
                int iW = i.Width;
                int iH = i.Height;
                
                

                bool isHorizontal = true;
                bool shouldRotate = false;

                if( this.chkVertical.Checked)
                {
                    isHorizontal = false;
                }

                if ( isHorizontal )
                {
                    if( iH > iW)
                    {
                        shouldRotate = true;
                    }
                }


                if (!shouldRotate)
                {
                    File.Copy(fileImg, savedPath + m_filename + "_rotated.jpg");
                    
                }
                else
                {
                    i.SetPropertyItem(g_ImgInfo);
                    i.Save(savedPath + m_filename + "_rotated.jpg");
                }

                #region ver0.1

                //var temp = new Bitmap(iW, iH, System.Drawing.Imaging.PixelFormat.Format48bppRgb);

                //temp.SetResolution(dpiX, dpiY);

                ////MBDN code, 'GetEncoder' is a custom declared method
                //System.Drawing.Imaging.ImageCodecInfo jpgEncoder = this.GetEncoder(System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                //System.Drawing.Imaging.EncoderParameters myEncoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
                //System.Drawing.Imaging.EncoderParameter myEncoderParameter = new System.Drawing.Imaging.EncoderParameter(myEncoder, (long)dpiX);
                //myEncoderParameters.Param[0] = myEncoderParameter;

                //string rPath = savedPath + m_filename + "_rotated.jpg";
                //convertedPaths.Add(rPath);


                //using (var gr = Graphics.FromImage(temp))
                //{
                //    gr.Clear(Color.Transparent);
                //    /*
                //    if (shouldRotate)
                //    {
                //        gr.TranslateTransform((float)temp.Width / 2, (float)temp.Height / 2);
                //        gr.RotateTransform(90);
                //        gr.TranslateTransform(-(float)temp.Width / 2, -(float)temp.Height / 2);
                //    }
                //    */
                //    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                //    gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                //    gr.DrawImage(i, new Point(0, 0));

                //    gr.Dispose();
                //}

                //if (shouldRotate) { temp.RotateFlip(RotateFlipType.Rotate90FlipNone); }

                //temp.Save(rPath, jpgEncoder, myEncoderParameters);
                //temp.Dispose();
                //System.GC.Collect();
                //System.GC.WaitForPendingFinalizers();

                #endregion


                i.Dispose();
            }

            string finishedMsg = g_lang == 0? "Image cut successfully" : "이미지가 회전되었습니다.";

            if (this.chkMergePDF.Checked)
            {
                toPDF();
                finishedMsg = g_lang == 0 ? "Image cut & PDF merged successfully" : "이미지 분할과 PDF병합에 성공하였습니다.";
            }

            //not supported yet in ver0.23
            /*
            if ( ! this.chkCreateImages.Checked)
            {
                try
                {
                    System.GC.Collect();
                    foreach (string img in convertedPaths)
                    {
                        File.Delete(img);
                    }
                    finishedMsg += " & Image Deleted";
                }
                catch(IOException ee)
                {
                    MessageBox.Show((g_lang==0? "Not able to delete images. error code : " : "이미지를 지울 수 없었습니다. 에러 코드 :") + ee);
                }
            }
            */

            

            MessageBox.Show(finishedMsg);

            this.setLog();
            this.initDisplay();

        }

        private void Initialize_Click(object sender, EventArgs e)
        {
            this.initDisplay();
        }

        private void initDisplay()
        {
            isDropped = false;
            isTitleEdited = false;
            this.Display.Text = "";
            this.chkMergePDF.Checked = true;
            this.etxtPDFTitle.Text = "";
            imgFiles.Clear();
            imgFilesConverted.Clear();
            convertedPaths.Clear();
            this.Display.Enabled = true;
            System.Drawing.Imaging.PropertyItem g_ImgInfo = null;
            isDefImgDropped = false;
            resetLanguage();
        }

        private void toPDF()
        {
            //not to be done

            //180503-1 first try

            this.lblStatus.Text = g_lang==0? "Merging into a PDF file..." : "PDF파일 병합 중...";

            string pdfPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MergedPDF\\";
            System.IO.Directory.CreateDirectory(pdfPath);

            string getTitle = this.etxtPDFTitle.Text;

            if( !(getTitle.Contains(".pdf") || getTitle.Contains(".PDF") ) )
            {
                getTitle += ".pdf";
            }
            pdfPath += getTitle;

            Document document = new Document();
            bool isNewPage = true;
            using (var stream = new FileStream(pdfPath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                PdfWriter.GetInstance(document, stream);
                
                foreach ( string img in convertedPaths)
                {
                    iTextSharp.text.Rectangle rect = new iTextSharp.text.Rectangle((float)System.Drawing.Image.FromFile(img).Size.Width, (float)System.Drawing.Image.FromFile(img).Size.Height);
                    document.SetPageSize(rect);

                    if (isNewPage)
                    {
                        isNewPage = false;
                        document.Open();
                    }
                    else
                    {
                        document.NewPage();
                    }
                    
                   
                    
                    using (var imageStream = new FileStream(img , FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    {

                        var pdfImage = iTextSharp.text.Image.GetInstance(imageStream);
                        pdfImage.SetAbsolutePosition(0, 0);
                        document.Add(pdfImage);
                    }
                }
                
                document.Close();
            }

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ( this.chkMergePDF.Checked)
            {
                this.etxtPDFTitle.Enabled = true;
            }
            else
            {
                this.etxtPDFTitle.Text = "";
                this.etxtPDFTitle.Enabled = false;
            }
        }

        private void btnClearTitle_Click(object sender, EventArgs e)
        {
            this.etxtPDFTitle.Text = "";
        }

        private void PDFTitle_TextChanged(object sender, EventArgs e)
        {
            this.isTitleEdited = true;
        }

        private void setLanguage(string _getLanguage)
        {
            
            
            if( _getLanguage.Equals("English"))
            {
                g_lang = 0;
            }
            else if (_getLanguage.Equals("한국어"))
            {
                g_lang = 1;
            }


            resetLanguage();
        }

        private void resetLanguage()
        {
            switch (g_lang)
            {
                //English
                case 0:
                    this.lblFileList.Text = "File List";
                    this.lblStatus.Text = "Drag and drop images";
                    this.lblPDFTitle.Text = "PDF Title :";
                    this.btnClearTitle.Text = "Clear Title";
                    this.btnConvert.Text = "Convert";
                    this.btnInitialize.Text = "Initialize";
                    this.chkMergePDF.Text = "Merge PDF";
                    this.btnLanguage.Text = "한국어";
                    this.btnHelp.Text = "Help";
                    this.btnInfo.Text = "Info";
                    break;
                case 1:
                    this.lblFileList.Text = "파일 목록";
                    this.lblStatus.Text = "이미지를 끌어다 놓으세요";
                    this.lblPDFTitle.Text = "PDF 제목 :";
                    this.btnClearTitle.Text = "제목 지우기";
                    this.btnConvert.Text = "이미지 변환";
                    this.btnInitialize.Text = "초기화";
                    this.chkMergePDF.Text = "PDF 합치기";
                    this.btnLanguage.Text = "English";
                    this.btnHelp.Text = "사용 방법";
                    this.btnInfo.Text = "제작 정보";
                    break;

            }
        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            switch (g_lang)
            {
                case 0:
                    this.btnLanguage.Text = "한국어";
                    g_lang = 1;
                    resetLanguage();
                    break;
                case 1:
                    this.btnLanguage.Text = "English";
                    g_lang = 0;
                    resetLanguage();
                    break;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string m_help = "";

            switch ( g_lang)
            {
                case 0:
                    m_help =
                        " * Fuction : Cuts  multiple jpg files into two vertically\n" +
                        "\tkeeping the original images' resolution and dpi.\n" +
                        " - Also provides with the function that merges the converted\n" +
                        "\timage files into a PDF file keeping the above information.\n\n" +
                        " * Help\n" +
                        "1. Drag and drop images on the file list.\n" +
                        "2. Press the 'Convert' button.\n" +
                        " - In case the 'Merge PDF' button is checked :\n" +
                        "\tIt will create a folder 'MergedPDF' on ur desktop\n" +
                        " - In the other case, it will not.\n" +
                        "3. The converted images will be saved under the same path\n" +
                        "\tof your original images, 'converted' folder'.\n" +
                        "* The merged PDF file's title can be adjusted\n" +
                        "\tThe default title is the time converted.\n" +
                        "* The 'Initialize' button clears all to the default state.\n" +
                        "* The conversions of images and PDF files make a log under\n" +
                        "\tC:\\ImageConversion0.2";

                    break;
                case 1:
                    m_help = 
                        " * 기능 : jpg파일의 해상도와 dpi를 유지한 채로\n" +
                        "\t해상도 기준 수직 절반을 나누어 저장합니다.\n" +
                        " - 변환된 이미지의 순서와 정보를 유지하며\n" +
                        "\t한 개의 PDF파일로 병합 기능을 제공합니다.\n\n" +
                        " * 사용 방법 :\n" +
                        "1. 변환할 이미지를 끌어다 놓으세요.\n" +
                        "2. '변환' 버튼을 누르세요.\n" +
                        " - 'PDF 합치기'가 체크된 경우 :\n" +
                        "\t바탕화면에 'MergedPDF'폴더 생성 후\n" +
                        "\t그 안에 병합된 PDF파일을 생성합니다.\n" +
                        "3. 변환된 이미지는 이미지가 있는 폴더에\n" +
                        "\t'converted'라는 폴더 내부에 생성됩니다.\n" +
                        "* 병합된 PDF파일의 이름을 정할 수 있습니다.\n" +
                        "\t초기값은 병합된 시간입니다. (중복 방지)\n" +
                        "* 초기화 버튼은 모든 설정을 초기화합니다.\n" +
                        "* 변환된 파일 목록과 시간을 로그로 남깁니다.\n" +
                        "\t경로 : C:\\ImageConversion0.2";
                    break;
            }

            MessageBox.Show(m_help);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            string m_info = "";

            switch (g_lang)
            {
                case 0:
                    m_info = "Created by Wonjun Hwang, Seoul\n" +
                        "iamjam4944@gmail.com\n" +
                        "+82-10-2726-4944";

                    break;
                case 1:
                    m_info = "제작자 : 황원준\n" +
                        "iamjam4944@gmail.com\n" +
                        "010-2726-4944";
                    break;
            }

            MessageBox.Show(m_info);
        }

        private void chkHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            this.chkVertical.Checked = !this.chkHorizontal.Checked;
        }

        private void chkVertical_CheckedChanged(object sender, EventArgs e)
        {
            this.chkHorizontal.Checked = !this.chkVertical.Checked;
        }

        private void Display_DragDrop(object sender, DragEventArgs e)
        {
            isDropped = true;
            if (!this.isTitleEdited) this.etxtPDFTitle.Text = DateTime.Now.ToString().Replace(":", "-");

            string[] allFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int m_idx = 0;
            this.Display.Text = "";

            foreach (string tempF in allFiles)
            {
                if (tempF.Contains(".jpg") || tempF.Contains(".JPG"))
                {
                    imgFiles.Add(tempF);
                }
            }

            foreach (string filename in imgFiles)
            {
                this.Display.Text += ++m_idx + ". ";
                for (int ii = filename.LastIndexOf('\\') + 1; ii < filename.Length; ii++)
                {
                    this.Display.Text += filename[ii];
                }
                this.Display.Text += "\r\n";
            }
        }

        private void Display_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            //MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));

        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("textBox1 dropped!");
            string[] allFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string m_defImg = "";
            foreach ( string tempF in allFiles)
            {
                if (tempF.Contains(".jpg") || tempF.Contains(".JPG"))
                {
                    m_defImg = tempF;
                    MessageBox.Show("found a jpg file");
                    break;
                }
            }

            if( m_defImg.Equals(""))
            {
                MessageBox.Show("Please input an image that contains the orientation information");
                initDisplay();
                return;
            }

            Bitmap m_i = System.Drawing.Image.FromFile(m_defImg, true) as Bitmap;
            if (! m_i.PropertyIdList.Contains(exifOrientationID))
            {
                MessageBox.Show("Please input an image that contains the orientation information");
                initDisplay();
                return;
            }
            else
            {
                g_ImgInfo = m_i.GetPropertyItem(exifOrientationID);
                isDefImgDropped = true;
                MessageBox.Show("Default image orientation is set");
                //System.Drawing.Imaging.PropertyItem m_temp = m_i.GetPropertyItem(exifOrientationID);
            }
            
        }

        private void MainWindow_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            /*
            if (this.Display.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                
                Display_DragDrop(sender, e);
            }
            if (this.textDefaultImage.ClientRectangle.Contains(PointToClient(Control.MousePosition)))
            {
                MessageBox.Show("test");
                textBox1_DragDrop(sender, e);
            }
            */
        }
    }
}
