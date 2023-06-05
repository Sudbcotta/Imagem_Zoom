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
        /// <summary>
        /// Exibe um formulário ao clicar com o botão esquerdo do mouse em um ponto e selecionar propriedades
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmPropriedades_Click(object sender, EventArgs e)
        {
            var form2 = new frmDescricaoDoPonto();
            form2.ShowDialog(this);

        }
    }
}
