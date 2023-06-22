using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagem_Zoom
{
    public partial class labelPonto : Label
    {
        public Point RelaLocationLbl { get; set; }
        public labelPonto()
        {
            InitializeComponent();

        }
        private void labelPonto_MouseUp(object sender, MouseEventArgs e)
        {
            frmMain? f = Application.OpenForms["frmMain"] as frmMain;
            if (f != null)
            {
                int x = e.X + this.Location.X;
                int y = e.Y + this.Location.Y;
                this.RelaLocationLbl = f.arrastaPonto(x, y);
            }
        }
    }
}
