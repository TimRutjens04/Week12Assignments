namespace RandomPasswordGenerator
{
    partial class lbxCollection
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
            numCharacters = new NumericUpDown();
            numPasswords = new NumericUpDown();
            cbxSymbols = new CheckBox();
            btnGenerate = new Button();
            lbxPasswords = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numCharacters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPasswords).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 0;
            label1.Text = "Amount of characters:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 1;
            label2.Text = "Amount of passwords:";
            // 
            // numCharacters
            // 
            numCharacters.Location = new Point(214, 9);
            numCharacters.Name = "numCharacters";
            numCharacters.Size = new Size(72, 31);
            numCharacters.TabIndex = 2;
            // 
            // numPasswords
            // 
            numPasswords.Location = new Point(214, 43);
            numPasswords.Name = "numPasswords";
            numPasswords.Size = new Size(72, 31);
            numPasswords.TabIndex = 3;
            // 
            // cbxSymbols
            // 
            cbxSymbols.AutoSize = true;
            cbxSymbols.Location = new Point(12, 80);
            cbxSymbols.Name = "cbxSymbols";
            cbxSymbols.Size = new Size(276, 29);
            cbxSymbols.TabIndex = 5;
            cbxSymbols.Text = "Include symbols (e.g. ! , @ , #)";
            cbxSymbols.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 115);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(274, 34);
            btnGenerate.TabIndex = 6;
            btnGenerate.Text = "Generate passwords";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lbxPasswords
            // 
            lbxPasswords.FormattingEnabled = true;
            lbxPasswords.ItemHeight = 25;
            lbxPasswords.Location = new Point(12, 155);
            lbxPasswords.Name = "lbxPasswords";
            lbxPasswords.Size = new Size(274, 204);
            lbxPasswords.TabIndex = 7;
            // 
            // lbxCollection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 373);
            Controls.Add(lbxPasswords);
            Controls.Add(btnGenerate);
            Controls.Add(cbxSymbols);
            Controls.Add(numPasswords);
            Controls.Add(numCharacters);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "lbxCollection";
            Text = "(Collection)";
            ((System.ComponentModel.ISupportInitialize)numCharacters).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPasswords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numCharacters;
        private NumericUpDown numPasswords;
        private CheckBox cbxSymbols;
        private Button btnGenerate;
        private ListBox lbxPasswords;
    }
}