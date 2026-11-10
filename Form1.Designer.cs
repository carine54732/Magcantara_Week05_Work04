namespace Magcantara_Week5_Work4
{
    partial class Form1
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
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.grpManufactured = new System.Windows.Forms.GroupBox();
            this.rdoLocal = new System.Windows.Forms.RadioButton();
            this.rdoAbroad = new System.Windows.Forms.RadioButton();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.grpManufactured.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(68, 44);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(47, 13);
            this.lblBarcode.TabIndex = 0;
            this.lblBarcode.Text = "Barcode";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(68, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(145, 42);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(258, 20);
            this.txtBarcode.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(258, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(67, 102);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(145, 96);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(258, 44);
            this.txtDescription.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(69, 156);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            this.lblCategory.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Food",
            "Beverages",
            "Electronics",
            "Clothing",
            "Others"});
            this.cmbCategory.Location = new System.Drawing.Point(145, 153);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(258, 21);
            this.cmbCategory.TabIndex = 7;
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(70, 179);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(34, 13);
            this.lblOrigin.TabIndex = 8;
            this.lblOrigin.Text = "Origin";
            // 
            // grpManufactured
            // 
            this.grpManufactured.Controls.Add(this.rdoLocal);
            this.grpManufactured.Controls.Add(this.rdoAbroad);
            this.grpManufactured.Location = new System.Drawing.Point(145, 180);
            this.grpManufactured.Name = "grpManufactured";
            this.grpManufactured.Size = new System.Drawing.Size(190, 48);
            this.grpManufactured.TabIndex = 9;
            this.grpManufactured.TabStop = false;
            this.grpManufactured.Text = "Manufactured";
            // 
            // rdoLocal
            // 
            this.rdoLocal.AutoSize = true;
            this.rdoLocal.Checked = true;
            this.rdoLocal.Location = new System.Drawing.Point(18, 25);
            this.rdoLocal.Name = "rdoLocal";
            this.rdoLocal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdoLocal.Size = new System.Drawing.Size(51, 17);
            this.rdoLocal.TabIndex = 10;
            this.rdoLocal.TabStop = true;
            this.rdoLocal.Text = "Local";
            this.rdoLocal.UseVisualStyleBackColor = true;
            // 
            // rdoAbroad
            // 
            this.rdoAbroad.AutoSize = true;
            this.rdoAbroad.Location = new System.Drawing.Point(99, 25);
            this.rdoAbroad.Name = "rdoAbroad";
            this.rdoAbroad.Size = new System.Drawing.Size(59, 17);
            this.rdoAbroad.TabIndex = 11;
            this.rdoAbroad.Text = "Abroad";
            this.rdoAbroad.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(67, 280);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 12;
            this.lblCost.Text = "Cost";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(66, 246);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(145, 246);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 14;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(70, 296);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 15;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(197, 280);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(200, 296);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 17;
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Location = new System.Drawing.Point(326, 280);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(60, 13);
            this.lblMarkup.TabIndex = 18;
            this.lblMarkup.Text = "Markup (%)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(69, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(172, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(273, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtMarkup
            // 
            this.txtMarkup.Location = new System.Drawing.Point(329, 296);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.ReadOnly = true;
            this.txtMarkup.Size = new System.Drawing.Size(100, 20);
            this.txtMarkup.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 530);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtMarkup);
            this.Controls.Add(this.lblMarkup);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.grpManufactured);
            this.Controls.Add(this.lblOrigin);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblBarcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpManufactured.ResumeLayout(false);
            this.grpManufactured.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.GroupBox grpManufactured;
        private System.Windows.Forms.RadioButton rdoLocal;
        private System.Windows.Forms.RadioButton rdoAbroad;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtMarkup;
    }
}

