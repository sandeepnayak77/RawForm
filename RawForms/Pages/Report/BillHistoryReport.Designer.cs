namespace RawForms.Pages.Report
{
    partial class BillHistoryReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillHistoryReport));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.dataGridViewBillHistory = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranctionTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TranctionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelSearch.SuspendLayout();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.btnClose);
            this.panelSearch.Controls.Add(this.dateTimePickerEnd);
            this.panelSearch.Controls.Add(this.dateTimePickerStart);
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.lblStartDate);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1083, 126);
            this.panelSearch.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(315, 35);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerEnd.TabIndex = 37;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(102, 36);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerStart.TabIndex = 36;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(478, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 26);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "End Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(13, 33);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 23);
            this.lblStartDate.TabIndex = 33;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.dataGridViewBillHistory);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(0, 126);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(1083, 438);
            this.panelGrid.TabIndex = 1;
            // 
            // dataGridViewBillHistory
            // 
            this.dataGridViewBillHistory.AllowUserToAddRows = false;
            this.dataGridViewBillHistory.AllowUserToDeleteRows = false;
            this.dataGridViewBillHistory.AllowUserToResizeColumns = false;
            this.dataGridViewBillHistory.AllowUserToResizeRows = false;
            this.dataGridViewBillHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewBillHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBillHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.BillTypeID,
            this.CustomerID,
            this.TranctionTypeID,
            this.SerialNo,
            this.TranctionType,
            this.BillType,
            this.BillNumber,
            this.CustName,
            this.MobileNo,
            this.Address,
            this.BillDate,
            this.BillTotalAmount,
            this.Discount,
            this.PaidAmount,
            this.BalanceAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBillHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBillHistory.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBillHistory.Name = "dataGridViewBillHistory";
            this.dataGridViewBillHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillHistory.Size = new System.Drawing.Size(1083, 438);
            this.dataGridViewBillHistory.TabIndex = 30;
            this.dataGridViewBillHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBillHistory_CellContentClick);
            this.dataGridViewBillHistory.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBillHistory_CellMouseLeave);
            this.dataGridViewBillHistory.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBillHistory_CellMouseMove);
            this.dataGridViewBillHistory.MouseLeave += new System.EventHandler(this.dataGridViewBillHistory_MouseLeave);
            this.dataGridViewBillHistory.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewBillHistory_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1058, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 38;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BillID
            // 
            this.BillID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillID.DataPropertyName = "BillID";
            this.BillID.Frozen = true;
            this.BillID.HeaderText = "BillID";
            this.BillID.Name = "BillID";
            this.BillID.Visible = false;
            this.BillID.Width = 63;
            // 
            // BillTypeID
            // 
            this.BillTypeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillTypeID.DataPropertyName = "BillTypeID";
            this.BillTypeID.Frozen = true;
            this.BillTypeID.HeaderText = "BillTypeID";
            this.BillTypeID.Name = "BillTypeID";
            this.BillTypeID.Visible = false;
            this.BillTypeID.Width = 91;
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.Frozen = true;
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = false;
            this.CustomerID.Width = 102;
            // 
            // TranctionTypeID
            // 
            this.TranctionTypeID.DataPropertyName = "TranctionTypeID";
            this.TranctionTypeID.Frozen = true;
            this.TranctionTypeID.HeaderText = "Tranction TypeID";
            this.TranctionTypeID.Name = "TranctionTypeID";
            this.TranctionTypeID.ReadOnly = true;
            this.TranctionTypeID.Visible = false;
            this.TranctionTypeID.Width = 131;
            // 
            // SerialNo
            // 
            this.SerialNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SerialNo.Frozen = true;
            this.SerialNo.HeaderText = "SL No";
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Width = 65;
            // 
            // TranctionType
            // 
            this.TranctionType.DataPropertyName = "TranctionTypeName";
            this.TranctionType.HeaderText = "Txn Type";
            this.TranctionType.MinimumWidth = 80;
            this.TranctionType.Name = "TranctionType";
            this.TranctionType.ReadOnly = true;
            this.TranctionType.Width = 85;
            // 
            // BillType
            // 
            this.BillType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillType.DataPropertyName = "BillType";
            this.BillType.HeaderText = "Bill Type";
            this.BillType.MinimumWidth = 70;
            this.BillType.Name = "BillType";
            this.BillType.ReadOnly = true;
            this.BillType.Width = 81;
            // 
            // BillNumber
            // 
            this.BillNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillNumber.DataPropertyName = "BillNumber";
            this.BillNumber.HeaderText = "BillNumber";
            this.BillNumber.MinimumWidth = 150;
            this.BillNumber.Name = "BillNumber";
            this.BillNumber.Width = 150;
            // 
            // CustName
            // 
            this.CustName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "Name";
            this.CustName.MinimumWidth = 120;
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Width = 120;
            // 
            // MobileNo
            // 
            this.MobileNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "Mobile No";
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.ReadOnly = true;
            this.MobileNo.Visible = false;
            this.MobileNo.Width = 87;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 120;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // BillDate
            // 
            this.BillDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "Bill Date";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            this.BillDate.Width = 80;
            // 
            // BillTotalAmount
            // 
            this.BillTotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BillTotalAmount.DataPropertyName = "BillTotalAmount";
            this.BillTotalAmount.HeaderText = "Tot Amt";
            this.BillTotalAmount.MinimumWidth = 100;
            this.BillTotalAmount.Name = "BillTotalAmount";
            this.BillTotalAmount.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 81;
            // 
            // PaidAmount
            // 
            this.PaidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PaidAmount.DataPropertyName = "PaidAmount";
            this.PaidAmount.HeaderText = "Paid Amt";
            this.PaidAmount.Name = "PaidAmount";
            this.PaidAmount.ReadOnly = true;
            this.PaidAmount.Width = 83;
            // 
            // BalanceAmount
            // 
            this.BalanceAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.BalanceAmount.DataPropertyName = "BalanceAmount";
            this.BalanceAmount.HeaderText = "Bal Amt";
            this.BalanceAmount.MinimumWidth = 100;
            this.BalanceAmount.Name = "BalanceAmount";
            this.BalanceAmount.ReadOnly = true;
            // 
            // BillHistoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 564);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillHistoryReport";
            this.Text = "BillHistoryReport";
            this.Load += new System.EventHandler(this.BillHistoryReport_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewBillHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranctionTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TranctionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BalanceAmount;
    }
}