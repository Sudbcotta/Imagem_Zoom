using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WinFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Imagem_Zoom
{
    public partial class Form1 : Form
    {
        Image imgOriginal;

        private List<UserControlMarca> user ;
        private int larguraAposZoom;
        private int alturaAposZoom;
        private string imagemDaAnalise;
        private string diretorioDoProjeto;
        private int RsWidth;
        private int RsHeight;
        private Point MouseP;
        private int MouseClickX;
        private int MouseClickY;

        public int LarguraAposZoom
        {
            get { return larguraAposZoom; }
            set { larguraAposZoom = value; }
        }
        public int AlturaAposZoom
        {
            get { return alturaAposZoom; }
            set { alturaAposZoom = value; }
        }
        public string ImagemDaAnalise
        {
            get { return imagemDaAnalise; }
            set { imagemDaAnalise = value; }
        }
        public string DiretorioDoProjeto
        {
            get { return diretorioDoProjeto; }
            set { diretorioDoProjeto = value; }
        }



        public Form1()
        {
            InitializeComponent();
            pnlPlanoDeFundoDaImagem.AutoScroll = true;
            trbZoomDaImagem.Visible = false;
            lblZoom.Visible = false;
            btnAtualizaXml.Visible = false;
            lblCoordenada.Visible = false;
            lblImagemComTamanhoEmTempoReal.Visible = false;
            lblImagemComTamanhoOriginal.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            ArrumaPdImagem();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (picImagemDaAnalise.Image != null)
            {
                picImagemDaAnalise.Dispose();
            }
        }
        // Criação da pasta com a imagem e o XML
        private void CriacaoDaPastaEXml(int largura, int altura, string imagemComSeuDiretorio)
        {

            string img = Path.GetFileNameWithoutExtension(imagemComSeuDiretorio);
            string caminhoDoProjeto = $@"C:\{img}";
            string nomeDaImagemComExtensao = Path.GetFileName(imagemComSeuDiretorio);
            ArrumaPdImagem();

            if (!Directory.Exists(caminhoDoProjeto))
                Directory.CreateDirectory(caminhoDoProjeto);

            System.IO.File.Copy(imagemComSeuDiretorio, caminhoDoProjeto + "\\" + nomeDaImagemComExtensao, true);

            //Se o diretório existir, cria o arquivo xml
            //if (Directory.Exists($@"C:\{somenteNomeDaImagem})

            XmlTextWriter arquivoXml =
                new XmlTextWriter($@"{caminhoDoProjeto + "\\" + img}.xml", System.Text.Encoding.UTF8);
            arquivoXml.WriteStartDocument();
            arquivoXml.Formatting = Formatting.Indented;
            arquivoXml.WriteStartElement("Dados");
            arquivoXml.WriteComment("");
            arquivoXml.WriteElementString("NomeDaImagem", nomeDaImagemComExtensao);
            arquivoXml.WriteElementString("LarguraDaImagem", largura.ToString());
            arquivoXml.WriteElementString("AlturaDaImagem", altura.ToString());

            arquivoXml.Close();
            MessageBox.Show("Arquivo XML gerado com sucesso.", "Arquivo XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ImagemDaAnalise = img;
            DiretorioDoProjeto = caminhoDoProjeto;

        }
        // Interação para abrir o arquivo
        private void btnAbrirProjeto_Click(object sender, EventArgs e)
        {
            string nomeDaImagemComDiretorio = string.Empty;

            ofdAbrirImagem.FileName = "";
            ofdAbrirImagem.Multiselect = false;
            ofdAbrirImagem.ValidateNames = true;
            ofdAbrirImagem.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofdAbrirImagem.FilterIndex = 1;
            ofdAbrirImagem.RestoreDirectory = true;

            if (ofdAbrirImagem.ShowDialog() == DialogResult.OK)
            {
                nomeDaImagemComDiretorio = ofdAbrirImagem.FileName;
                picImagemDaAnalise.Image = Image.FromFile(ofdAbrirImagem.FileName);
                imgOriginal = picImagemDaAnalise.Image;

                //deixa as entidades visiveis para o usuario
                trbZoomDaImagem.Visible = true;
                lblZoom.Visible = true;
                btnAtualizaXml.Visible = true;
                lblCoordenada.Visible = true;
                lblImagemComTamanhoEmTempoReal.Visible = true;
                lblImagemComTamanhoOriginal.Visible = true;

                Thread.Sleep(20);

                lblImagemComTamanhoOriginal.Text = $"Tamanho Original: {imgOriginal.Width}; {imgOriginal.Height} px";
                lblCoordenada.Text = $"Coordenadas do Click: {MouseClickX}; {MouseClickY} px";
                CriacaoDaPastaEXml(picImagemDaAnalise.Width, picImagemDaAnalise.Height, nomeDaImagemComDiretorio);

            }
            ArrumaPdImagem();

        }
        // botão para atualizar os dados do XML
        private void btnAtualizaXml_Click(object sender, EventArgs e)
        {

            XElement escreveXml = new XElement("Atualização");

            escreveXml.Add(new XElement("LarguraPosZoom", LarguraAposZoom.ToString()));
            escreveXml.Add(new XElement("AlturaPosZoom", AlturaAposZoom.ToString()));

            escreveXml.Add(new XElement("Coordenada-X-do-Clique", MouseClickX.ToString()));
            escreveXml.Add(new XElement("Coordenada-Y-do-Clique", MouseClickY.ToString()));
            XElement xml = XElement.Load($@"{DiretorioDoProjeto + "\\" + ImagemDaAnalise}.xml");
            xml.Add(escreveXml);
            xml.Save($@"{DiretorioDoProjeto + "\\" + ImagemDaAnalise}.xml");
            MessageBox.Show("Arquivo XML atualizado com sucesso.", "Arquivo XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //zoom aplicado ao mouse wheel
        private void MouseWheel(object sender, MouseEventArgs e)
        {
            //gera um valor para cada rodada no scroll do mouse 
            int delta = (e.Delta / 12 * SystemInformation.MouseWheelScrollDelta / 120);

            if ((trbZoomDaImagem.Value + delta >= trbZoomDaImagem.Minimum) && (trbZoomDaImagem.Value + delta <= trbZoomDaImagem.Maximum))
            {

                trbZoomDaImagem.Value = trbZoomDaImagem.Value + delta;

                if (trbZoomDaImagem.Value >= 0)
                {
                    picImagemDaAnalise.Image = Zoom(imgOriginal, new Size(trbZoomDaImagem.Value, trbZoomDaImagem.Value));
                }
                else
                {
                    picImagemDaAnalise.Image = Zoom(imgOriginal, new Size(trbZoomDaImagem.Value, trbZoomDaImagem.Value));
                }

            }
            ArrumaPdImagem();
        }

        private void trbZoomDaImagem_Scroll(object sender, EventArgs e)
        {
            if (trbZoomDaImagem.Value >= 0)
            {
                picImagemDaAnalise.Image = Zoom(imgOriginal, new Size(trbZoomDaImagem.Value, trbZoomDaImagem.Value));
            }
            else
            {
                picImagemDaAnalise.Image = Zoom(imgOriginal, new Size(trbZoomDaImagem.Value, trbZoomDaImagem.Value));
            }
            ArrumaPdImagem();

        }

        Image? Zoom(Image imagemDaAnaliseSemZoom, Size tamanho)
        {
            if (imagemDaAnaliseSemZoom != null)
            {
                //calculo do zoom
                Bitmap bmp = new Bitmap(imagemDaAnaliseSemZoom, imagemDaAnaliseSemZoom.Width + (imagemDaAnaliseSemZoom.Width * tamanho.Width / 100),
                                        imagemDaAnaliseSemZoom.Height + (imagemDaAnaliseSemZoom.Height * tamanho.Height / 100));

                //exibe o tamanho da imagem em tempo real (a cada etapa de zoom)
                lblImagemComTamanhoEmTempoReal.Text = $"Imagem com tamanho em tempo real: {bmp.Width};{bmp.Height} px";
                Graphics g = Graphics.FromImage(bmp);

                LarguraAposZoom = bmp.Width;
                AlturaAposZoom = bmp.Height;

                //gera a interpolação da imagem para que o zoom não tire qualidade da mesma
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                return bmp;
            }
            else
                return null;

        }
        //Centraliza a imagem no meio da tela
        private void ArrumaPdImagem()
        {
            //pega a largura do panel, diminue pela da imagem e dps divide por 2
            RsWidth = (pnlPlanoDeFundoDaImagem.Width - picImagemDaAnalise.Width) / 2;
            //pega a altura do panel, diminue pela altura da imagem e dps divide por 2
            RsHeight = (pnlPlanoDeFundoDaImagem.Height - picImagemDaAnalise.Height) / 2;
            //transforma o parding do panel de acordo com o tamanho do panel em relação a imagem
            pnlPlanoDeFundoDaImagem.Padding = new Padding(RsWidth, RsHeight, RsWidth, RsHeight);
        }

        private void picImagemDaAnalise_Click(object sender, MouseEventArgs e)
        {
            MouseClickX = (e.X);
            MouseClickY = (e.Y);
            //pega as coordenadas do click do mouse (x,y)
            MouseP = picImagemDaAnalise.PointToClient(Cursor.Position);
            //atualiza a label onde exibe as coordenadas do click
            lblCoordenada.Text = $"Coordenadas do Click: {MouseClickX}; {MouseClickY} px";
            //chama a atualização do xml após cada click do mouse na imagem
            btnAtualizaXml_Click(sender, e);

            //Lista para user Control Marcar
            List<UserControlMarca> userControlMarcas = new List<UserControlMarca>();

            
            var user = new UserControlMarca();
            user.Name = string.Format($"UserControlMarca{userControlMarcas.Count()}");
            user.Id = userControlMarcas.Count();
            user.lblPonto.Text = $"Pt_{userControlMarcas.Count()}";
            var PosX = MouseClickX - user.Width / 2;
            var PosY = MouseClickY - user.Height / 2;

            user.Location = new Point(PosX, PosY);

            var pic = (PictureBox)sender;
            pic.Controls.Add(user);

            userControlMarcas.Add(user);

        }
    }
}


