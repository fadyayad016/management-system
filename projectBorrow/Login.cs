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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


            //username_text_box.Left = (this.Width - username_text_box.Width) / 2;
            //username_text_box.Top = (this.Height - username_text_box.Top) / 2;
            // TopMost = true;

            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // no larger than screen size
            //this.MaximumSize = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, (int)System.Windows.SystemParameters.PrimaryScreenHeight);

            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;




        }

       
    }
}
