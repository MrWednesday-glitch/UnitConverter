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
            this.button_Reset = new System.Windows.Forms.Button();
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.label_Output = new System.Windows.Forms.Label();
            this.label_InputType = new System.Windows.Forms.Label();
            this.label_OutputType = new System.Windows.Forms.Label();
            this.label_ENterANumberToBeConverted = new System.Windows.Forms.Label();
            this.label_ConvertedNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_ConverterOverview
            // 
            this.label_ConverterOverview.AutoSize = true;
            this.label_ConverterOverview.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_ConverterOverview.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_ConverterOverview.Location = new System.Drawing.Point(257, 23);
            this.label_ConverterOverview.Name = "label_ConverterOverview";
            this.label_ConverterOverview.Size = new System.Drawing.Size(192, 27);
            this.label_ConverterOverview.TabIndex = 0;
            this.label_ConverterOverview.Text = "Converter Overview";
            // 
            // button_MeterToCentimeter
            // 
            this.button_MeterToCentimeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MeterToCentimeter.Location = new System.Drawing.Point(12, 71);
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
            this.button_Exit.Location = new System.Drawing.Point(591, 250);
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
            this.button_CentimeterToMeter.Location = new System.Drawing.Point(130, 71);
            this.button_CentimeterToMeter.Name = "button_CentimeterToMeter";
            this.button_CentimeterToMeter.Size = new System.Drawing.Size(106, 52);
            this.button_CentimeterToMeter.TabIndex = 3;
            this.button_CentimeterToMeter.Text = "Centimeter ==> Meter";
            this.button_CentimeterToMeter.UseVisualStyleBackColor = true;
            this.button_CentimeterToMeter.Click += new System.EventHandler(this.button_CentimeterToMeter_Click);
            // 
            // button_CentimeterToMillimeter
            // 
            this.button_CentimeterToMillimeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_CentimeterToMillimeter.Location = new System.Drawing.Point(12, 129);
            this.button_CentimeterToMillimeter.Name = "button_CentimeterToMillimeter";
            this.button_CentimeterToMillimeter.Size = new System.Drawing.Size(112, 52);
            this.button_CentimeterToMillimeter.TabIndex = 4;
            this.button_CentimeterToMillimeter.Text = "Centimeter ==> Millimeter";
            this.button_CentimeterToMillimeter.UseVisualStyleBackColor = true;
            this.button_CentimeterToMillimeter.Click += new System.EventHandler(this.button_CentimeterToMillimeter_Click);
            // 
            // button_MillimeterToCentimeter
            // 
            this.button_MillimeterToCentimeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MillimeterToCentimeter.Location = new System.Drawing.Point(130, 129);
            this.button_MillimeterToCentimeter.Name = "button_MillimeterToCentimeter";
            this.button_MillimeterToCentimeter.Size = new System.Drawing.Size(106, 52);
            this.button_MillimeterToCentimeter.TabIndex = 5;
            this.button_MillimeterToCentimeter.Text = "Millimeter ==> Centimeter";
            this.button_MillimeterToCentimeter.UseVisualStyleBackColor = true;
            this.button_MillimeterToCentimeter.Click += new System.EventHandler(this.button_MillimeterToCentimeter_Click);
            // 
            // button_MeterToInch
            // 
            this.button_MeterToInch.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_MeterToInch.Location = new System.Drawing.Point(12, 187);
            this.button_MeterToInch.Name = "button_MeterToInch";
            this.button_MeterToInch.Size = new System.Drawing.Size(112, 52);
            this.button_MeterToInch.TabIndex = 6;
            this.button_MeterToInch.Text = "Meter ==> Inch";
            this.button_MeterToInch.UseVisualStyleBackColor = true;
            this.button_MeterToInch.Click += new System.EventHandler(this.button_MeterToInch_Click);
            // 
            // button_InchToMeter
            // 
            this.button_InchToMeter.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_InchToMeter.Location = new System.Drawing.Point(130, 187);
            this.button_InchToMeter.Name = "button_InchToMeter";
            this.button_InchToMeter.Size = new System.Drawing.Size(106, 52);
            this.button_InchToMeter.TabIndex = 7;
            this.button_InchToMeter.Text = "Inch ==> Meter";
            this.button_InchToMeter.UseVisualStyleBackColor = true;
            this.button_InchToMeter.Click += new System.EventHandler(this.button_InchToMeter_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Reset.Location = new System.Drawing.Point(501, 250);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(84, 53);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // textBox_Input
            // 
            this.textBox_Input.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Input.Location = new System.Drawing.Point(462, 85);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.PlaceholderText = "0";
            this.textBox_Input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Input.Size = new System.Drawing.Size(157, 26);
            this.textBox_Input.TabIndex = 9;
            // 
            // label_Output
            // 
            this.label_Output.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Output.Location = new System.Drawing.Point(462, 204);
            this.label_Output.Name = "label_Output";
            this.label_Output.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_Output.Size = new System.Drawing.Size(157, 18);
            this.label_Output.TabIndex = 10;
            this.label_Output.Text = "0";
            // 
            // label_InputType
            // 
            this.label_InputType.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_InputType.Location = new System.Drawing.Point(625, 85);
            this.label_InputType.Name = "label_InputType";
            this.label_InputType.Size = new System.Drawing.Size(46, 26);
            this.label_InputType.TabIndex = 11;
            // 
            // label_OutputType
            // 
            this.label_OutputType.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_OutputType.Location = new System.Drawing.Point(625, 204);
            this.label_OutputType.Name = "label_OutputType";
            this.label_OutputType.Size = new System.Drawing.Size(46, 18);
            this.label_OutputType.TabIndex = 12;
            // 
            // label_ENterANumberToBeConverted
            // 
            this.label_ENterANumberToBeConverted.AutoSize = true;
            this.label_ENterANumberToBeConverted.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ENterANumberToBeConverted.Location = new System.Drawing.Point(257, 88);
            this.label_ENterANumberToBeConverted.Name = "label_ENterANumberToBeConverted";
            this.label_ENterANumberToBeConverted.Size = new System.Drawing.Size(199, 18);
            this.label_ENterANumberToBeConverted.TabIndex = 13;
            this.label_ENterANumberToBeConverted.Text = "Enter a number to be converted";
            // 
            // label_ConvertedNumber
            // 
            this.label_ConvertedNumber.AutoSize = true;
            this.label_ConvertedNumber.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ConvertedNumber.Location = new System.Drawing.Point(257, 204);
            this.label_ConvertedNumber.Name = "label_ConvertedNumber";
            this.label_ConvertedNumber.Size = new System.Drawing.Size(117, 18);
            this.label_ConvertedNumber.TabIndex = 14;
            this.label_ConvertedNumber.Text = "Converted number";
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 314);
            this.Controls.Add(this.label_ConvertedNumber);
            this.Controls.Add(this.label_ENterANumberToBeConverted);
            this.Controls.Add(this.label_OutputType);
            this.Controls.Add(this.label_InputType);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.textBox_Input);
            this.Controls.Add(this.button_Reset);
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
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Label label_InputType;
        private System.Windows.Forms.Label label_OutputType;
        private System.Windows.Forms.Label label_ENterANumberToBeConverted;
        private System.Windows.Forms.Label label_ConvertedNumber;
    }
}