namespace DrawingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 501);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(804, 460);
            button1.Name = "button1";
            button1.Size = new Size(98, 31);
            button1.TabIndex = 1;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(590, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(316, 35);
            panel2.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Khaki;
            pictureBox7.BorderStyle = BorderStyle.FixedSingle;
            pictureBox7.Location = new Point(270, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(37, 29);
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox1_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Red;
            pictureBox6.BorderStyle = BorderStyle.FixedSingle;
            pictureBox6.Location = new Point(227, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 29);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.HotPink;
            pictureBox5.BorderStyle = BorderStyle.FixedSingle;
            pictureBox5.Location = new Point(184, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 29);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.SlateBlue;
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(141, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(37, 29);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.MediumSeaGreen;
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(98, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 29);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.LightSeaGreen;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(55, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 29);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.MenuHighlight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 29);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 501);
            Controls.Add(panel1);
            Cursor = Cursors.Cross;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}