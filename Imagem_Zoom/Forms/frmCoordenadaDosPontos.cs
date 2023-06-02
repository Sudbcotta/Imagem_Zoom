using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Imagem_Zoom.Forms
{
    public partial class frmCoordenadaDosPontos : Form
    {

        private List<UserControlMarca> mMarcaList;
        public frmCoordenadaDosPontos(List<UserControlMarca> userControl)
        {
            InitializeComponent();
            mMarcaList = userControl;
            adicionarPontosNaListBox();

        }

        private void adicionarPontosNaListBox()
        {
            dataGridView1.ClearSelection();
            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");


            for (int i = 0; i < mMarcaList.Count; i++)
            {
                dataGridView1.Rows.Add(mMarcaList[i].Location.X, mMarcaList[i].Location.Y);
                //string Pontos = string.Format("X: {0} | Y: {1}", mMarcaList[i].Location.X.ToString(), mMarcaList[i].Location.Y.ToString());
                //richTextBox1.AppendText(Pontos);
            }




        }



    }
}
