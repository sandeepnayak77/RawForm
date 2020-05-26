namespace RawForms
{
    partial class ProductEntry
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
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.btnCatagory = new System.Windows.Forms.Button();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUnit = new System.Windows.Forms.Button();
            this.btnTypeAdd = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cmbSubType = new System.Windows.Forms.ComboBox();
            this.lblSubType = new System.Windows.Forms.Label();
            this.btnSubTypeAdd = new System.Windows.Forms.Button();
            this.cmbVariety = new System.Windows.Forms.ComboBox();
            this.lblVariety = new System.Windows.Forms.Label();
            this.btnVariety = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCostPrice = new System.Windows.Forms.TextBox();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.txtSalesPrice = new System.Windows.Forms.TextBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.lblMRP = new System.Windows.Forms.Label();
            this.lblSalesPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.BackColor = System.Drawing.Color.White;
            this.cmbCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatagory.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbCatagory.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Location = new System.Drawing.Point(301, 18);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(295, 26);
            this.cmbCatagory.TabIndex = 1;
            this.cmbCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
            // 
            // lblCatagory
            // 
            this.lblCatagory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(195, 20);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(100, 23);
            this.lblCatagory.TabIndex = 17;
            this.lblCatagory.Text = "Catagories";
            this.lblCatagory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCatagory
            // 
            this.btnCatagory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCatagory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatagory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagory.ForeColor = System.Drawing.Color.White;
            this.btnCatagory.Location = new System.Drawing.Point(666, 17);
            this.btnCatagory.Name = "btnCatagory";
            this.btnCatagory.Size = new System.Drawing.Size(123, 26);
            this.btnCatagory.TabIndex = 2;
            this.btnCatagory.Text = "Add New";
            this.btnCatagory.UseVisualStyleBackColor = false;
            this.btnCatagory.Click += new System.EventHandler(this.btnCatagory_Click);
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.White;
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnit.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbUnit.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(302, 225);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(295, 26);
            this.cmbUnit.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Units";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUnit
            // 
            this.btnUnit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Location = new System.Drawing.Point(667, 224);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(123, 26);
            this.btnUnit.TabIndex = 10;
            this.btnUnit.Text = "Add New";
            this.btnUnit.UseVisualStyleBackColor = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTypeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnTypeAdd.Location = new System.Drawing.Point(666, 69);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(123, 26);
            this.btnTypeAdd.TabIndex = 4;
            this.btnTypeAdd.Text = "Add New";
            this.btnTypeAdd.UseVisualStyleBackColor = false;
            this.btnTypeAdd.Click += new System.EventHandler(this.btnTypeAdd_Click);
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(195, 72);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 18;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProductType
            // 
            this.cmbProductType.BackColor = System.Drawing.Color.White;
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductType.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbProductType.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(301, 70);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(295, 26);
            this.cmbProductType.TabIndex = 3;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoEllipsis = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(303, 489);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(293, 18);
            this.lblError.TabIndex = 26;
            this.lblError.Text = "Error";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSubType
            // 
            this.cmbSubType.BackColor = System.Drawing.Color.White;
            this.cmbSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubType.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbSubType.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbSubType.FormattingEnabled = true;
            this.cmbSubType.Location = new System.Drawing.Point(301, 120);
            this.cmbSubType.Name = "cmbSubType";
            this.cmbSubType.Size = new System.Drawing.Size(295, 26);
            this.cmbSubType.TabIndex = 5;
            this.cmbSubType.SelectedIndexChanged += new System.EventHandler(this.cmbSubType_SelectedIndexChanged);
            // 
            // lblSubType
            // 
            this.lblSubType.AutoEllipsis = true;
            this.lblSubType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubType.Location = new System.Drawing.Point(195, 122);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(100, 23);
            this.lblSubType.TabIndex = 19;
            this.lblSubType.Text = "Sub-Type";
            this.lblSubType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSubTypeAdd
            // 
            this.btnSubTypeAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubTypeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTypeAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnSubTypeAdd.Location = new System.Drawing.Point(666, 119);
            this.btnSubTypeAdd.Name = "btnSubTypeAdd";
            this.btnSubTypeAdd.Size = new System.Drawing.Size(123, 26);
            this.btnSubTypeAdd.TabIndex = 6;
            this.btnSubTypeAdd.Text = "Add New";
            this.btnSubTypeAdd.UseVisualStyleBackColor = false;
            this.btnSubTypeAdd.Click += new System.EventHandler(this.btnSubTypeAdd_Click);
            // 
            // cmbVariety
            // 
            this.cmbVariety.BackColor = System.Drawing.Color.White;
            this.cmbVariety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariety.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVariety.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbVariety.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbVariety.FormattingEnabled = true;
            this.cmbVariety.Location = new System.Drawing.Point(302, 172);
            this.cmbVariety.Name = "cmbVariety";
            this.cmbVariety.Size = new System.Drawing.Size(295, 26);
            this.cmbVariety.TabIndex = 7;
            this.cmbVariety.SelectedIndexChanged += new System.EventHandler(this.cmbVariety_SelectedIndexChanged);
            // 
            // lblVariety
            // 
            this.lblVariety.AutoEllipsis = true;
            this.lblVariety.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariety.Location = new System.Drawing.Point(196, 174);
            this.lblVariety.Name = "lblVariety";
            this.lblVariety.Size = new System.Drawing.Size(100, 23);
            this.lblVariety.TabIndex = 20;
            this.lblVariety.Text = "Variety";
            this.lblVariety.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVariety
            // 
            this.btnVariety.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVariety.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVariety.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVariety.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVariety.ForeColor = System.Drawing.Color.White;
            this.btnVariety.Location = new System.Drawing.Point(667, 171);
            this.btnVariety.Name = "btnVariety";
            this.btnVariety.Size = new System.Drawing.Size(123, 26);
            this.btnVariety.TabIndex = 8;
            this.btnVariety.Text = "Add New";
            this.btnVariety.UseVisualStyleBackColor = false;
            this.btnVariety.Click += new System.EventHandler(this.btnVariety_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(196, 300);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescription.Location = new System.Drawing.Point(302, 279);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(294, 61);
            this.txtDescription.TabIndex = 11;
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCostPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCostPrice.Location = new System.Drawing.Point(301, 360);
            this.txtCostPrice.MaxLength = 10;
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.Size = new System.Drawing.Size(294, 27);
            this.txtCostPrice.TabIndex = 12;
            this.txtCostPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostPrice_KeyPress);
            // 
            // txtMRP
            // 
            this.txtMRP.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtMRP.ForeColor = System.Drawing.Color.DarkGray;
            this.txtMRP.Location = new System.Drawing.Point(302, 412);
            this.txtMRP.MaxLength = 10;
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(294, 27);
            this.txtMRP.TabIndex = 13;
            this.txtMRP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMRP_KeyPress);
            // 
            // txtSalesPrice
            // 
            this.txtSalesPrice.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSalesPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSalesPrice.Location = new System.Drawing.Point(301, 459);
            this.txtSalesPrice.MaxLength = 10;
            this.txtSalesPrice.Name = "txtSalesPrice";
            this.txtSalesPrice.Size = new System.Drawing.Size(294, 27);
            this.txtSalesPrice.TabIndex = 14;
            this.txtSalesPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesPrice_KeyPress);
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoEllipsis = true;
            this.lblBuyPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.Location = new System.Drawing.Point(195, 362);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(100, 23);
            this.lblBuyPrice.TabIndex = 23;
            this.lblBuyPrice.Text = "Dealer Price";
            this.lblBuyPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMRP
            // 
            this.lblMRP.AutoEllipsis = true;
            this.lblMRP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRP.Location = new System.Drawing.Point(196, 416);
            this.lblMRP.Name = "lblMRP";
            this.lblMRP.Size = new System.Drawing.Size(100, 23);
            this.lblMRP.TabIndex = 24;
            this.lblMRP.Text = "MRP";
            this.lblMRP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesPrice
            // 
            this.lblSalesPrice.AutoEllipsis = true;
            this.lblSalesPrice.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesPrice.Location = new System.Drawing.Point(193, 461);
            this.lblSalesPrice.Name = "lblSalesPrice";
            this.lblSalesPrice.Size = new System.Drawing.Size(100, 23);
            this.lblSalesPrice.TabIndex = 25;
            this.lblSalesPrice.Text = "Selling Price";
            this.lblSalesPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(315, 512);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 26);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(466, 511);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 26);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ProductEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 610);
            this.Controls.Add(this.lblSalesPrice);
            this.Controls.Add(this.lblMRP);
            this.Controls.Add(this.lblBuyPrice);
            this.Controls.Add(this.txtSalesPrice);
            this.Controls.Add(this.txtMRP);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnVariety);
            this.Controls.Add(this.btnSubTypeAdd);
            this.Controls.Add(this.btnTypeAdd);
            this.Controls.Add(this.lblVariety);
            this.Controls.Add(this.cmbVariety);
            this.Controls.Add(this.lblSubType);
            this.Controls.Add(this.cmbSubType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUnit);
            this.Controls.Add(this.btnCatagory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.cmbCatagory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductEntry";
            this.Load += new System.EventHandler(this.ProductEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Button btnCatagory;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.Button btnTypeAdd;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ComboBox cmbSubType;
        private System.Windows.Forms.Label lblSubType;
        private System.Windows.Forms.Button btnSubTypeAdd;
        private System.Windows.Forms.ComboBox cmbVariety;
        private System.Windows.Forms.Label lblVariety;
        private System.Windows.Forms.Button btnVariety;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCostPrice;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.TextBox txtSalesPrice;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.Label lblMRP;
        private System.Windows.Forms.Label lblSalesPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}