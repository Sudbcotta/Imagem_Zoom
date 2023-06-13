using Imagem_Zoom;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserControlMarca : UserControl
    {
        public int Id { get; set; }
        public Point RelativeLocation { get; set; }
        public byte valorCor;
        public UserControlMarca()
        {
            InitializeComponent();

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
        /// <summary>
        /// Apaga um objeto da lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmApagar_Click(object sender, EventArgs e)
        {
            frmMain? f = Application.OpenForms["frmMain"] as frmMain;
            if (f != null)
            {
                f.apagarPonto(this);
            }
        }

        //private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();

        //    Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptAzul.png");
        //    if (myStream != null)
        //    {

        //        this.BackgroundImage = new Bitmap(myStream);
        //    }
        //}

        //private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();
        //    Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptVerde.png");
        //    if (myStream != null)
        //    {
        //        this.BackgroundImage = new Bitmap(myStream);
        //    }
        //}

        //private void vermelhoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();
        //    Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptVermelho.png");
        //    if (myStream != null)
        //    {
        //        this.BackgroundImage = new Bitmap(myStream);
        //    }
        //}

        //private void pretoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();
        //    Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
        //    if (myStream != null)
        //    {
        //        this.BackgroundImage = new Bitmap(myStream);
        //    }
        //}

        //private void brancoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();
        //    Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptBranco.png");
        //    if (myStream != null)
        //    {
        //        this.BackgroundImage = new Bitmap(myStream);
        //    }
        //}

        //private void amareloToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();
        //    Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptAmarelo.png");
        //    if (myStream != null)
        //    {
        //        this.BackgroundImage = new Bitmap(myStream);
        //    }
        //}

        //private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();
        //    Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptRosa.png");
        //    if (myStream != null)
        //    {
        //        this.BackgroundImage = new Bitmap(myStream);
        //    }
        //}

        //private void lilásToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Assembly myAssembly = Assembly.GetExecutingAssembly();
        //    Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptLilas.png");
        //    if (myStream != null)
        //    {
        //        this.BackgroundImage = new Bitmap(myStream);
        //    }
        //}
    }
}
