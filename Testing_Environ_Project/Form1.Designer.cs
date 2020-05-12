﻿namespace Testing_Environ_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_Box = new System.Windows.Forms.TextBox();
            this.pgn_Output = new System.Windows.Forms.Label();
            this.start_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.time_Output = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.altitude_Output = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.longitude_Output = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.latitude_Output = new System.Windows.Forms.Label();
            this.clear_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.yaw_Output = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.roll_Output = new System.Windows.Forms.Label();
            this.pitch_Output = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PGN : ";
            // 
            // input_Box
            // 
            this.input_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_Box.Location = new System.Drawing.Point(15, 29);
            this.input_Box.Multiline = true;
            this.input_Box.Name = "input_Box";
            this.input_Box.Size = new System.Drawing.Size(582, 137);
            this.input_Box.TabIndex = 2;
            // 
            // pgn_Output
            // 
            this.pgn_Output.AutoSize = true;
            this.pgn_Output.Location = new System.Drawing.Point(68, 177);
            this.pgn_Output.Name = "pgn_Output";
            this.pgn_Output.Size = new System.Drawing.Size(16, 17);
            this.pgn_Output.TabIndex = 3;
            this.pgn_Output.Text = "_";
            this.pgn_Output.Click += new System.EventHandler(this.label3_Click);
            // 
            // start_Btn
            // 
            this.start_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_Btn.Location = new System.Drawing.Point(411, 342);
            this.start_Btn.Name = "start_Btn";
            this.start_Btn.Size = new System.Drawing.Size(186, 45);
            this.start_Btn.TabIndex = 4;
            this.start_Btn.Text = "Start";
            this.start_Btn.UseVisualStyleBackColor = true;
            this.start_Btn.Click += new System.EventHandler(this.start_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time : ";
            // 
            // time_Output
            // 
            this.time_Output.AutoSize = true;
            this.time_Output.Location = new System.Drawing.Point(78, 353);
            this.time_Output.Name = "time_Output";
            this.time_Output.Size = new System.Drawing.Size(16, 17);
            this.time_Output.TabIndex = 6;
            this.time_Output.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Altitude     : ";
            // 
            // altitude_Output
            // 
            this.altitude_Output.AutoSize = true;
            this.altitude_Output.Location = new System.Drawing.Point(96, 27);
            this.altitude_Output.Name = "altitude_Output";
            this.altitude_Output.Size = new System.Drawing.Size(16, 17);
            this.altitude_Output.TabIndex = 8;
            this.altitude_Output.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Longitude : ";
            // 
            // longitude_Output
            // 
            this.longitude_Output.AutoSize = true;
            this.longitude_Output.Location = new System.Drawing.Point(96, 55);
            this.longitude_Output.Name = "longitude_Output";
            this.longitude_Output.Size = new System.Drawing.Size(16, 17);
            this.longitude_Output.TabIndex = 10;
            this.longitude_Output.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Latitude    : ";
            // 
            // latitude_Output
            // 
            this.latitude_Output.AutoSize = true;
            this.latitude_Output.Location = new System.Drawing.Point(97, 84);
            this.latitude_Output.Name = "latitude_Output";
            this.latitude_Output.Size = new System.Drawing.Size(16, 17);
            this.latitude_Output.TabIndex = 12;
            this.latitude_Output.Text = "_";
            // 
            // clear_Btn
            // 
            this.clear_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clear_Btn.Location = new System.Drawing.Point(315, 342);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(90, 45);
            this.clear_Btn.TabIndex = 13;
            this.clear_Btn.Text = "Clear";
            this.clear_Btn.UseVisualStyleBackColor = true;
            this.clear_Btn.Click += new System.EventHandler(this.clear_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.latitude_Output);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.longitude_Output);
            this.groupBox1.Controls.Add(this.altitude_Output);
            this.groupBox1.Location = new System.Drawing.Point(15, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 128);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GNSS";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.yaw_Output);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.roll_Output);
            this.groupBox2.Controls.Add(this.pitch_Output);
            this.groupBox2.Location = new System.Drawing.Point(315, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 128);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IMU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Roll   : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Yaw  : ";
            // 
            // yaw_Output
            // 
            this.yaw_Output.AutoSize = true;
            this.yaw_Output.Location = new System.Drawing.Point(62, 27);
            this.yaw_Output.Name = "yaw_Output";
            this.yaw_Output.Size = new System.Drawing.Size(16, 17);
            this.yaw_Output.TabIndex = 12;
            this.yaw_Output.Text = "_";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Pitch : ";
            // 
            // roll_Output
            // 
            this.roll_Output.AutoSize = true;
            this.roll_Output.Location = new System.Drawing.Point(64, 84);
            this.roll_Output.Name = "roll_Output";
            this.roll_Output.Size = new System.Drawing.Size(16, 17);
            this.roll_Output.TabIndex = 16;
            this.roll_Output.Text = "_";
            // 
            // pitch_Output
            // 
            this.pitch_Output.AutoSize = true;
            this.pitch_Output.Location = new System.Drawing.Point(62, 58);
            this.pitch_Output.Name = "pitch_Output";
            this.pitch_Output.Size = new System.Drawing.Size(16, 17);
            this.pitch_Output.TabIndex = 14;
            this.pitch_Output.Text = "_";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 399);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.time_Output);
            this.Controls.Add(this.clear_Btn);
            this.Controls.Add(this.start_Btn);
            this.Controls.Add(this.pgn_Output);
            this.Controls.Add(this.input_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sample Data Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_Box;
        private System.Windows.Forms.Label pgn_Output;
        private System.Windows.Forms.Button start_Btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label time_Output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label altitude_Output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label longitude_Output;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label latitude_Output;
        private System.Windows.Forms.Button clear_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label yaw_Output;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label roll_Output;
        private System.Windows.Forms.Label pitch_Output;
    }
}

