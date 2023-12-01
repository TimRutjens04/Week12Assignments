namespace Planets
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
            btnEarth = new Button();
            btnMars = new Button();
            btnSaturn = new Button();
            btnMercury = new Button();
            btnVenus = new Button();
            tbxGravity = new TextBox();
            tbxDiameter = new TextBox();
            pbxPlanet = new PictureBox();
            lblPlanet = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxPlanet).BeginInit();
            SuspendLayout();
            // 
            // btnEarth
            // 
            btnEarth.Location = new Point(12, 12);
            btnEarth.Name = "btnEarth";
            btnEarth.Size = new Size(205, 34);
            btnEarth.TabIndex = 0;
            btnEarth.Text = "Earth";
            btnEarth.UseVisualStyleBackColor = true;
            // 
            // btnMars
            // 
            btnMars.Location = new Point(12, 52);
            btnMars.Name = "btnMars";
            btnMars.Size = new Size(205, 34);
            btnMars.TabIndex = 2;
            btnMars.Text = "Mars";
            btnMars.UseVisualStyleBackColor = true;
            // 
            // btnSaturn
            // 
            btnSaturn.Location = new Point(12, 172);
            btnSaturn.Name = "btnSaturn";
            btnSaturn.Size = new Size(205, 34);
            btnSaturn.TabIndex = 3;
            btnSaturn.Text = "Saturn";
            btnSaturn.UseVisualStyleBackColor = true;
            // 
            // btnMercury
            // 
            btnMercury.Location = new Point(12, 132);
            btnMercury.Name = "btnMercury";
            btnMercury.Size = new Size(205, 34);
            btnMercury.TabIndex = 4;
            btnMercury.Text = "Mercury";
            btnMercury.UseVisualStyleBackColor = true;
            // 
            // btnVenus
            // 
            btnVenus.Location = new Point(12, 92);
            btnVenus.Name = "btnVenus";
            btnVenus.Size = new Size(205, 34);
            btnVenus.TabIndex = 5;
            btnVenus.Text = "Venus";
            btnVenus.UseVisualStyleBackColor = true;
            // 
            // tbxGravity
            // 
            tbxGravity.Location = new Point(264, 92);
            tbxGravity.Name = "tbxGravity";
            tbxGravity.Size = new Size(224, 31);
            tbxGravity.TabIndex = 6;
            // 
            // tbxDiameter
            // 
            tbxDiameter.Location = new Point(264, 135);
            tbxDiameter.Name = "tbxDiameter";
            tbxDiameter.Size = new Size(224, 31);
            tbxDiameter.TabIndex = 7;
            // 
            // pbxPlanet
            // 
            pbxPlanet.Location = new Point(540, 12);
            pbxPlanet.Name = "pbxPlanet";
            pbxPlanet.Size = new Size(248, 194);
            pbxPlanet.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPlanet.TabIndex = 8;
            pbxPlanet.TabStop = false;
            // 
            // lblPlanet
            // 
            lblPlanet.AutoSize = true;
            lblPlanet.Location = new Point(352, 64);
            lblPlanet.Name = "lblPlanet";
            lblPlanet.Size = new Size(0, 25);
            lblPlanet.TabIndex = 9;
            lblPlanet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 220);
            Controls.Add(lblPlanet);
            Controls.Add(pbxPlanet);
            Controls.Add(tbxDiameter);
            Controls.Add(tbxGravity);
            Controls.Add(btnVenus);
            Controls.Add(btnMercury);
            Controls.Add(btnSaturn);
            Controls.Add(btnMars);
            Controls.Add(btnEarth);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxPlanet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEarth;
        private Button btnMars;
        private Button btnSaturn;
        private Button btnMercury;
        private Button btnVenus;
        private TextBox tbxGravity;
        private TextBox tbxDiameter;
        private PictureBox pbxPlanet;
        private Label lblPlanet;
    }
}