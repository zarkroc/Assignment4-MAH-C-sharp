namespace Assignment4
{
    partial class FormIngredients
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
            this.lblNumOfIngredientsText = new System.Windows.Forms.Label();
            this.grpIngredients = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.txtAddIngredient = new System.Windows.Forms.TextBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.lblNumOfIngredients = new System.Windows.Forms.Label();
            this.grpIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumOfIngredientsText
            // 
            this.lblNumOfIngredientsText.AutoSize = true;
            this.lblNumOfIngredientsText.Location = new System.Drawing.Point(13, 13);
            this.lblNumOfIngredientsText.Name = "lblNumOfIngredientsText";
            this.lblNumOfIngredientsText.Size = new System.Drawing.Size(99, 13);
            this.lblNumOfIngredientsText.TabIndex = 0;
            this.lblNumOfIngredientsText.Text = "Num. of Ingredients";
            // 
            // grpIngredients
            // 
            this.grpIngredients.Controls.Add(this.button4);
            this.grpIngredients.Controls.Add(this.btnOK);
            this.grpIngredients.Controls.Add(this.btnRemove);
            this.grpIngredients.Controls.Add(this.btnEdit);
            this.grpIngredients.Controls.Add(this.btnAddIngredient);
            this.grpIngredients.Controls.Add(this.txtAddIngredient);
            this.grpIngredients.Controls.Add(this.lstIngredients);
            this.grpIngredients.Location = new System.Drawing.Point(3, 30);
            this.grpIngredients.Name = "grpIngredients";
            this.grpIngredients.Size = new System.Drawing.Size(388, 316);
            this.grpIngredients.TabIndex = 1;
            this.grpIngredients.TabStop = false;
            this.grpIngredients.Text = "Ingredient";
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(306, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(306, 241);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(306, 75);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(306, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(306, 16);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnAddIngredient.TabIndex = 2;
            this.btnAddIngredient.Text = "Add";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // txtAddIngredient
            // 
            this.txtAddIngredient.Location = new System.Drawing.Point(6, 19);
            this.txtAddIngredient.Name = "txtAddIngredient";
            this.txtAddIngredient.Size = new System.Drawing.Size(294, 20);
            this.txtAddIngredient.TabIndex = 1;
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(7, 46);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(293, 264);
            this.lstIngredients.TabIndex = 0;
            // 
            // lblNumOfIngredients
            // 
            this.lblNumOfIngredients.AutoSize = true;
            this.lblNumOfIngredients.Location = new System.Drawing.Point(349, 13);
            this.lblNumOfIngredients.Name = "lblNumOfIngredients";
            this.lblNumOfIngredients.Size = new System.Drawing.Size(13, 13);
            this.lblNumOfIngredients.TabIndex = 2;
            this.lblNumOfIngredients.Text = "0";
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 347);
            this.Controls.Add(this.lblNumOfIngredients);
            this.Controls.Add(this.grpIngredients);
            this.Controls.Add(this.lblNumOfIngredientsText);
            this.Name = "FormIngredients";
            this.Text = "FormIngredients";
            this.grpIngredients.ResumeLayout(false);
            this.grpIngredients.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOfIngredientsText;
        private System.Windows.Forms.GroupBox grpIngredients;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.Label lblNumOfIngredients;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.TextBox txtAddIngredient;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnRemove;
    }
}