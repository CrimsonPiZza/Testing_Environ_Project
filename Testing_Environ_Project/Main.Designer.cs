namespace Testing_Environ_Project
{
    partial class Main
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
            this.GNSS_DataConversion_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Two_Positions_Distance_Btn = new System.Windows.Forms.Button();
            this.IMU_Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GNSS_DataConversion_Btn
            // 
            this.GNSS_DataConversion_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GNSS_DataConversion_Btn.Location = new System.Drawing.Point(12, 65);
            this.GNSS_DataConversion_Btn.Name = "GNSS_DataConversion_Btn";
            this.GNSS_DataConversion_Btn.Size = new System.Drawing.Size(268, 62);
            this.GNSS_DataConversion_Btn.TabIndex = 0;
            this.GNSS_DataConversion_Btn.Text = "GNSS Data Conversion";
            this.GNSS_DataConversion_Btn.UseVisualStyleBackColor = true;
            this.GNSS_DataConversion_Btn.Click += new System.EventHandler(this.GNSS_DataConversion_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Testing Environment";
            // 
            // Two_Positions_Distance_Btn
            // 
            this.Two_Positions_Distance_Btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Two_Positions_Distance_Btn.Location = new System.Drawing.Point(12, 133);
            this.Two_Positions_Distance_Btn.Name = "Two_Positions_Distance_Btn";
            this.Two_Positions_Distance_Btn.Size = new System.Drawing.Size(268, 62);
            this.Two_Positions_Distance_Btn.TabIndex = 2;
            this.Two_Positions_Distance_Btn.Text = "Distance Between Two Positions";
            this.Two_Positions_Distance_Btn.UseVisualStyleBackColor = true;
            this.Two_Positions_Distance_Btn.Click += new System.EventHandler(this.Two_Positions_Distance_Btn_Click);
            // 
            // IMU_Display
            // 
            this.IMU_Display.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.IMU_Display.Location = new System.Drawing.Point(12, 201);
            this.IMU_Display.Name = "IMU_Display";
            this.IMU_Display.Size = new System.Drawing.Size(268, 62);
            this.IMU_Display.TabIndex = 3;
            this.IMU_Display.Text = "IMU Display Monitor";
            this.IMU_Display.UseVisualStyleBackColor = true;
            this.IMU_Display.Click += new System.EventHandler(this.IMU_Display_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 344);
            this.Controls.Add(this.IMU_Display);
            this.Controls.Add(this.Two_Positions_Distance_Btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GNSS_DataConversion_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GNSS_DataConversion_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Two_Positions_Distance_Btn;
        private System.Windows.Forms.Button IMU_Display;
    }
}