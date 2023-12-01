namespace PizzaToppingsExc
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
            cbxToppings = new ComboBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lblPrice = new Label();
            lblTopping = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbxToppings
            // 
            cbxToppings.FormattingEnabled = true;
            cbxToppings.Items.AddRange(new object[] { "Ham", "Mushrooms", "Pepperoni", "Extra cheese", "Onions", "Chicken", "Peppers" });
            cbxToppings.Location = new Point(12, 12);
            cbxToppings.Name = "cbxToppings";
            cbxToppings.Size = new Size(182, 33);
            cbxToppings.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(250, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add topping";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(250, 69);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(154, 34);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove topping";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 69);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(53, 25);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price:";
            // 
            // lblTopping
            // 
            lblTopping.AutoSize = true;
            lblTopping.Location = new Point(12, 115);
            lblTopping.Name = "lblTopping";
            lblTopping.Size = new Size(89, 25);
            lblTopping.TabIndex = 4;
            lblTopping.Text = "Toppings:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 69);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 227);
            Controls.Add(label1);
            Controls.Add(lblTopping);
            Controls.Add(lblPrice);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(cbxToppings);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxToppings;
        private Button btnAdd;
        private Button btnRemove;
        private Label lblPrice;
        private Label lblTopping;
        private Label label1;
    }
}