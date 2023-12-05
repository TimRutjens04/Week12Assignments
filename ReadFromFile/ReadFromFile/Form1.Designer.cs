namespace ReadFromFile
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
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            gbxFirstName = new GroupBox();
            lbxFirstName = new ListBox();
            gbxLastName = new GroupBox();
            lbxLastName = new ListBox();
            gbxEmail = new GroupBox();
            lbxEmail = new ListBox();
            gbxGender = new GroupBox();
            lbxGender = new ListBox();
            gbxIP = new GroupBox();
            lbxIP = new ListBox();
            gbxFirstName.SuspendLayout();
            gbxLastName.SuspendLayout();
            gbxEmail.SuspendLayout();
            gbxGender.SuspendLayout();
            gbxIP.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(190, 34);
            button1.TabIndex = 0;
            button1.Text = "Select a .csv file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gbxFirstName
            // 
            gbxFirstName.Controls.Add(lbxFirstName);
            gbxFirstName.Location = new Point(12, 52);
            gbxFirstName.Name = "gbxFirstName";
            gbxFirstName.Size = new Size(220, 396);
            gbxFirstName.TabIndex = 1;
            gbxFirstName.TabStop = false;
            gbxFirstName.Text = "First name";
            // 
            // lbxFirstName
            // 
            lbxFirstName.FormattingEnabled = true;
            lbxFirstName.ItemHeight = 25;
            lbxFirstName.Location = new Point(6, 30);
            lbxFirstName.Name = "lbxFirstName";
            lbxFirstName.Size = new Size(208, 354);
            lbxFirstName.TabIndex = 1;
            // 
            // gbxLastName
            // 
            gbxLastName.Controls.Add(lbxLastName);
            gbxLastName.Location = new Point(238, 52);
            gbxLastName.Name = "gbxLastName";
            gbxLastName.Size = new Size(220, 396);
            gbxLastName.TabIndex = 2;
            gbxLastName.TabStop = false;
            gbxLastName.Text = "Last name";
            // 
            // lbxLastName
            // 
            lbxLastName.FormattingEnabled = true;
            lbxLastName.ItemHeight = 25;
            lbxLastName.Location = new Point(0, 30);
            lbxLastName.Name = "lbxLastName";
            lbxLastName.Size = new Size(208, 354);
            lbxLastName.TabIndex = 2;
            // 
            // gbxEmail
            // 
            gbxEmail.Controls.Add(lbxEmail);
            gbxEmail.Location = new Point(464, 52);
            gbxEmail.Name = "gbxEmail";
            gbxEmail.Size = new Size(286, 396);
            gbxEmail.TabIndex = 2;
            gbxEmail.TabStop = false;
            gbxEmail.Text = "Email";
            // 
            // lbxEmail
            // 
            lbxEmail.FormattingEnabled = true;
            lbxEmail.ItemHeight = 25;
            lbxEmail.Location = new Point(6, 30);
            lbxEmail.Name = "lbxEmail";
            lbxEmail.Size = new Size(274, 354);
            lbxEmail.TabIndex = 0;
            // 
            // gbxGender
            // 
            gbxGender.Controls.Add(lbxGender);
            gbxGender.Location = new Point(756, 52);
            gbxGender.Name = "gbxGender";
            gbxGender.Size = new Size(154, 396);
            gbxGender.TabIndex = 3;
            gbxGender.TabStop = false;
            gbxGender.Text = "Gender";
            // 
            // lbxGender
            // 
            lbxGender.FormattingEnabled = true;
            lbxGender.ItemHeight = 25;
            lbxGender.Location = new Point(6, 30);
            lbxGender.Name = "lbxGender";
            lbxGender.Size = new Size(142, 354);
            lbxGender.TabIndex = 3;
            // 
            // gbxIP
            // 
            gbxIP.Controls.Add(lbxIP);
            gbxIP.Location = new Point(916, 52);
            gbxIP.Name = "gbxIP";
            gbxIP.Size = new Size(220, 396);
            gbxIP.TabIndex = 2;
            gbxIP.TabStop = false;
            gbxIP.Text = "IP-Adress";
            // 
            // lbxIP
            // 
            lbxIP.FormattingEnabled = true;
            lbxIP.ItemHeight = 25;
            lbxIP.Location = new Point(6, 30);
            lbxIP.Name = "lbxIP";
            lbxIP.Size = new Size(208, 354);
            lbxIP.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 471);
            Controls.Add(gbxIP);
            Controls.Add(gbxGender);
            Controls.Add(gbxEmail);
            Controls.Add(gbxLastName);
            Controls.Add(gbxFirstName);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            gbxFirstName.ResumeLayout(false);
            gbxLastName.ResumeLayout(false);
            gbxEmail.ResumeLayout(false);
            gbxGender.ResumeLayout(false);
            gbxIP.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button1;
        private GroupBox gbxFirstName;
        private GroupBox gbxLastName;
        private GroupBox gbxEmail;
        private GroupBox gbxGender;
        private GroupBox gbxIP;
        private ListBox lbxFirstName;
        private ListBox lbxLastName;
        private ListBox lbxEmail;
        private ListBox lbxGender;
        private ListBox lbxIP;
    }
}