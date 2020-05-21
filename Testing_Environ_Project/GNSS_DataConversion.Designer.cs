namespace Testing_Environ_Project
{
    partial class GNSS_DataConversion
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PGN : ";
            // 
            // input_Box
            // 
            this.input_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_Box.Location = new System.Drawing.Point(11, 24);
            this.input_Box.Margin = new System.Windows.Forms.Padding(2);
            this.input_Box.Multiline = true;
            this.input_Box.Name = "input_Box";
            this.input_Box.Size = new System.Drawing.Size(438, 112);
            this.input_Box.TabIndex = 2;
            // 
            // pgn_Output
            // 
            this.pgn_Output.AutoSize = true;
            this.pgn_Output.Location = new System.Drawing.Point(51, 144);
            this.pgn_Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pgn_Output.Name = "pgn_Output";
            this.pgn_Output.Size = new System.Drawing.Size(13, 13);
            this.pgn_Output.TabIndex = 3;
            this.pgn_Output.Text = "_";
            this.pgn_Output.Click += new System.EventHandler(this.label3_Click);
            // 
            // start_Btn
            // 
            this.start_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.start_Btn.Location = new System.Drawing.Point(308, 278);
            this.start_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.start_Btn.Name = "start_Btn";
            this.start_Btn.Size = new System.Drawing.Size(140, 37);
            this.start_Btn.TabIndex = 4;
            this.start_Btn.Text = "Start";
            this.start_Btn.UseVisualStyleBackColor = true;
            this.start_Btn.Click += new System.EventHandler(this.start_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 287);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time : ";
            // 
            // time_Output
            // 
            this.time_Output.AutoSize = true;
            this.time_Output.Location = new System.Drawing.Point(58, 287);
            this.time_Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time_Output.Name = "time_Output";
            this.time_Output.Size = new System.Drawing.Size(13, 13);
            this.time_Output.TabIndex = 6;
            this.time_Output.Text = "_";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Altitude     : ";
            // 
            // altitude_Output
            // 
            this.altitude_Output.AutoSize = true;
            this.altitude_Output.Location = new System.Drawing.Point(72, 22);
            this.altitude_Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.altitude_Output.Name = "altitude_Output";
            this.altitude_Output.Size = new System.Drawing.Size(13, 13);
            this.altitude_Output.TabIndex = 8;
            this.altitude_Output.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Longitude : ";
            // 
            // longitude_Output
            // 
            this.longitude_Output.AutoSize = true;
            this.longitude_Output.Location = new System.Drawing.Point(72, 45);
            this.longitude_Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.longitude_Output.Name = "longitude_Output";
            this.longitude_Output.Size = new System.Drawing.Size(13, 13);
            this.longitude_Output.TabIndex = 10;
            this.longitude_Output.Text = "_";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Latitude    : ";
            // 
            // latitude_Output
            // 
            this.latitude_Output.AutoSize = true;
            this.latitude_Output.Location = new System.Drawing.Point(73, 68);
            this.latitude_Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.latitude_Output.Name = "latitude_Output";
            this.latitude_Output.Size = new System.Drawing.Size(13, 13);
            this.latitude_Output.TabIndex = 12;
            this.latitude_Output.Text = "_";
            // 
            // clear_Btn
            // 
            this.clear_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clear_Btn.Location = new System.Drawing.Point(236, 278);
            this.clear_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(68, 37);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(435, 104);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GNSS";
            // 
            // GNSS_DataConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.time_Output);
            this.Controls.Add(this.clear_Btn);
            this.Controls.Add(this.start_Btn);
            this.Controls.Add(this.pgn_Output);
            this.Controls.Add(this.input_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GNSS_DataConversion";
            this.Text = "Sample Data Conversion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GNSS_DataConversion_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

