using Imagem_Zoom;
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
        /// <summary>
        /// Identifica e altera o valor da coordenada do ponto ao largar o botão do mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserControlMarca_MouseUp(object sender, MouseEventArgs e)
        {
            frmMain? f = Application.OpenForms["frmMain"] as frmMain;
            if (f != null)
            {
                int x = e.X + this.Location.X;
                int y = e.Y + this.Location.Y;
                this.RelativeLocation = f.arrastaPonto(x, y);
                
            }
        }
        
        private void tsmApagar_Click(object sender, EventArgs e)
        {   
            frmMain? f = Application.OpenForms["frmMain"] as frmMain;
            

        }
    }
}
