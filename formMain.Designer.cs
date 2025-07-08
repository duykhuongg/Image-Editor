namespace DangNhap
{
    partial class formMain
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
            btnLoad = new Button();
            btnRun = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            cropTool = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(496, 95);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(151, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load\r\n";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(496, 285);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(151, 29);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run crop\r\n\r\n";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(45, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(687, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(400, 400);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // cropTool
            // 
            cropTool.Location = new Point(496, 250);
            cropTool.Name = "cropTool";
            cropTool.Size = new Size(151, 29);
            cropTool.TabIndex = 5;
            cropTool.Text = "Select area";
            cropTool.UseVisualStyleBackColor = true;
            cropTool.Click += cropTool_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(595, 349);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "Dimension\r\n";
            // 
            // formMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 524);
            Controls.Add(label1);
            Controls.Add(cropTool);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnRun);
            Controls.Add(btnLoad);
            Name = "formMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnRun;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button cropTool;
        private Label label1;
    }
}