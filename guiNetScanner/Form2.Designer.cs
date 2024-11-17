namespace guiNetScanner
{
    partial class Form2
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
            f2Label1 = new Label();
            SuspendLayout();
            // 
            // f2Label1
            // 
            f2Label1.AutoSize = true;
            f2Label1.Location = new Point(12, 9);
            f2Label1.Name = "f2Label1";
            f2Label1.Size = new Size(59, 15);
            f2Label1.TabIndex = 0;
            f2Label1.Text = "Loading...";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 425);
            Controls.Add(f2Label1);
            Name = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label f2Label1;
    }
}