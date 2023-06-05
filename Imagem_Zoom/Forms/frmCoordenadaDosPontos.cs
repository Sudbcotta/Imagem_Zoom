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
            dgvCoordenadas.ClearSelection();
            dgvCoordenadas.Columns.Add("X", "X");
            dgvCoordenadas.Columns.Add("Y", "Y");

            dgvCoordenadas.Columns[0].Width = 160;
            dgvCoordenadas.Columns[1].Width = 160;


            for (int i = 0; i < mMarcaList.Count; i++)
            {
                dgvCoordenadas.Rows.Add(mMarcaList[i].Location.X, mMarcaList[i].Location.Y);
            }

        }



    }
}
