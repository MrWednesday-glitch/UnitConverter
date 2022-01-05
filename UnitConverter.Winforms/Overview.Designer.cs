namespace UnitConverter.Winforms
{
    partial class Overview
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
            this.label_ConverterOverview = new System.Windows.Forms.Label();
            this.button_MeterToCentimeter = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_CentimeterToMeter = new System.Windows.Forms.Button();
            this.button_CentimeterToMillimeter = new System.Windows.Forms.Button();
            this.button_MillimeterToCentimeter = new System.Windows.Forms.Button();
            this.button_MeterToInch = new System.Windows.Forms.Button();
            this.button_InchToMeter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ConverterOverview
            // 
            this.label_ConverterOverview.AutoSize = true;
            this.label_ConverterOverview.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ConverterOverview.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_ConverterOverview.Location = new System.Drawing.Point(39, 24);
            this.label_ConverterOverview.Name = "label_ConverterOverview";
            this.label_ConverterOverview.Size = new System.Drawing.Size(192, 27);
            this.label_ConverterOverview.TabIndex = 0;
            this.label_ConverterOverview.Text = "Converter Overview";
            // 
            // button_MeterToCentimeter
            // 
            this.button_MeterToCentimeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MeterToCentimeter.Location = new System.Drawing.Point(12, 76);
            this.button_MeterToCentimeter.Name = "button_MeterToCentimeter";
            this.button_MeterToCentimeter.Size = new System.Drawing.Size(112, 52);
            this.button_MeterToCentimeter.TabIndex = 1;
            this.button_MeterToCentimeter.Text = "Meter ==> Centimeter";
            this.button_MeterToCentimeter.UseVisualStyleBackColor = true;
            this.button_MeterToCentimeter.Click += new System.EventHandler(this.button_MeterToCentimeter_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Exit.Location = new System.Drawing.Point(97, 278);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(82, 52);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_CentimeterToMeter
            // 
            this.button_CentimeterToMeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CentimeterToMeter.Location = new System.Drawing.Point(142, 76);
            this.button_CentimeterToMeter.Name = "button_CentimeterToMeter";
            this.button_CentimeterToMeter.Size = new System.Drawing.Size(106, 52);
            this.button_CentimeterToMeter.TabIndex = 3;
            this.button_CentimeterToMeter.Text = "Centimeter ==> Meter";
            this.button_CentimeterToMeter.UseVisualStyleBackColor = true;
            // 
            // button_CentimeterToMillimeter
            // 
            this.button_CentimeterToMillimeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CentimeterToMillimeter.Location = new System.Drawing.Point(12, 134);
            this.button_CentimeterToMillimeter.Name = "button_CentimeterToMillimeter";
            this.button_CentimeterToMillimeter.Size = new System.Drawing.Size(112, 65);
            this.button_CentimeterToMillimeter.TabIndex = 4;
            this.button_CentimeterToMillimeter.Text = "Centimeter ==> Millimeter";
            this.button_CentimeterToMillimeter.UseVisualStyleBackColor = true;
            // 
            // button_MillimeterToCentimeter
            // 
            this.button_MillimeterToCentimeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MillimeterToCentimeter.Location = new System.Drawing.Point(142, 135);
            this.button_MillimeterToCentimeter.Name = "button_MillimeterToCentimeter";
            this.button_MillimeterToCentimeter.Size = new System.Drawing.Size(106, 64);
            this.button_MillimeterToCentimeter.TabIndex = 5;
            this.button_MillimeterToCentimeter.Text = "Millimeter ==> Centimeter";
            this.button_MillimeterToCentimeter.UseVisualStyleBackColor = true;
            // 
            // button_MeterToInch
            // 
            this.button_MeterToInch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MeterToInch.Location = new System.Drawing.Point(12, 205);
            this.button_MeterToInch.Name = "button_MeterToInch";
            this.button_MeterToInch.Size = new System.Drawing.Size(112, 55);
            this.button_MeterToInch.TabIndex = 6;
            this.button_MeterToInch.Text = "Meter ==> Inch";
            this.button_MeterToInch.UseVisualStyleBackColor = true;
            // 
            // button_InchToMeter
            // 
            this.button_InchToMeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_InchToMeter.Location = new System.Drawing.Point(142, 205);
            this.button_InchToMeter.Name = "button_InchToMeter";
            this.button_InchToMeter.Size = new System.Drawing.Size(106, 55);
            this.button_InchToMeter.TabIndex = 7;
            this.button_InchToMeter.Text = "Inch ==> Meter";
            this.button_InchToMeter.UseVisualStyleBackColor = true;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 364);
            this.Controls.Add(this.button_InchToMeter);
            this.Controls.Add(this.button_MeterToInch);
            this.Controls.Add(this.button_MillimeterToCentimeter);
            this.Controls.Add(this.button_CentimeterToMillimeter);
            this.Controls.Add(this.button_CentimeterToMeter);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_MeterToCentimeter);
            this.Controls.Add(this.label_ConverterOverview);
            this.Name = "Overview";
            this.Text = "Overview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ConverterOverview;
        private System.Windows.Forms.Button button_MeterToCentimeter;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_CentimeterToMeter;
        private System.Windows.Forms.Button button_CentimeterToMillimeter;
        private System.Windows.Forms.Button button_MillimeterToCentimeter;
        private System.Windows.Forms.Button button_MeterToInch;
        private System.Windows.Forms.Button button_InchToMeter;
    }
}