namespace RawForms
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbVariety = new System.Windows.Forms.ComboBox();
            this.lblVariety = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.cmbCatagory = new System.Windows.Forms.ComboBox();
            this.cmbSubType = new System.Windows.Forms.ComboBox();
            this.lblSubType = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(248, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(605, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(14, 13);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbVariety);
            this.panel2.Controls.Add(this.lblVariety);
            this.panel2.Controls.Add(this.lblCatagory);
            this.panel2.Controls.Add(this.cmbCatagory);
            this.panel2.Controls.Add(this.cmbSubType);
            this.panel2.Controls.Add(this.lblSubType);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.cmbProductType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 379);
            this.panel2.TabIndex = 4;
            // 
            // cmbVariety
            // 
            this.cmbVariety.BackColor = System.Drawing.Color.White;
            this.cmbVariety.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVariety.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbVariety.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbVariety.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbVariety.FormattingEnabled = true;
            this.cmbVariety.Location = new System.Drawing.Point(4, 272);
            this.cmbVariety.Name = "cmbVariety";
            this.cmbVariety.Size = new System.Drawing.Size(215, 26);
            this.cmbVariety.TabIndex = 24;
            // 
            // lblVariety
            // 
            this.lblVariety.AutoEllipsis = true;
            this.lblVariety.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariety.Location = new System.Drawing.Point(4, 242);
            this.lblVariety.Name = "lblVariety";
            this.lblVariety.Size = new System.Drawing.Size(212, 23);
            this.lblVariety.TabIndex = 28;
            this.lblVariety.Text = "Variety";
            this.lblVariety.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCatagory
            // 
            this.lblCatagory.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatagory.Location = new System.Drawing.Point(3, 72);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(212, 23);
            this.lblCatagory.TabIndex = 25;
            this.lblCatagory.Text = "Catagories";
            this.lblCatagory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCatagory
            // 
            this.cmbCatagory.BackColor = System.Drawing.Color.White;
            this.cmbCatagory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatagory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCatagory.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbCatagory.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbCatagory.FormattingEnabled = true;
            this.cmbCatagory.Location = new System.Drawing.Point(3, 98);
            this.cmbCatagory.Name = "cmbCatagory";
            this.cmbCatagory.Size = new System.Drawing.Size(215, 26);
            this.cmbCatagory.TabIndex = 21;
            // 
            // cmbSubType
            // 
            this.cmbSubType.BackColor = System.Drawing.Color.White;
            this.cmbSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSubType.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbSubType.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbSubType.FormattingEnabled = true;
            this.cmbSubType.Location = new System.Drawing.Point(3, 208);
            this.cmbSubType.Name = "cmbSubType";
            this.cmbSubType.Size = new System.Drawing.Size(215, 26);
            this.cmbSubType.TabIndex = 23;
            // 
            // lblSubType
            // 
            this.lblSubType.AutoEllipsis = true;
            this.lblSubType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubType.Location = new System.Drawing.Point(4, 182);
            this.lblSubType.Name = "lblSubType";
            this.lblSubType.Size = new System.Drawing.Size(212, 23);
            this.lblSubType.TabIndex = 27;
            this.lblSubType.Text = "Sub-Type";
            this.lblSubType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(3, 127);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(212, 23);
            this.lblType.TabIndex = 26;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProductType
            // 
            this.cmbProductType.BackColor = System.Drawing.Color.White;
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductType.Font = new System.Drawing.Font("Verdana", 12F);
            this.cmbProductType.ForeColor = System.Drawing.Color.DarkGray;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(4, 153);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(215, 26);
            this.cmbProductType.TabIndex = 22;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 379);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbVariety;
        private System.Windows.Forms.Label lblVariety;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.ComboBox cmbCatagory;
        private System.Windows.Forms.ComboBox cmbSubType;
        private System.Windows.Forms.Label lblSubType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbProductType;
    }
}