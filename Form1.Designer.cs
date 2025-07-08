namespace DangNhap
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Load = new Button();
            pictureBox1 = new PictureBox();
            btn_Select = new Button();
            btn_Crop = new Button();
            pictureBox2 = new PictureBox();
            btn_Bilateral = new Button();
            btn_Sharp = new Button();
            btn_Blur = new Button();
            btn_Save = new Button();
            btn_Set = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_Load
            // 
            btn_Load.BackColor = SystemColors.ScrollBar;
            btn_Load.BackgroundImage = Properties.Resources.image1;
            btn_Load.Cursor = Cursors.Hand;
            btn_Load.Location = new Point(34, 27);
            btn_Load.Margin = new Padding(4, 2, 4, 2);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(118, 52);
            btn_Load.TabIndex = 0;
            btn_Load.Text = "Load Image";
            btn_Load.UseVisualStyleBackColor = false;
            btn_Load.Click += btn_Load_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 99);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(548, 413);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint_1;
            pictureBox1.MouseDown += pictureBox1_MouseDown_1;
            pictureBox1.MouseMove += pictureBox1_MouseMove_1;
            // 
            // btn_Select
            // 
            btn_Select.BackColor = SystemColors.ScrollBar;
            btn_Select.BackgroundImage = Properties.Resources.image1;
            btn_Select.Cursor = Cursors.Hand;
            btn_Select.Location = new Point(612, 99);
            btn_Select.Margin = new Padding(4, 2, 4, 2);
            btn_Select.Name = "btn_Select";
            btn_Select.Size = new Size(118, 44);
            btn_Select.TabIndex = 2;
            btn_Select.Text = "Make Selection";
            btn_Select.UseVisualStyleBackColor = false;
            btn_Select.Click += btn_Select_Click;
            // 
            // btn_Crop
            // 
            btn_Crop.BackColor = SystemColors.MenuHighlight;
            btn_Crop.BackgroundImage = Properties.Resources.image1;
            btn_Crop.Cursor = Cursors.Hand;
            btn_Crop.Location = new Point(612, 147);
            btn_Crop.Margin = new Padding(4, 2, 4, 2);
            btn_Crop.Name = "btn_Crop";
            btn_Crop.Size = new Size(118, 42);
            btn_Crop.TabIndex = 3;
            btn_Crop.Text = "Crop Selection";
            btn_Crop.UseVisualStyleBackColor = false;
            btn_Crop.Click += btn_Crop_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(758, 99);
            pictureBox2.Margin = new Padding(4, 2, 4, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(571, 413);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // btn_Bilateral
            // 
            btn_Bilateral.BackgroundImage = Properties.Resources.image1;
            btn_Bilateral.Cursor = Cursors.Hand;
            btn_Bilateral.Location = new Point(611, 387);
            btn_Bilateral.Name = "btn_Bilateral";
            btn_Bilateral.Size = new Size(118, 45);
            btn_Bilateral.TabIndex = 5;
            btn_Bilateral.Text = "Bilateral";
            btn_Bilateral.UseVisualStyleBackColor = true;
            btn_Bilateral.Click += btn_Bilateral_Click;
            // 
            // btn_Sharp
            // 
            btn_Sharp.BackgroundImage = Properties.Resources.image1;
            btn_Sharp.Cursor = Cursors.Hand;
            btn_Sharp.Location = new Point(612, 469);
            btn_Sharp.Name = "btn_Sharp";
            btn_Sharp.Size = new Size(117, 43);
            btn_Sharp.TabIndex = 6;
            btn_Sharp.Text = "Sharpen";
            btn_Sharp.UseVisualStyleBackColor = true;
            btn_Sharp.Click += btn_Sharp_Click;
            // 
            // btn_Blur
            // 
            btn_Blur.BackgroundImage = Properties.Resources.image1;
            btn_Blur.Cursor = Cursors.Hand;
            btn_Blur.Location = new Point(611, 339);
            btn_Blur.Name = "btn_Blur";
            btn_Blur.Size = new Size(118, 42);
            btn_Blur.TabIndex = 7;
            btn_Blur.Text = "Median Blur";
            btn_Blur.UseVisualStyleBackColor = true;
            btn_Blur.Click += btn_Blur_Click;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = SystemColors.MenuHighlight;
            btn_Save.Cursor = Cursors.Hand;
            btn_Save.ForeColor = SystemColors.ButtonHighlight;
            btn_Save.Location = new Point(1212, 27);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(117, 39);
            btn_Save.TabIndex = 8;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Set
            // 
            btn_Set.BackgroundImage = Properties.Resources.image1;
            btn_Set.Cursor = Cursors.Hand;
            btn_Set.Location = new Point(612, 234);
            btn_Set.Name = "btn_Set";
            btn_Set.Size = new Size(117, 40);
            btn_Set.TabIndex = 9;
            btn_Set.Text = "Set Image";
            btn_Set.UseVisualStyleBackColor = true;
            btn_Set.Click += btn_Set_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1382, 553);
            Controls.Add(btn_Set);
            Controls.Add(btn_Save);
            Controls.Add(btn_Blur);
            Controls.Add(btn_Sharp);
            Controls.Add(btn_Bilateral);
            Controls.Add(pictureBox2);
            Controls.Add(btn_Crop);
            Controls.Add(btn_Select);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Load);
            Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Padding = new Padding(1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Image Editor";
            TransparencyKey = Color.Pink;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Load;
        private PictureBox pictureBox1;
        private Button btn_Select;
        private Button btn_Crop;
        private PictureBox pictureBox2;
        private Button btn_Bilateral;
        private Button btn_Sharp;
        private Button btn_Blur;
        private Button btn_Save;
        private Button btn_Set;
    }
}