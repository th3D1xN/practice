namespace zadanie3
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxX0 = new TextBox();
            textBoxXk = new TextBox();
            textBoxB = new TextBox();
            textBoxDx = new TextBox();
            buttonCalculate = new Button();
            listBoxResult = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(31, 25);
            label1.TabIndex = 0;
            label1.Text = "x₀:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 22);
            label2.Name = "label2";
            label2.Size = new Size(29, 25);
            label2.TabIndex = 1;
            label2.Text = "xₖ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 76);
            label3.Name = "label3";
            label3.Size = new Size(35, 25);
            label3.TabIndex = 2;
            label3.Text = "dx:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 76);
            label4.Name = "label4";
            label4.Size = new Size(27, 25);
            label4.TabIndex = 3;
            label4.Text = "b:";
            // 
            // textBoxX0
            // 
            textBoxX0.Location = new Point(62, 16);
            textBoxX0.Name = "textBoxX0";
            textBoxX0.Size = new Size(150, 31);
            textBoxX0.TabIndex = 4;
            // 
            // textBoxXk
            // 
            textBoxXk.Location = new Point(309, 19);
            textBoxXk.Name = "textBoxXk";
            textBoxXk.Size = new Size(150, 31);
            textBoxXk.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.BackColor = SystemColors.ButtonHighlight;
            textBoxB.Location = new Point(309, 70);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(150, 31);
            textBoxB.TabIndex = 6;
            // 
            // textBoxDx
            // 
            textBoxDx.Location = new Point(62, 70);
            textBoxDx.Name = "textBoxDx";
            textBoxDx.Size = new Size(150, 31);
            textBoxDx.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(538, 44);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(112, 34);
            buttonCalculate.TabIndex = 8;
            buttonCalculate.Text = "Вычислить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 25;
            listBoxResult.Location = new Point(135, 131);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(241, 179);
            listBoxResult.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResult);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxDx);
            Controls.Add(textBoxB);
            Controls.Add(textBoxXk);
            Controls.Add(textBoxX0);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxX0;
        private TextBox textBoxXk;
        private TextBox textBoxB;
        private TextBox textBoxDx;
        private Button buttonCalculate;
        private ListBox listBoxResult;
    }
}
