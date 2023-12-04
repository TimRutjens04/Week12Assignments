namespace CrazyRounding
{
    partial class CrazyRounding
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
            btnRound = new Button();
            label1 = new Label();
            tbxInput = new TextBox();
            rbWhole = new RadioButton();
            rbTenth = new RadioButton();
            rbHundreth = new RadioButton();
            lbxCollection = new ListBox();
            SuspendLayout();
            // 
            // btnRound
            // 
            btnRound.Location = new Point(287, 9);
            btnRound.Name = "btnRound";
            btnRound.Size = new Size(156, 139);
            btnRound.TabIndex = 0;
            btnRound.Text = "Round 10x";
            btnRound.UseVisualStyleBackColor = true;
            btnRound.Click += btnRound_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 1;
            label1.Text = "Number:";
            // 
            // tbxInput
            // 
            tbxInput.Location = new Point(99, 9);
            tbxInput.Name = "tbxInput";
            tbxInput.Size = new Size(150, 31);
            tbxInput.TabIndex = 2;
            // 
            // rbWhole
            // 
            rbWhole.AutoSize = true;
            rbWhole.Location = new Point(66, 46);
            rbWhole.Name = "rbWhole";
            rbWhole.Size = new Size(107, 29);
            rbWhole.TabIndex = 3;
            rbWhole.TabStop = true;
            rbWhole.Text = "To whole";
            rbWhole.UseVisualStyleBackColor = true;
            // 
            // rbTenth
            // 
            rbTenth.AutoSize = true;
            rbTenth.Location = new Point(66, 81);
            rbTenth.Name = "rbTenth";
            rbTenth.Size = new Size(101, 29);
            rbTenth.TabIndex = 4;
            rbTenth.TabStop = true;
            rbTenth.Text = "To tenth";
            rbTenth.UseVisualStyleBackColor = true;
            // 
            // rbHundreth
            // 
            rbHundreth.AutoSize = true;
            rbHundreth.Location = new Point(66, 119);
            rbHundreth.Name = "rbHundreth";
            rbHundreth.Size = new Size(132, 29);
            rbHundreth.TabIndex = 5;
            rbHundreth.TabStop = true;
            rbHundreth.Text = "To hundreth";
            rbHundreth.UseVisualStyleBackColor = true;
            // 
            // lbxCollection
            // 
            lbxCollection.FormattingEnabled = true;
            lbxCollection.ItemHeight = 25;
            lbxCollection.Items.AddRange(new object[] { "" });
            lbxCollection.Location = new Point(12, 172);
            lbxCollection.Name = "lbxCollection";
            lbxCollection.Size = new Size(431, 204);
            lbxCollection.TabIndex = 6;
            // 
            // CrazyRounding
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(462, 396);
            Controls.Add(lbxCollection);
            Controls.Add(rbHundreth);
            Controls.Add(rbTenth);
            Controls.Add(rbWhole);
            Controls.Add(tbxInput);
            Controls.Add(label1);
            Controls.Add(btnRound);
            ForeColor = SystemColors.ControlText;
            Name = "CrazyRounding";
            RightToLeft = RightToLeft.No;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRound;
        private Label label1;
        private TextBox tbxInput;
        private RadioButton rbWhole;
        private RadioButton rbTenth;
        private RadioButton rbHundreth;
        private ListBox lbxCollection;
    }
}