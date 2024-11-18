namespace guiNetScanner
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
            button1 = new Button();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            progressBar2 = new ProgressBar();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            listBox2 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            errLabel = new Label();
            button3 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 70);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 0;
            button1.Text = "scan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 99);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 304);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 41);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(150, 23);
            progressBar1.TabIndex = 3;
            progressBar1.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "Ip scan (x.y.z.FUZZ)";
            label1.Click += label1_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(168, 41);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(150, 23);
            progressBar2.TabIndex = 5;
            progressBar2.Click += progressBar2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 23);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Port scan";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(168, 70);
            numericUpDown1.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(68, 23);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(242, 70);
            numericUpDown2.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(68, 23);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(183, 99);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 9;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 99);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 10;
            label4.Text = "To";
            label4.Click += label4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(168, 117);
            button2.Name = "button2";
            button2.Size = new Size(150, 23);
            button2.TabIndex = 11;
            button2.Text = "scan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(168, 144);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 259);
            listBox2.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 406);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 14;
            label5.Text = "Closed ports:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(242, 406);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(110, 423);
            numericUpDown3.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(52, 23);
            numericUpDown3.TabIndex = 16;
            numericUpDown3.Value = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown3.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(12, 423);
            label7.Name = "label7";
            label7.Size = new Size(92, 19);
            label7.TabIndex = 17;
            label7.Text = "Timeout (ms):";
            // 
            // errLabel
            // 
            errLabel.AutoSize = true;
            errLabel.Font = new Font("Segoe UI", 7F);
            errLabel.Location = new Point(12, 8);
            errLabel.Name = "errLabel";
            errLabel.Size = new Size(63, 12);
            errLabel.TabIndex = 18;
            errLabel.Text = "ERRORLABEL";
            errLabel.Click += label8_Click;
            // 
            // button3
            // 
            button3.Location = new Point(249, 424);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 19;
            button3.Text = "Show info";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(224, 1);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(105, 19);
            checkBox1.TabIndex = 20;
            checkBox1.Text = "Get hostnames";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(329, 450);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(errLabel);
            Controls.Add(label7);
            Controls.Add(numericUpDown3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(progressBar2);
            Controls.Add(listBox2);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Network Scanner";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private ProgressBar progressBar1;
        private Label label1;
        private ProgressBar progressBar2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label3;
        private Label label4;
        private Button button2;
        private TextBox textBox2;
        private ListBox listBox2;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDown3;
        private Label label7;
        private Label errLabel;
        private Button button3;
        private CheckBox checkBox1;
    }
}
