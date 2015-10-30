using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using quotestest.Presenter;
using quotestest.View;
using System.Threading;

namespace quotestest
{
    public partial class MDIQuote : Form, IQuotesView
    {
        public MDIQuote()
        {
            InitializeComponent();
        }






        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            
            quotestest.View.Customer_Maintainence cm = new View.Customer_Maintainence();
            cm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            
            string successmessage;
            QuotesPresenter qp = new QuotesPresenter(this);
            successmessage = qp.getdetails();
            if (successmessage == "Valid")
            {
               
                pnlLogin.Visible = false;
                toolstrip.Enabled = true;
                dataGridView1.DataSource=  qp.getdbvalues();
            }

            else
            {
                MessageBox.Show("Invalid Member","Invalid Credentials",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtUsername.Focus();
                txtpwd.Text = string.Empty;

            }


        }

        string _UserID;
        public string UserID
        {
           
            get
            {
                return this.txtUsername.Text;
            }
            set
            {
                this._UserID = value;
            }
        }
         string _PassWord;
        public string PassWord
        {
           
            get
            {
                return this.txtpwd.Text;
            }
            set
            {
                this._PassWord =value ;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = string.Empty;
            txtpwd.Text = string.Empty;
        }
    }

      
    
}
