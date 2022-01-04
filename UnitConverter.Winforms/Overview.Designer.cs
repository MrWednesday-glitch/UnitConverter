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
            this.SuspendLayout();
            // 
            // label_ConverterOverview
            // 
            this.label_ConverterOverview.AutoSize = true;
            this.label_ConverterOverview.Location = new System.Drawing.Point(53, 26);
            this.label_ConverterOverview.Name = "label_ConverterOverview";
            this.label_ConverterOverview.Size = new System.Drawing.Size(111, 15);
            this.label_ConverterOverview.TabIndex = 0;
            this.label_ConverterOverview.Text = "Converter Overview";
            // 
            // button_MeterToCentimeter
            // 
            this.button_MeterToCentimeter.Location = new System.Drawing.Point(36, 76);
            this.button_MeterToCentimeter.Name = "button_MeterToCentimeter";
            this.button_MeterToCentimeter.Size = new System.Drawing.Size(75, 23);
            this.button_MeterToCentimeter.TabIndex = 1;
            this.button_MeterToCentimeter.Text = "M ==> Cm";
            this.button_MeterToCentimeter.UseVisualStyleBackColor = true;
            this.button_MeterToCentimeter.Click += new System.EventHandler(this.button_MeterToCentimeter_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}