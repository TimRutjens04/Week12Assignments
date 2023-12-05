namespace WriteToFile
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
            btnWrite = new Button();
            label1 = new Label();
            tbxTitle = new TextBox();
            tbxText = new RichTextBox();
            SuspendLayout();
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(12, 318);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(331, 34);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Write to file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 1;
            label1.Text = "Title:";
            // 
            // tbxTitle
            // 
            tbxTitle.Location = new Point(66, 6);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(277, 31);
            tbxTitle.TabIndex = 2;
            // 
            // tbxText
            // 
            tbxText.Location = new Point(12, 43);
            tbxText.Name = "tbxText";
            tbxText.Size = new Size(331, 269);
            tbxText.TabIndex = 3;
            tbxText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 361);
            Controls.Add(tbxText);
            Controls.Add(tbxTitle);
            Controls.Add(label1);
            Controls.Add(btnWrite);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWrite;
        private Label label1;
        private TextBox tbxTitle;
        private RichTextBox tbxText;
    }
}