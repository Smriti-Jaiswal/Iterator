using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsIterator
{
    public partial class frmCustomer : Form
    {
        private clsIterator objIterator = new clsIterator();
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            objIterator.FillObjects();
            displayUI(objIterator.getFirst());
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                displayUI(objIterator.Prev());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void displayUI(clsDay objDay)
        {
           
            txtCustomerCode.Text = objDay.Code;
            txtDay.Text = objDay.Day;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                displayUI(objIterator.Next());
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }   
        private void lblCustomerCode_Click(object sender, EventArgs e)
        {

        }
    }
}