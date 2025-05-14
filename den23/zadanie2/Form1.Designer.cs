namespace zadanie2
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
            labelB = new Label();
            textBoxB = new TextBox();
            groupBox1 = new GroupBox();
            radioButtonExp = new RadioButton();
            radioButtonX2 = new RadioButton();
            radioButtonSinh = new RadioButton();
            buttonCalculate = new Button();
            labelResult = new Label();
            textBoxResult = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(11, 19);
            labelX.Name = "labelX";
            labelX.Size = new Size(94, 25);
            labelX.TabIndex = 0;
            labelX.Text = "Введите x:";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(112, 16);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(150, 31);
            textBoxX.TabIndex = 1;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(11, 116);
            labelB.Name = "labelB";
            labelB.Size = new Size(97, 25);
            labelB.TabIndex = 2;
            labelB.Text = "Введите b:";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(112, 117);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(150, 31);
            textBoxB.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonExp);
            groupBox1.Controls.Add(radioButtonX2);
            groupBox1.Controls.Add(radioButtonSinh);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(309, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(221, 136);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите функцию f(x)";
            // 
            // radioButtonExp
            // 
            radioButtonExp.AutoSize = true;
            radioButtonExp.Location = new Point(0, 100);
            radioButtonExp.Name = "radioButtonExp";
            radioButtonExp.Size = new Size(66, 29);
            radioButtonExp.TabIndex = 2;
            radioButtonExp.TabStop = true;
            radioButtonExp.Text = "e^x";
            radioButtonExp.UseVisualStyleBackColor = true;
            // 
            // radioButtonX2
            // 
            radioButtonX2.AutoSize = true;
            radioButtonX2.Location = new Point(0, 65);
            radioButtonX2.Name = "radioButtonX2";
            radioButtonX2.Size = new Size(52, 29);
            radioButtonX2.TabIndex = 1;
            radioButtonX2.TabStop = true;
            radioButtonX2.Text = "x²";
            radioButtonX2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSinh
            // 
            radioButtonSinh.AutoSize = true;
            radioButtonSinh.Location = new Point(0, 30);
            radioButtonSinh.Name = "radioButtonSinh";
            radioButtonSinh.Size = new Size(73, 29);
            radioButtonSinh.TabIndex = 0;
            radioButtonSinh.TabStop = true;
            radioButtonSinh.Text = "sh(x)";
            radioButtonSinh.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(79, 187);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(112, 34);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Вычислить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(281, 192);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(93, 25);
            labelResult.TabIndex = 6;
            labelResult.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ButtonHighlight;
            textBoxResult.Location = new Point(380, 189);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(150, 31);
            textBoxResult.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(groupBox1);
            Controls.Add(textBoxB);
            Controls.Add(labelB);
            Controls.Add(textBoxX);
            Controls.Add(labelX);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelX;
        private TextBox textBoxX;
        private Label labelB;
        private TextBox textBoxB;
        private GroupBox groupBox1;
        private RadioButton radioButtonSinh;
        private RadioButton radioButtonExp;
        private RadioButton radioButtonX2;
        private Button buttonCalculate;
        private Label labelResult;
        private TextBox textBoxResult;
    }
}
