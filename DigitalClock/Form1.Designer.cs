namespace DigitalClock
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
            components = new System.ComponentModel.Container();
            lblTime = new Label();
            lblSecond = new Label();
            lblDate = new Label();
            lblDay = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.BorderStyle = BorderStyle.Fixed3D;
            lblTime.Font = new Font("DS-Digital", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(234, 17);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(323, 120);
            lblTime.TabIndex = 0;
            lblTime.Text = "22:22";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.BackColor = Color.Transparent;
            lblSecond.BorderStyle = BorderStyle.Fixed3D;
            lblSecond.Font = new Font("SF Digital Readout", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSecond.ForeColor = Color.White;
            lblSecond.Location = new Point(554, 77);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(56, 48);
            lblSecond.TabIndex = 1;
            lblSecond.Text = "22";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.BorderStyle = BorderStyle.Fixed3D;
            lblDate.Font = new Font("SF Digital Readout", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(12, 158);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(247, 59);
            lblDate.TabIndex = 2;
            lblDate.Text = "27 10 2023";
            lblDate.Click += lblDate_Click;
            // 
            // lblDay
            // 
            lblDay.AutoSize = true;
            lblDay.BackColor = Color.Transparent;
            lblDay.BorderStyle = BorderStyle.Fixed3D;
            lblDay.Font = new Font("SF Digital Readout", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(538, 158);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(225, 59);
            lblDay.TabIndex = 3;
            lblDay.Text = "Cumartesi";
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(775, 285);
            Controls.Add(lblDay);
            Controls.Add(lblDate);
            Controls.Add(lblTime);
            Controls.Add(lblSecond);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Label lblSecond;
        private Label lblDate;
        private Label lblDay;
        private System.Windows.Forms.Timer timer;
    }
}