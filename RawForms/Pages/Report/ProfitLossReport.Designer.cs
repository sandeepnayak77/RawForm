namespace RawForms.Pages.Report
{
    partial class ProfitLossReport
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
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewProfitLoss = new System.Windows.Forms.DataGridView();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OldCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinalCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfitPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfitLoss)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(319, 21);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerEnd.TabIndex = 42;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(106, 22);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(91, 20);
            this.dateTimePickerStart.TabIndex = 41;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(482, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 26);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "End Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(17, 19);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 23);
            this.lblStartDate.TabIndex = 38;
            this.lblStartDate.Text = "Start Date";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.lblStartDate);
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 87);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewProfitLoss);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1061, 433);
            this.panel2.TabIndex = 44;
            // 
            // dataGridViewProfitLoss
            // 
            this.dataGridViewProfitLoss.AllowUserToAddRows = false;
            this.dataGridViewProfitLoss.AllowUserToDeleteRows = false;
            this.dataGridViewProfitLoss.AllowUserToResizeColumns = false;
            this.dataGridViewProfitLoss.AllowUserToResizeRows = false;
            this.dataGridViewProfitLoss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProfitLoss.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProfitLoss.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProfitLoss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNo,
            this.ProductID,
            this.Description,
            this.OldStock,
            this.OldCP,
            this.NewStock,
            this.NewCP,
            this.FinalCP,
            this.SoldQty,
            this.AvgSellPrice,
            this.ProfitPerUnit,
            this.TotalProfit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProfitLoss.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProfitLoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProfitLoss.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProfitLoss.Name = "dataGridViewProfitLoss";
            this.dataGridViewProfitLoss.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProfitLoss.Size = new System.Drawing.Size(1061, 433);
            this.dataGridViewProfitLoss.TabIndex = 31;
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
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.Frozen = true;
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 93;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 120;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // OldStock
            // 
            this.OldStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OldStock.DataPropertyName = "OldStock";
            this.OldStock.HeaderText = "Old Stock";
            this.OldStock.Name = "OldStock";
            this.OldStock.ReadOnly = true;
            this.OldStock.Width = 87;
            // 
            // OldCP
            // 
            this.OldCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OldCP.DataPropertyName = "OldCP";
            this.OldCP.HeaderText = "Old CP";
            this.OldCP.Name = "OldCP";
            this.OldCP.ReadOnly = true;
            this.OldCP.Width = 71;
            // 
            // NewStock
            // 
            this.NewStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NewStock.DataPropertyName = "NewStock";
            this.NewStock.HeaderText = "New Stock";
            this.NewStock.MinimumWidth = 120;
            this.NewStock.Name = "NewStock";
            this.NewStock.ReadOnly = true;
            this.NewStock.Width = 120;
            // 
            // NewCP
            // 
            this.NewCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NewCP.DataPropertyName = "NewCP";
            this.NewCP.HeaderText = "New CP";
            this.NewCP.MinimumWidth = 100;
            this.NewCP.Name = "NewCP";
            this.NewCP.ReadOnly = true;
            // 
            // FinalCP
            // 
            this.FinalCP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FinalCP.DataPropertyName = "FinalCP";
            this.FinalCP.HeaderText = "Final CP";
            this.FinalCP.Name = "FinalCP";
            this.FinalCP.ReadOnly = true;
            this.FinalCP.Width = 78;
            // 
            // SoldQty
            // 
            this.SoldQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoldQty.DataPropertyName = "SoldQty";
            this.SoldQty.HeaderText = "Sold Qty";
            this.SoldQty.Name = "SoldQty";
            this.SoldQty.ReadOnly = true;
            this.SoldQty.Width = 81;
            // 
            // AvgSellPrice
            // 
            this.AvgSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AvgSellPrice.DataPropertyName = "AvgSellPrice";
            this.AvgSellPrice.HeaderText = "Avg Sell Price";
            this.AvgSellPrice.MinimumWidth = 100;
            this.AvgSellPrice.Name = "AvgSellPrice";
            this.AvgSellPrice.ReadOnly = true;
            this.AvgSellPrice.Width = 111;
            // 
            // ProfitPerUnit
            // 
            this.ProfitPerUnit.DataPropertyName = "ProfitPerUnit";
            this.ProfitPerUnit.HeaderText = "Profit/Unit";
            this.ProfitPerUnit.Name = "ProfitPerUnit";
            this.ProfitPerUnit.ReadOnly = true;
            this.ProfitPerUnit.Width = 89;
            // 
            // TotalProfit
            // 
            this.TotalProfit.DataPropertyName = "TotalProfit";
            this.TotalProfit.HeaderText = "Total Profit";
            this.TotalProfit.Name = "TotalProfit";
            this.TotalProfit.Width = 94;
            // 
            // ProfitLossReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfitLossReport";
            this.Text = "ProfitLossReport";
            this.Load += new System.EventHandler(this.ProfitLossReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfitLoss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewProfitLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn OldCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinalCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfitPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalProfit;
    }
}