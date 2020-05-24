namespace RawForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.dataGridViewSale = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatagoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VarientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Variants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Controls.Add(this.txtCurrentStock);
            this.panel1.Controls.Add(this.lblCurrentStock);
            this.panel1.Controls.Add(this.lblQuantity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 87);
            this.panel1.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(718, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(194, 87);
            this.lblDate.TabIndex = 31;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduct
            // 
            this.lblProduct.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(364, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(220, 41);
            this.lblProduct.TabIndex = 31;
            this.lblProduct.Text = "Bill Preview";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProduct.Click += new System.EventHandler(this.lblProduct_Click);
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.BackColor = System.Drawing.SystemColors.Control;
            this.txtCurrentStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCurrentStock.ForeColor = System.Drawing.Color.Green;
            this.txtCurrentStock.Location = new System.Drawing.Point(152, 60);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.ReadOnly = true;
            this.txtCurrentStock.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentStock.TabIndex = 33;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStock.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCurrentStock.Location = new System.Drawing.Point(12, 58);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(119, 23);
            this.lblCurrentStock.TabIndex = 32;
            this.lblCurrentStock.Text = "Customer Name";
            this.lblCurrentStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(48, 32);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(83, 23);
            this.lblQuantity.TabIndex = 32;
            this.lblQuantity.Text = "BillNo : ";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewSale
            // 
            this.dataGridViewSale.AllowUserToAddRows = false;
            this.dataGridViewSale.AllowUserToDeleteRows = false;
            this.dataGridViewSale.AllowUserToResizeColumns = false;
            this.dataGridViewSale.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSale.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.CatagoryID,
            this.TypeID,
            this.SubTypeID,
            this.VarientID,
            this.UnitID,
            this.PriceID,
            this.StockID,
            this.SerialNo,
            this.ProductType,
            this.SubType,
            this.Variants,
            this.Description,
            this.Quantity,
            this.UnitName,
            this.MRP,
            this.SalesPrice,
            this.Total,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSale.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSale.Location = new System.Drawing.Point(0, 87);
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSale.Size = new System.Drawing.Size(912, 467);
            this.dataGridViewSale.TabIndex = 29;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            this.ProductID.Width = 89;
            // 
            // CatagoryID
            // 
            this.CatagoryID.DataPropertyName = "CatagoryID";
            this.CatagoryID.HeaderText = "CatagoryID";
            this.CatagoryID.Name = "CatagoryID";
            this.CatagoryID.Visible = false;
            this.CatagoryID.Width = 99;
            // 
            // TypeID
            // 
            this.TypeID.DataPropertyName = "TypeID";
            this.TypeID.HeaderText = "TypeID";
            this.TypeID.Name = "TypeID";
            this.TypeID.Visible = false;
            this.TypeID.Width = 74;
            // 
            // SubTypeID
            // 
            this.SubTypeID.DataPropertyName = "SubTypeID";
            this.SubTypeID.HeaderText = "SubTypeID";
            this.SubTypeID.Name = "SubTypeID";
            this.SubTypeID.Visible = false;
            this.SubTypeID.Width = 96;
            // 
            // VarientID
            // 
            this.VarientID.DataPropertyName = "VarientID";
            this.VarientID.HeaderText = "VarientID";
            this.VarientID.Name = "VarientID";
            this.VarientID.Visible = false;
            this.VarientID.Width = 87;
            // 
            // UnitID
            // 
            this.UnitID.DataPropertyName = "UnitID";
            this.UnitID.HeaderText = "UnitID";
            this.UnitID.Name = "UnitID";
            this.UnitID.Visible = false;
            this.UnitID.Width = 68;
            // 
            // PriceID
            // 
            this.PriceID.DataPropertyName = "PriceID";
            this.PriceID.HeaderText = "PriceID";
            this.PriceID.Name = "PriceID";
            this.PriceID.Visible = false;
            this.PriceID.Width = 74;
            // 
            // StockID
            // 
            this.StockID.DataPropertyName = "StockID";
            this.StockID.HeaderText = "StockID";
            this.StockID.Name = "StockID";
            this.StockID.Visible = false;
            this.StockID.Width = 78;
            // 
            // SerialNo
            // 
            this.SerialNo.HeaderText = "SL No";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Width = 50;
            // 
            // ProductType
            // 
            this.ProductType.DataPropertyName = "TypeName";
            this.ProductType.HeaderText = "Type";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 60;
            // 
            // SubType
            // 
            this.SubType.DataPropertyName = "SubTypeName";
            this.SubType.HeaderText = "Sub-Type";
            this.SubType.Name = "SubType";
            this.SubType.ReadOnly = true;
            this.SubType.Width = 87;
            // 
            // Variants
            // 
            this.Variants.DataPropertyName = "VarientName";
            this.Variants.HeaderText = "Variety";
            this.Variants.Name = "Variants";
            this.Variants.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 92;
            // 
            // UnitName
            // 
            this.UnitName.DataPropertyName = "UnitName";
            this.UnitName.HeaderText = "UnitName";
            this.UnitName.Name = "UnitName";
            this.UnitName.ReadOnly = true;
            // 
            // MRP
            // 
            this.MRP.DataPropertyName = "MRP";
            this.MRP.HeaderText = "MRP";
            this.MRP.Name = "MRP";
            this.MRP.ReadOnly = true;
            this.MRP.Width = 120;
            // 
            // SalesPrice
            // 
            this.SalesPrice.DataPropertyName = "SalesPrice";
            this.SalesPrice.HeaderText = "Sales Price";
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.ReadOnly = true;
            this.SalesPrice.Width = 120;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.Width = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOk);
            this.panel2.Controls.Add(this.btnCancle);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 56);
            this.panel2.TabIndex = 30;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(185, 12);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(193, 37);
            this.btnOk.TabIndex = 30;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Location = new System.Drawing.Point(623, 12);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(193, 37);
            this.btnCancle.TabIndex = 31;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(405, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(193, 37);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.ForeColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(125, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewSale);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Salepreview";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.DataGridView dataGridViewSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatagoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variants;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox textBox1;
    }
}