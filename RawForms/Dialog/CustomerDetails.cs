﻿using RawForms.AppUtil;
using RawForms.Entities;
using RawForms.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RawForms.Dialog
{
    public partial class CustomerDetails : Form
    {
        CustomerBillData custBillInfoData = new CustomerBillData();
        string billnumber = "";
        public CustomerDetails()
        {
            InitializeComponent();
        }
        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            lblBillNoView.Text = billnumber;
        }

        private void lblLoginMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text.Trim() == "" || ControlValidation.IsReserveWord(txtCustomerName.Text.Trim().ToLower()))
            {
                lblError.Text = "Please Enter Customer Name";
                lblError.ForeColor = Color.Red;
            }
            else
            {
                var custDetails = new CustomerInfoDetails();
                if(txtAddress.Text=="" || ControlValidation.IsReserveWord(txtAddress.Text.Trim().ToLower()))
                {
                    custDetails.custAddress = "XXXX";
                }
                custDetails.custName = txtCustomerName.Text;
                this.Hide();
                CustomerBillForm cust = new CustomerBillForm();
                cust.showBill(custBillInfoData);
                cust.ShowDialog(this);
                this.Close();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void prodBillInfoPass(CustomerBillData custBillData, string billno)
        {
            
            custBillInfoData = custBillData;
            billnumber = billno;

        }

     
    }
}
