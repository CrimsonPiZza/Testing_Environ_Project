namespace Testing_Environ_Project
{
    partial class Distance_Between_2positions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lat1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.long1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.long2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lat2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculate_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.long1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lat1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude    : ";
            // 
            // lat1
            // 
            this.lat1.Location = new System.Drawing.Point(66, 32);
            this.lat1.Name = "lat1";
            this.lat1.Size = new System.Drawing.Size(167, 20);
            this.lat1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Longitude : ";
            // 
            // long1
            // 
            this.long1.Location = new System.Drawing.Point(66, 68);
            this.long1.Name = "long1";
            this.long1.Size = new System.Drawing.Size(167, 20);
            this.long1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.long2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lat2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 111);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Position 2";
            // 
            // long2
            // 
            this.long2.Location = new System.Drawing.Point(66, 68);
            this.long2.Name = "long2";
            this.long2.Size = new System.Drawing.Size(167, 20);
            this.long2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Longitude : ";
            // 
            // lat2
            // 
            this.lat2.Location = new System.Drawing.Point(66, 32);
            this.lat2.Name = "lat2";
            this.lat2.Size = new System.Drawing.Size(167, 20);
            this.lat2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Latitude    : ";
            // 
            // calculate_Btn
            // 
            this.calculate_Btn.Location = new System.Drawing.Point(270, 19);
            this.calculate_Btn.Name = "calculate_Btn";
            this.calculate_Btn.Size = new System.Drawing.Size(204, 41);
            this.calculate_Btn.TabIndex = 5;
            this.calculate_Btn.Text = "Calculate";
            this.calculate_Btn.UseVisualStyleBackColor = true;
            this.calculate_Btn.Click += new System.EventHandler(this.calculate_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Result : ";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.ForeColor = System.Drawing.Color.Crimson;
            this.result.Location = new System.Drawing.Point(319, 63);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(13, 13);
            this.result.TabIndex = 7;
            this.result.Text = "0";
            // 
            // Distance_Between_2positions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 265);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calculate_Btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Distance_Between_2positions";
            this.Text = "Distance_Between_2positions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Distance_Between_2positions_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox long1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lat1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox long2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lat2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate_Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label result;
    }
}