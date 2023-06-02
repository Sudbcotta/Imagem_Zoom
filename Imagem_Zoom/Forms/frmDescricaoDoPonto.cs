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
    public partial class frmDescricaoDoPonto : Form
    {
        public frmDescricaoDoPonto()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // var user = (UserControlMarca)this.Owner; 
            //  var iddd = user.Id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
