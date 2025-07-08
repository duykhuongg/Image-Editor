using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using OpenCvSharp.Extensions;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Imaging;
using System.Security.Cryptography;

namespace DangNhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Mot so tham so duoc su dung
        private const double V = 0.1;
        float s = 100; float r = (float)V;


        Mat img = new Mat();//khoi tao input
        Mat imgOutput = new Mat();//khoi tao output

        Mat imgOutput1 = new Mat();

        Rect cropRect = new Rect();//Khoi tao rectangle de ve

        Mat setImage = new Mat();//Tao bien trung gian de set anh

        System.Drawing.Point startPoint = new System.Drawing.Point(); //diem bat dau va hinh chu nhat de hien thi vung chon
        System.Drawing.Rectangle rect = new System.Drawing.Rectangle();

        bool isDraw = false;//bool xac nhan san sang de ve

        //Load picture
        private void btn_Load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            img = Cv2.ImRead(openFileDialog.FileName);
            Cv2.Resize(img, img, new OpenCvSharp.Size(pictureBox1.Width, pictureBox1.Height));
            this.pictureBox1.Image = img.ToBitmap();
        }

        //Select region, using bool Draw and Cross Cursor to recognise when we can draw the region
        private void btn_Select_Click(object sender, EventArgs e)
        {
            if (!isDraw)
            {
                Cursor = Cursors.Cross;
                isDraw = true;
            }
            else
            {
                Cursor = Cursors.Default;
                isDraw = false;
            }
        }

        //Mouse click down, set the location of mouse click
        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (isDraw && e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;//danh dau diem bat dau
                pictureBox1.Invalidate();
            }
        }

        //Mousemove, consider every situation, left to right, right to left
        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (isDraw && e.Button == MouseButtons.Left)
            {

                if (e.X > startPoint.X && e.Y > startPoint.Y)
                {
                    rect.X = startPoint.X;
                    rect.Y = startPoint.Y;
                    rect.Width = e.X - startPoint.X;
                    rect.Height = e.Y - startPoint.Y;
                    cropRect.X = rect.X; cropRect.Y = rect.Y;
                    cropRect.Width = rect.Width; cropRect.Height = rect.Height;
                }
                else if (e.X < startPoint.X && e.Y > startPoint.Y)
                {
                    rect.X = e.X;
                    rect.Y = startPoint.Y;
                    rect.Width = 0 - (e.X - startPoint.X);
                    rect.Height = e.Y - startPoint.Y;
                    cropRect.X = rect.X; cropRect.Y = rect.Y;
                    cropRect.Width = rect.Width; cropRect.Height = rect.Height;
                }
                else if (e.X > startPoint.X && e.Y < startPoint.Y)
                {
                    rect.X = startPoint.X;
                    rect.Y = e.Y;
                    rect.Width = e.X - startPoint.X;
                    rect.Height = 0 - (e.Y - startPoint.Y);
                    cropRect.X = rect.X; cropRect.Y = rect.Y;
                    cropRect.Width = rect.Width; cropRect.Height = rect.Height;
                }
                else
                {
                    rect.X = e.X;
                    rect.Y = e.Y;
                    rect.Width = e.X - startPoint.X;
                    rect.Height = e.Y - startPoint.Y;
                    cropRect.X = rect.X; cropRect.Y = rect.Y;
                    cropRect.Width = rect.Width; cropRect.Height = rect.Height;
                }


                pictureBox1.Refresh();
            }

        }

        //Draw the rectangle region on image
        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = 1;
            e.Graphics.DrawRectangle(pen, rect);
        }

        //Crop image
        private void btn_Crop_Click(object sender, EventArgs e)
        {
            imgOutput = new Mat(img, cropRect);
            //Cv2.ImShow("output", imgOutput);
            this.pictureBox2.Image = imgOutput.ToBitmap();
            setImage = imgOutput.Clone();
        }

        //Apply bilateral filter
        private void btn_Bilateral_Click(object sender, EventArgs e)
        {
           Cv2.BilateralFilter(img, imgOutput, 15, 80, 80,0);
         
            this.pictureBox2.Image = imgOutput.ToBitmap();
            setImage = imgOutput.Clone();
        }
        //Detail enhance
        private void btn_Sharp_Click(object sender, EventArgs e)
        {
            Cv2.DetailEnhance(img, imgOutput, s, r);
            this.pictureBox2.Image = imgOutput.ToBitmap();
            setImage = imgOutput.Clone();
        }

        //Blur using Medianblur
        private void btn_Blur_Click(object sender, EventArgs e)
        {
            Cv2.MedianBlur(img, imgOutput, 3);
            this.pictureBox2.Image = imgOutput.ToBitmap();
            setImage = imgOutput.Clone();
        }

        //Set edited image as new to do multiple processing
        private void btn_Set_Click(object sender, EventArgs e)
        {

            this.pictureBox1.Image = setImage.ToBitmap();
            img = setImage.Clone();
            Cv2.Resize(img, img, new OpenCvSharp.Size(pictureBox1.Width, pictureBox1.Height));
            pictureBox2.Image = null;
        }

        //Save processed image
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBox2.Image.Save(sfd.FileName, format);
            }
        }
    }

}
