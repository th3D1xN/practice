namespace WinFormsApp4
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
            helpProvider1 = new HelpProvider();
            txba = new TextBox();
            txBb = new TextBox();
            btnWork = new Button();
            btnRun = new Button();
            btnHelp = new Button();
            SuspendLayout();
            // 
            // helpProvider1
            // 
            helpProvider1.HelpNamespace = "D:\\коды\\practic\\den25\\task4\\bin\\Debug\\net8.0-windows\\Help.txt";
            // 
            // txba
            // 
            helpProvider1.SetHelpString(txba, "For input integer A");
            txba.Location = new Point(66, 71);
            txba.Margin = new Padding(4);
            txba.Name = "txba";
            helpProvider1.SetShowHelp(txba, true);
            txba.Size = new Size(155, 31);
            txba.TabIndex = 0;
            txba.TextChanged += txba_TextChanged;
            // 
            // txBb
            // 
            helpProvider1.SetHelpString(txBb, "For input integer B");
            txBb.Location = new Point(66, 144);
            txBb.Margin = new Padding(4);
            txBb.Name = "txBb";
            helpProvider1.SetShowHelp(txBb, true);
            txBb.Size = new Size(155, 31);
            txBb.TabIndex = 1;
            // 
            // btnWork
            // 
            helpProvider1.SetHelpString(btnWork, "Start work");
            btnWork.Location = new Point(317, 71);
            btnWork.Margin = new Padding(4);
            btnWork.Name = "btnWork";
            helpProvider1.SetShowHelp(btnWork, true);
            btnWork.Size = new Size(117, 37);
            btnWork.TabIndex = 2;
            btnWork.Text = "work";
            btnWork.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            helpProvider1.SetHelpString(btnRun, "Run");
            btnRun.Location = new Point(317, 144);
            btnRun.Margin = new Padding(4);
            btnRun.Name = "btnRun";
            helpProvider1.SetShowHelp(btnRun, true);
            btnRun.Size = new Size(117, 37);
            btnRun.TabIndex = 3;
            btnRun.Text = "run";
            btnRun.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(521, 71);
            btnHelp.Margin = new Padding(4);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(117, 37);
            btnHelp.TabIndex = 4;
            btnHelp.Text = "help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 269);
            Controls.Add(btnHelp);
            Controls.Add(btnRun);
            Controls.Add(btnWork);
            Controls.Add(txBb);
            Controls.Add(txba);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            HelpButton = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HelpProvider helpProvider1;
        private TextBox txba;
        private TextBox txBb;
        private Button btnWork;
        private Button btnRun;
        private Button btnHelp;
    }
}
