
namespace Bakery
{
    partial class AddForm
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
            label1 = new System.Windows.Forms.Label();
            cbbBreadFilter = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            btnAdd = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            tbxName = new System.Windows.Forms.TextBox();
            clbxIngredients = new System.Windows.Forms.CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(16, 52);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 25);
            label1.TabIndex = 7;
            label1.Text = "Bread:";
            // 
            // cbbBreadFilter
            // 
            cbbBreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbbBreadFilter.FormattingEnabled = true;
            cbbBreadFilter.Items.AddRange(new object[] { "CIABATTA", "FOCACCIA", "SOUR_DOUGH", "RYE", "WHOLE_WHEAT" });
            cbbBreadFilter.Location = new System.Drawing.Point(125, 50);
            cbbBreadFilter.Margin = new System.Windows.Forms.Padding(2);
            cbbBreadFilter.Name = "cbbBreadFilter";
            cbbBreadFilter.Size = new System.Drawing.Size(473, 33);
            cbbBreadFilter.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(16, 86);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 25);
            label2.TabIndex = 9;
            label2.Text = "Ingredients:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(16, 306);
            btnAdd.Margin = new System.Windows.Forms.Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(574, 36);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add Sandwich";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(16, 17);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 25);
            label3.TabIndex = 11;
            label3.Text = "Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new System.Drawing.Point(125, 15);
            tbxName.Margin = new System.Windows.Forms.Padding(2);
            tbxName.Name = "tbxName";
            tbxName.Size = new System.Drawing.Size(473, 31);
            tbxName.TabIndex = 12;
            // 
            // clbxIngredients
            // 
            clbxIngredients.FormattingEnabled = true;
            clbxIngredients.Location = new System.Drawing.Point(125, 86);
            clbxIngredients.Name = "clbxIngredients";
            clbxIngredients.Size = new System.Drawing.Size(473, 200);
            clbxIngredients.TabIndex = 13;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(615, 352);
            Controls.Add(clbxIngredients);
            Controls.Add(tbxName);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbBreadFilter);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "AddForm";
            Text = "Add New Sandwich";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBreadFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.CheckedListBox clbxIngredients;
    }
}

