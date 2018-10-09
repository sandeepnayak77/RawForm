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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoginMessage = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(152)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.lblLoginMessage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 51);
            this.panel1.TabIndex = 0;
            // 
            // lblLoginMessage
            // 
            this.lblLoginMessage.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginMessage.ForeColor = System.Drawing.Color.White;
            this.lblLoginMessage.Location = new System.Drawing.Point(3, 4);
            this.lblLoginMessage.Name = "lblLoginMessage";
            this.lblLoginMessage.Size = new System.Drawing.Size(472, 42);
            this.lblLoginMessage.TabIndex = 1;
            this.lblLoginMessage.Text = "Product Entry";
            this.lblLoginMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.BackColor = System.Drawing.Color.White;
            this.cmbCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatagory.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbCatagory.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Location = new System.Drawing.Point(106, 78);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(215, 26);
            this.cmbCatagory.TabIndex = 1;
            this.cmbCatagory.SelectedIndexChanged += new System.EventHandler(this.cmbCatagory_SelectedIndexChanged);
            // 
            // lblCatagory
            // 
            this.lblCatagory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(0, 80);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(100, 23);
            this.lblCatagory.TabIndex = 2;
            this.lblCatagory.Text = "Catagories";
            this.lblCatagory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCatagory
            // 
            this.btnCatagory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCatagory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatagory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatagory.ForeColor = System.Drawing.Color.White;
            this.btnCatagory.Location = new System.Drawing.Point(340, 78);
            this.btnCatagory.Name = "btnCatagory";
            this.btnCatagory.Size = new System.Drawing.Size(123, 26);
            this.btnCatagory.TabIndex = 3;
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
            this.cmbUnit.Location = new System.Drawing.Point(105, 130);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(215, 26);
            this.cmbUnit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Units";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUnit
            // 
            this.btnUnit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Location = new System.Drawing.Point(339, 130);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(123, 26);
            this.btnUnit.TabIndex = 3;
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
            this.btnTypeAdd.Location = new System.Drawing.Point(339, 172);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(123, 26);
            this.btnTypeAdd.TabIndex = 6;
            this.btnTypeAdd.Text = "Add New";
            this.btnTypeAdd.UseVisualStyleBackColor = false;
            this.btnTypeAdd.Click += new System.EventHandler(this.btnTypeAdd_Click);
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(-1, 174);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 23);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbProductType
            // 
            this.cmbProductType.BackColor = System.Drawing.Color.White;
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductType.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbProductType.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(105, 172);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(215, 26);
            this.cmbProductType.TabIndex = 4;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoEllipsis = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(82, 400);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(270, 18);
            this.lblError.TabIndex = 21;
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
            this.cmbSubType.Location = new System.Drawing.Point(105, 217);
            this.cmbSubType.Name = "cmbSubType";
            this.cmbSubType.Size = new System.Drawing.Size(215, 26);
            this.cmbSubType.TabIndex = 4;
            this.cmbSubType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // lblSubType
            // 
            this.lblSubType.AutoEllipsis = true;
            this.lblSubType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubType.Location = new System.Drawing.Point(-1, 219);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(100, 23);
            this.lblSubType.TabIndex = 5;
            this.lblSubType.Text = "Sub-Type";
            this.lblSubType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSubTypeAdd
            // 
            this.btnSubTypeAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubTypeAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubTypeAdd.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubTypeAdd.ForeColor = System.Drawing.Color.White;
            this.btnSubTypeAdd.Location = new System.Drawing.Point(339, 217);
            this.btnSubTypeAdd.Name = "btnSubTypeAdd";
            this.btnSubTypeAdd.Size = new System.Drawing.Size(123, 26);
            this.btnSubTypeAdd.TabIndex = 6;
            this.btnSubTypeAdd.Text = "Add New";
            this.btnSubTypeAdd.UseVisualStyleBackColor = false;
            this.btnSubTypeAdd.Click += new System.EventHandler(this.btnSubTypeAdd_Click);
            // 
            // ProductEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 476);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSubTypeAdd);
            this.Controls.Add(this.btnTypeAdd);
            this.Controls.Add(this.lblSubType);
            this.Controls.Add(this.cmbSubType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.btnUnit);
            this.Controls.Add(this.btnCatagory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.cmbCatagory);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductEntry";
            this.Load += new System.EventHandler(this.ProductEntry_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoginMessage;
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
    }
}