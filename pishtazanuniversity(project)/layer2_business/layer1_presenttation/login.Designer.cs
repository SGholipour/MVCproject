namespace layer1_presenttation
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vistaClock1 = new VistaClockPersian.Controls.VistaClock();
            this.persianMonthCalendar1 = new FreeControls.PersianMonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "موسسه آموزش عالی پیشتازان شیراز ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(593, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "ورود ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(500, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "انصراف ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(678, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = ":کلمه عبور ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(490, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(490, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(678, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = ":کد کاربری ";
            // 
            // vistaClock1
            // 
            this.vistaClock1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.vistaClock1.BackColor = System.Drawing.Color.Transparent;
            this.vistaClock1.Location = new System.Drawing.Point(8, 9);
            this.vistaClock1.MaximumSize = new System.Drawing.Size(132, 131);
            this.vistaClock1.MinimumSize = new System.Drawing.Size(132, 131);
            this.vistaClock1.Name = "vistaClock1";
            this.vistaClock1.SecondSpring = true;
            this.vistaClock1.ShowSecond = true;
            this.vistaClock1.Size = new System.Drawing.Size(132, 131);
            this.vistaClock1.Style = VistaClockPersian.Controls.VistaClock.VistaClockStyle.Flower;
            this.vistaClock1.TabIndex = 6;
            // 
            // persianMonthCalendar1
            // 
            this.persianMonthCalendar1.BackColor = System.Drawing.Color.White;
            this.persianMonthCalendar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.persianMonthCalendar1.Location = new System.Drawing.Point(146, 36);
            this.persianMonthCalendar1.MarkColor = System.Drawing.Color.Green;
            this.persianMonthCalendar1.MaximumSize = new System.Drawing.Size(325, 172);
            this.persianMonthCalendar1.MinimumSize = new System.Drawing.Size(325, 172);
            this.persianMonthCalendar1.Name = "persianMonthCalendar1";
            this.persianMonthCalendar1.ShowToday = true;
            this.persianMonthCalendar1.Size = new System.Drawing.Size(325, 172);
            this.persianMonthCalendar1.TabIndex = 8;
            this.persianMonthCalendar1.Text = "persianMonthCalendar1";
            this.persianMonthCalendar1.TitleBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.persianMonthCalendar1.TitleForeColor = System.Drawing.Color.White;
            this.persianMonthCalendar1.Value = ((FreeControls.PersianDate)(resources.GetObject("persianMonthCalendar1.Value")));
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(768, 240);
            this.Controls.Add(this.persianMonthCalendar1);
            this.Controls.Add(this.vistaClock1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "ورود به سیستم ";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private VistaClockPersian.Controls.VistaClock vistaClock1;
        private FreeControls.PersianMonthCalendar persianMonthCalendar1;
    }
}