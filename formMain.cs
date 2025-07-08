using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenTK.Graphics.OpenGL;


namespace DangNhap
{
    public partial class formMain : Form
    {




        public formMain()
        {
            InitializeComponent();
        }

        Mat img;
        Mat imgOutput;
        System.Drawing.Point startPoint = new System.Drawing.Point();
        System.Drawing.Rectangle rect = new System.Drawing.Rectangle();
        bool isDraw = false;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            img = Cv2.ImRead(openFileDialog.FileName, 0);

            this.pictureBox1.Image = img.ToBitmap();

        }

        //cropbutton


        //Select area button
        private void cropTool_Click(object sender, EventArgs e)
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
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            

            if (isDraw && e.Button == MouseButtons.Left)
            {
               
                startPoint = e.Location;//danh dau diem bat dau

            }
        }
       

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isDraw && e.Button == MouseButtons.Left)
            {
               
                if (e.X > startPoint.X && e.Y > startPoint.Y)
                {
                    rect.X = startPoint.X;
                    rect.Y = startPoint.Y;
                    rect.Width = e.X - startPoint.X;
                    rect.Height = e.Y - startPoint.Y;
                }
                else if (e.X < startPoint.X && e.Y > startPoint.Y)
                {
                    rect.X = e.X;
                    rect.Y = startPoint.Y;
                    rect.Width = 0 - (e.X - startPoint.X);
                    rect.Height = e.Y - startPoint.Y;
                }
                else if (e.X > startPoint.X && e.Y < startPoint.Y)
                {
                    rect.X = startPoint.X;
                    rect.Y = e.Y;
                    rect.Width = e.X - startPoint.X;
                    rect.Height = 0 - (e.Y - startPoint.Y);
                }
                else
                {
                    rect.X = e.X;
                    rect.Y = e.Y;
                    rect.Width = e.X - startPoint.X;
                    rect.Height = e.Y - startPoint.Y;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.White);
            pen.Width = 2;
            e.Graphics.DrawRectangle(pen, rect);
        }

       
        private void btnRun_Click(object sender, EventArgs e)
        {

          

        }

        private void cropTool_Click_1(object sender, EventArgs e)
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
    }
}

