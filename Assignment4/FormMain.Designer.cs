namespace Assignment4
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtNameOfRecepie = new System.Windows.Forms.TextBox();
            this.lblNameOfRecepie = new System.Windows.Forms.Label();
            this.btnAddRecepie = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNoOfIngredients = new System.Windows.Forms.Label();
            this.lblCategoryText = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstRecepies = new System.Windows.Forms.ListBox();
            this.btnEditRecepie = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnAddIngredients);
            this.groupBox1.Controls.Add(this.cboxCategory);
            this.groupBox1.Controls.Add(this.lblCategory);
            this.groupBox1.Controls.Add(this.txtNameOfRecepie);
            this.groupBox1.Controls.Add(this.lblNameOfRecepie);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "grpAddRecepie";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 78);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(368, 258);
            this.txtDescription.TabIndex = 5;
            // 
            // btnAddIngredients
            // 
            this.btnAddIngredients.Location = new System.Drawing.Point(235, 41);
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.Size = new System.Drawing.Size(116, 23);
            this.btnAddIngredients.TabIndex = 4;
            this.btnAddIngredients.Text = "Add ingredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // cboxCategory
            // 
            this.cboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(98, 44);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(121, 21);
            this.cboxCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 46);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // txtNameOfRecepie
            // 
            this.txtNameOfRecepie.Location = new System.Drawing.Point(98, 17);
            this.txtNameOfRecepie.Name = "txtNameOfRecepie";
            this.txtNameOfRecepie.Size = new System.Drawing.Size(253, 20);
            this.txtNameOfRecepie.TabIndex = 1;
            // 
            // lblNameOfRecepie
            // 
            this.lblNameOfRecepie.AutoSize = true;
            this.lblNameOfRecepie.Location = new System.Drawing.Point(7, 20);
            this.lblNameOfRecepie.Name = "lblNameOfRecepie";
            this.lblNameOfRecepie.Size = new System.Drawing.Size(85, 13);
            this.lblNameOfRecepie.TabIndex = 0;
            this.lblNameOfRecepie.Text = "Name of recepie";
            // 
            // btnAddRecepie
            // 
            this.btnAddRecepie.Location = new System.Drawing.Point(23, 362);
            this.btnAddRecepie.Name = "btnAddRecepie";
            this.btnAddRecepie.Size = new System.Drawing.Size(364, 23);
            this.btnAddRecepie.TabIndex = 1;
            this.btnAddRecepie.Text = "Add Recepie";
            this.btnAddRecepie.UseVisualStyleBackColor = true;
            this.btnAddRecepie.Click += new System.EventHandler(this.btnAddRecepie_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(399, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // lblNoOfIngredients
            // 
            this.lblNoOfIngredients.Location = new System.Drawing.Point(545, 33);
            this.lblNoOfIngredients.Name = "lblNoOfIngredients";
            this.lblNoOfIngredients.Size = new System.Drawing.Size(82, 32);
            this.lblNoOfIngredients.TabIndex = 8;
            this.lblNoOfIngredients.Text = "No. Of ingredients";
            // 
            // lblCategoryText
            // 
            this.lblCategoryText.AutoSize = true;
            this.lblCategoryText.Location = new System.Drawing.Point(633, 49);
            this.lblCategoryText.Name = "lblCategoryText";
            this.lblCategoryText.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryText.TabIndex = 9;
            this.lblCategoryText.Text = "Category";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(785, 49);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            // 
            // lstRecepies
            // 
            this.lstRecepies.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecepies.FormattingEnabled = true;
            this.lstRecepies.ItemHeight = 14;
            this.lstRecepies.Location = new System.Drawing.Point(399, 65);
            this.lstRecepies.Name = "lstRecepies";
            this.lstRecepies.Size = new System.Drawing.Size(446, 284);
            this.lstRecepies.TabIndex = 11;
            this.lstRecepies.SelectedIndexChanged += new System.EventHandler(this.lstRecepies_SelectedIndexChanged);
            // 
            // btnEditRecepie
            // 
            this.btnEditRecepie.Location = new System.Drawing.Point(402, 361);
            this.btnEditRecepie.Name = "btnEditRecepie";
            this.btnEditRecepie.Size = new System.Drawing.Size(75, 23);
            this.btnEditRecepie.TabIndex = 12;
            this.btnEditRecepie.Text = "Edit";
            this.btnEditRecepie.UseVisualStyleBackColor = true;
            this.btnEditRecepie.Click += new System.EventHandler(this.btnEditRecepie_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(483, 361);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 400);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditRecepie);
            this.Controls.Add(this.lstRecepies);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategoryText);
            this.Controls.Add(this.lblNoOfIngredients);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddRecepie);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "Apu\'s Cock Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtNameOfRecepie;
        private System.Windows.Forms.Label lblNameOfRecepie;
        private System.Windows.Forms.Button btnAddRecepie;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNoOfIngredients;
        private System.Windows.Forms.Label lblCategoryText;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListBox lstRecepies;
        private System.Windows.Forms.Button btnEditRecepie;
        private System.Windows.Forms.Button btnDelete;
    }
}

