namespace UnitConverter.Winforms.Subforms
{
    partial class MeterToCentimeter
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
            this.button_Exit = new System.Windows.Forms.Button();
            this.label_MeterToCentimeterTitle = new System.Windows.Forms.Label();
            this.label_EnterNumberInMeters = new System.Windows.Forms.Label();
            this.label_NumberInCentimeters = new System.Windows.Forms.Label();
            this.label_Output = new System.Windows.Forms.Label();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Exit.Location = new System.Drawing.Point(269, 206);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(84, 53);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label_MeterToCentimeterTitle
            // 
            this.label_MeterToCentimeterTitle.AutoSize = true;
            this.label_MeterToCentimeterTitle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_MeterToCentimeterTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_MeterToCentimeterTitle.Location = new System.Drawing.Point(61, 26);
            this.label_MeterToCentimeterTitle.Name = "label_MeterToCentimeterTitle";
            this.label_MeterToCentimeterTitle.Size = new System.Drawing.Size(259, 23);
            this.label_MeterToCentimeterTitle.TabIndex = 1;
            this.label_MeterToCentimeterTitle.Text = "Meter To Centimeter Converter";
            // 
            // label_EnterNumberInMeters
            // 
            this.label_EnterNumberInMeters.AutoSize = true;
            this.label_EnterNumberInMeters.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_EnterNumberInMeters.Location = new System.Drawing.Point(12, 87);
            this.label_EnterNumberInMeters.Name = "label_EnterNumberInMeters";
            this.label_EnterNumberInMeters.Size = new System.Drawing.Size(150, 18);
            this.label_EnterNumberInMeters.TabIndex = 2;
            this.label_EnterNumberInMeters.Text = "Enter number in Meters";
            // 
            // label_NumberInCentimeters
            // 
            this.label_NumberInCentimeters.AutoSize = true;
            this.label_NumberInCentimeters.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NumberInCentimeters.Location = new System.Drawing.Point(12, 146);
            this.label_NumberInCentimeters.Name = "label_NumberInCentimeters";
            this.label_NumberInCentimeters.Size = new System.Drawing.Size(145, 18);
            this.label_NumberInCentimeters.TabIndex = 3;
            this.label_NumberInCentimeters.Text = "Number in Centimeters";
            // 
            // label_Output
            // 
            this.label_Output.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Output.Location = new System.Drawing.Point(221, 146);
            this.label_Output.Name = "label_Output";
            this.label_Output.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Output.Size = new System.Drawing.Size(159, 18);
            this.label_Output.TabIndex = 4;
            this.label_Output.Text = "0";
            this.label_Output.Click += new System.EventHandler(this.label_Output_Click);
            // 
            // textBox_Input
            // 
            this.textBox_Input.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Input.Location = new System.Drawing.Point(223, 82);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.PlaceholderText = "0";
            this.textBox_Input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Input.Size = new System.Drawing.Size(157, 26);
            this.textBox_Input.TabIndex = 5;
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Reset.Location = new System.Drawing.Point(153, 206);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(84, 53);
            this.button_Reset.TabIndex = 6;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Convert
            // 
            this.button_Convert.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Convert.Location = new System.Drawing.Point(36, 206);
            this.button_Convert.Name = "button_Convert";
            this.button_Convert.Size = new System.Drawing.Size(84, 53);
            this.button_Convert.TabIndex = 7;
            this.button_Convert.Text = "Convert";
            this.button_Convert.UseVisualStyleBackColor = true;
            this.button_Convert.Click += new System.EventHandler(this.button_Convert_Click);
            // 
            // MeterToCentimeter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 312);
            this.Controls.Add(this.button_Convert);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.label_NumberInCentimeters);
            this.Controls.Add(this.label_EnterNumberInMeters);
            this.Controls.Add(this.label_MeterToCentimeterTitle);
            this.Controls.Add(this.button_Exit);
            this.Name = "MeterToCentimeter";
            this.Text = "MeterToCentimeter";
            this.Load += new System.EventHandler(this.MeterToCentimeter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Label label_MeterToCentimeterTitle;
        private System.Windows.Forms.Label label_EnterNumberInMeters;
        private System.Windows.Forms.Label label_NumberInCentimeters;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Convert;
    }
}