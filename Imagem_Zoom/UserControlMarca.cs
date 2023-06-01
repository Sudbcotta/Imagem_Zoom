using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserControlMarca : UserControl
    {
        public int Id { get; set; }
        public Point RelativeLocation { get; set; }
        public UserControlMarca()
        {
            InitializeComponent();
            lblPonto.Width += -this.Width / 2;
            lblPonto.Height += -this.Height / 2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form2 = new Form2();
            //form2.Parent = this;
            form2.ShowDialog(this);
            
        }


    }
}
