namespace Testing_Environ_Project
{
    partial class IMU_Display_Monitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IMU_Display_Monitor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accz = new System.Windows.Forms.TextBox();
            this.accy = new System.Windows.Forms.TextBox();
            this.accx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gysz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gysy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gysx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mgtz = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mgty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mgtx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.data_Setter = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.roll = new System.Windows.Forms.TextBox();
            this.yaw = new System.Windows.Forms.TextBox();
            this.pitch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accz);
            this.groupBox1.Controls.Add(this.accy);
            this.groupBox1.Controls.Add(this.accx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accelerometer ";
            // 
            // accz
            // 
            this.accz.Location = new System.Drawing.Point(39, 68);
            this.accz.Name = "accz";
            this.accz.ReadOnly = true;
            this.accz.Size = new System.Drawing.Size(194, 20);
            this.accz.TabIndex = 5;
            // 
            // accy
            // 
            this.accy.Location = new System.Drawing.Point(39, 45);
            this.accy.Name = "accy";
            this.accy.ReadOnly = true;
            this.accy.Size = new System.Drawing.Size(194, 20);
            this.accy.TabIndex = 4;
            // 
            // accx
            // 
            this.accx.Location = new System.Drawing.Point(39, 22);
            this.accx.Name = "accx";
            this.accx.ReadOnly = true;
            this.accx.Size = new System.Drawing.Size(194, 20);
            this.accx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "z : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "y : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gysz);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gysy);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gysx);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 95);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gyroscope";
            // 
            // gysz
            // 
            this.gysz.Location = new System.Drawing.Point(39, 68);
            this.gysz.Name = "gysz";
            this.gysz.ReadOnly = true;
            this.gysz.Size = new System.Drawing.Size(194, 20);
            this.gysz.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "z : ";
            // 
            // gysy
            // 
            this.gysy.Location = new System.Drawing.Point(39, 45);
            this.gysy.Name = "gysy";
            this.gysy.ReadOnly = true;
            this.gysy.Size = new System.Drawing.Size(194, 20);
            this.gysy.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "y : ";
            // 
            // gysx
            // 
            this.gysx.Location = new System.Drawing.Point(39, 22);
            this.gysx.Name = "gysx";
            this.gysx.ReadOnly = true;
            this.gysx.Size = new System.Drawing.Size(194, 20);
            this.gysx.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "x : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mgtz);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.mgty);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.mgtx);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 95);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Magnetometer";
            // 
            // mgtz
            // 
            this.mgtz.Location = new System.Drawing.Point(39, 64);
            this.mgtz.Name = "mgtz";
            this.mgtz.ReadOnly = true;
            this.mgtz.Size = new System.Drawing.Size(194, 20);
            this.mgtz.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "z : ";
            // 
            // mgty
            // 
            this.mgty.Location = new System.Drawing.Point(39, 41);
            this.mgty.Name = "mgty";
            this.mgty.ReadOnly = true;
            this.mgty.Size = new System.Drawing.Size(194, 20);
            this.mgty.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "y : ";
            // 
            // mgtx
            // 
            this.mgtx.Location = new System.Drawing.Point(39, 18);
            this.mgtx.Name = "mgtx";
            this.mgtx.ReadOnly = true;
            this.mgtx.Size = new System.Drawing.Size(194, 20);
            this.mgtx.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "x : ";
            // 
            // data_Setter
            // 
            this.data_Setter.Enabled = true;
            this.data_Setter.Tick += new System.EventHandler(this.data_Setter_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.roll);
            this.groupBox4.Controls.Add(this.yaw);
            this.groupBox4.Controls.Add(this.pitch);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(286, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(239, 95);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Attitude";
            // 
            // roll
            // 
            this.roll.Location = new System.Drawing.Point(57, 68);
            this.roll.Name = "roll";
            this.roll.ReadOnly = true;
            this.roll.Size = new System.Drawing.Size(176, 20);
            this.roll.TabIndex = 5;
            // 
            // yaw
            // 
            this.yaw.Location = new System.Drawing.Point(57, 45);
            this.yaw.Name = "yaw";
            this.yaw.ReadOnly = true;
            this.yaw.Size = new System.Drawing.Size(176, 20);
            this.yaw.TabIndex = 4;
            // 
            // pitch
            // 
            this.pitch.Location = new System.Drawing.Point(57, 22);
            this.pitch.Name = "pitch";
            this.pitch.ReadOnly = true;
            this.pitch.Size = new System.Drawing.Size(176, 20);
            this.pitch.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "roll    : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "yaw  : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "pitch : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(286, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // IMU_Display_Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 326);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IMU_Display_Monitor";
            this.Text = "IMU_Display_Monitor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox accz;
        private System.Windows.Forms.TextBox accy;
        private System.Windows.Forms.TextBox accx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer data_Setter;
        private System.Windows.Forms.TextBox gysz;
        private System.Windows.Forms.TextBox gysy;
        private System.Windows.Forms.TextBox gysx;
        private System.Windows.Forms.TextBox mgtz;
        private System.Windows.Forms.TextBox mgty;
        private System.Windows.Forms.TextBox mgtx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox roll;
        private System.Windows.Forms.TextBox yaw;
        private System.Windows.Forms.TextBox pitch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}