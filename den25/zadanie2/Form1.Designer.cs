namespace WinFormsApp2
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
            userControlTimerNewTry1 = new UserControlTimerNewTry();
            SuspendLayout();
            // 
            // userControlTimerNewTry1
            // 
            userControlTimerNewTry1.Font = new Font("Segoe UI", 14.8301888F);
            userControlTimerNewTry1.Location = new Point(14, 39);
            userControlTimerNewTry1.Margin = new Padding(5);
            userControlTimerNewTry1.Name = "userControlTimerNewTry1";
            userControlTimerNewTry1.Size = new Size(179, 109);
            userControlTimerNewTry1.TabIndex = 2;
            userControlTimerNewTry1.TimeEnabled = true;
            userControlTimerNewTry1.Load += userControlTimerNewTry1_Load;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 154);
            Controls.Add(userControlTimerNewTry1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private UserControlTimerNewTry userControlTimerNewTry1;
    }
}
