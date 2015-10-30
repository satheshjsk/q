using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quotestest.View
{
    public partial class Customer_Maintainence : Form
    {
        public Customer_Maintainence()
        {
            InitializeComponent();
        }

        private void grpboxDatagrd_Enter(object sender, EventArgs e)
        {

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
           //  int height = Screen.PrimaryScreen.Bounds.Height;
           // int width = Screen.PrimaryScreen.Bounds.Width;
           // this.WindowState = FormWindowState.Maximized;
           //this.datagrd.Size = Screen.PrimaryScreen.WorkingArea.Size;
           //datagrd.Width = Screen.PrimaryScreen.Bounds.Width;
           Rectangle screen = Screen.PrimaryScreen.WorkingArea;
           int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
           int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
           this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
           datagrd.Size = new Size(w, h);
        }
    }
}
