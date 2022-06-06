using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectBorrow
{
    public partial class MainFormSystem : Form
    {
        AddCustomer20 addcustomer20;
        AddCustomer30 addcustomer30;
        Disply disply;
        AboutUs aboutus;
        Income income;
        Out_Money outcome;
        Search search;
        public MainFormSystem()
        {
            InitializeComponent();
           

        }

        private void MainFormSystem_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addcustomer20 != null)
                addcustomer20.WindowState = FormWindowState.Maximized;
            else
            {
                addcustomer20 = new AddCustomer20();
                addcustomer20.MdiParent = this;
                addcustomer20.Show();
                addcustomer20.WindowState.Equals(this.WindowState);
            }
            addcustomer20.FormClosed += (s, e1) => { addcustomer20 = null; };
            
        }

        private void system30ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (addcustomer20 != null)
                addcustomer20.WindowState = FormWindowState.Maximized;
            else
            {
                addcustomer30 = new AddCustomer30();
                addcustomer30.MdiParent = this;
                addcustomer30.Show();
            }
            addcustomer30.FormClosed += (s, e1) => { addcustomer30 = null; };
            
        }

        private void displayCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addcustomer20 != null)
                addcustomer20.WindowState = FormWindowState.Maximized;
            else
            {
                disply = new Disply();
                disply.MdiParent = this;
                disply.Show();
            }
            disply.FormClosed += (s, e1) => { disply = null; };
            
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addcustomer20 != null)
                addcustomer20.WindowState = FormWindowState.Maximized;
            else
            {
                aboutus = new AboutUs();
                aboutus.MdiParent = this;
                aboutus.Show();
            }
            aboutus.FormClosed += (s, e1) => { aboutus = null; };
            
        }

        private void addCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (addcustomer20 != null)
                addcustomer20.WindowState = FormWindowState.Maximized;
            else
            {
                income = new Income();
                income.MdiParent = this;
                income.Show();
            }
            income.FormClosed += (s, e1) => { income = null; };
            
        }

        private void outComeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addcustomer20 != null)
                addcustomer20.WindowState = FormWindowState.Maximized;
            else
            {
                outcome = new Out_Money();
                outcome.MdiParent = this;
                outcome.Show();
            }
            outcome.FormClosed += (s, e1) => { outcome = null; };
            
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addcustomer20 != null)
                addcustomer20.WindowState = FormWindowState.Maximized;
            else
            {
                search = new Search();
                search.MdiParent = this;
                search.Show();
            }
            search.FormClosed += (s, e1) => { search = null; };
           
        }
    }
}
