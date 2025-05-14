namespace zadanie1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelX = new Label();
            textBoxX = new TextBox();
            labelY = new Label();
            labelZ = new Label();
            textBoxY = new TextBox();
            textBoxZ = new TextBox();
            buttonCalculate = new Button();
            labelResult = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(2, 9);
            labelX.Name = "labelX";
            labelX.Size = new Size(94, 25);
            labelX.TabIndex = 0;
            labelX.Text = "Введите x:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(102, 6);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(150, 31);
            textBoxX.TabIndex = 1;
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(2, 60);
            labelY.Name = "labelY";
            labelY.Size = new Size(95, 25);
            labelY.TabIndex = 2;
            labelY.Text = "Введите y:";
            // 
            // labelZ
            // 
            labelZ.AutoSize = true;
            labelZ.Location = new Point(2, 113);
            labelZ.Name = "labelZ";
            labelZ.Size = new Size(94, 25);
            labelZ.TabIndex = 3;
            labelZ.Text = "Введите z:";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(102, 57);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(150, 31);
            textBoxY.TabIndex = 4;
            // 
            // textBoxZ
            // 
            textBoxZ.Location = new Point(102, 113);
            textBoxZ.Name = "textBoxZ";
            textBoxZ.Size = new Size(150, 31);
            textBoxZ.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(77, 168);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(112, 34);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Вычислить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(446, 12);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(111, 25);
            labelResult.TabIndex = 7;
            labelResult.Text = "Результат φ:";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ControlLightLight;
            textBoxResult.Location = new Point(563, 12);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(150, 31);
            textBoxResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxZ);
            Controls.Add(textBoxY);
            Controls.Add(labelZ);
            Controls.Add(labelY);
            Controls.Add(textBoxX);
            Controls.Add(labelX);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelX;
        private TextBox textBoxX;
        private Label labelY;
        private Label labelZ;
        private TextBox textBoxY;
        private TextBox textBoxZ;
        private Button buttonCalculate;
        private Label labelResult;
        private TextBox textBoxResult;
    }
}
