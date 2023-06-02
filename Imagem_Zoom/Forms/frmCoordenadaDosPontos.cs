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

            dataGridView1.Columns[0].Width = 160;
            dataGridView1.Columns[1].Width = 160;


            for (int i = 0; i < mMarcaList.Count; i++)
            {
                dataGridView1.Rows.Add(mMarcaList[i].Location.X, mMarcaList[i].Location.Y);
            }

        }



    }
}
