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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void Search_Load(object sender, EventArgs e)
        {
            
        }
  

            private void button5_Click(object sender, EventArgs e)
        {
            labels1.Visible = true;
            labels2.Visible = true;
            texts1.Visible = true;
            btn_s_s.Visible = true;
        }
    }
}
