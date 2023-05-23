using System.Diagnostics;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Imagem_Zoom
{
    public partial class Form1 : Form
    {
        Image imgOriginal;

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
        // Cria��o da pasta com a imagem e o XML
        private void CriacaoDaPastaEXml(int largura, int altura, string imagemComSeuDiretorio)
        {

            string img = Path.GetFileNameWithoutExtension(imagemComSeuDiretorio);
            string caminhoDoProjeto = $@"C:\{img}";
            string nomeDaImagemComExtensao = Path.GetFileName(imagemComSeuDiretorio);
            ArrumaPdImagem();

            if (!Directory.Exists(caminhoDoProjeto))
                Directory.CreateDirectory(caminhoDoProjeto);

            System.IO.File.Copy(imagemComSeuDiretorio, caminhoDoProjeto + "\\" + nomeDaImagemComExtensao, true);

            //Se o diret�rio existir, cria o arquivo xml
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
        // Intera��o para abrir o arquivo
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
                trbZoomDaImagem.Visible = true;
                lblZoom.Visible = true;
                btnAtualizaXml.Visible = true;
                Thread.Sleep(20);

                lblImagemComTamanhoOriginal.Text = $"Tamanho Original: {imgOriginal.Width}; {imgOriginal.Height} px";
                label1.Text = $"Coordenadas do Click: {MouseClickX}; {MouseClickY} px";
                CriacaoDaPastaEXml(picImagemDaAnalise.Width, picImagemDaAnalise.Height, nomeDaImagemComDiretorio);

            }
            ArrumaPdImagem();

        }
        // bot�o para atualizar os dados do XML
        private void btnAtualizaXml_Click(object sender, EventArgs e)
        {
            XElement escreveXml = new XElement("Atualiza��o");

            escreveXml.Add(new XElement("LarguraPosZoom", LarguraAposZoom.ToString()));
            escreveXml.Add(new XElement("AlturaPosZoom", AlturaAposZoom.ToString()));

            XElement xml = XElement.Load($@"{DiretorioDoProjeto + "\\" + ImagemDaAnalise}.xml");
            xml.Add(escreveXml);
            xml.Save($@"{DiretorioDoProjeto + "\\" + ImagemDaAnalise}.xml");
            MessageBox.Show("Arquivo XML atualizado com sucesso.", "Arquivo XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //zoom aplicado ao mouse wheel
        private void MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / 12 * SystemInformation.MouseWheelScrollDelta / 120;

            if ((trbZoomDaImagem.Value + delta >= trbZoomDaImagem.Minimum) && (trbZoomDaImagem.Value + delta <= trbZoomDaImagem.Maximum))
            {

                trbZoomDaImagem.Value = trbZoomDaImagem.Value + delta;

                if (trbZoomDaImagem.Value >= 0)
                {
                    picImagemDaAnalise.Image = Zoom(imgOriginal, new Size(trbZoomDaImagem.Value, trbZoomDaImagem.Value));
                }
                if (trbZoomDaImagem.Value <= -90)
                {
                    MessageBox.Show("A fun��o Zoom Out chegou ao seu limite.", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (trbZoomDaImagem.Value >= 290)
                {
                    MessageBox.Show("A fun��o Zoom In chegou ao seu limite.", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                picImagemDaAnalise.Image = Zoom(imgOriginal, new Size(trbZoomDaImagem.Value, trbZoomDaImagem.Value));

            if (trbZoomDaImagem.Value <= -90)
                MessageBox.Show("A fun��o Zoom Out chegou ao seu limite.", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (trbZoomDaImagem.Value >= 290)
                MessageBox.Show("A fun��o Zoom In chegou ao seu limite.", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                picImagemDaAnalise.Image = Zoom(imgOriginal, new Size(trbZoomDaImagem.Value, trbZoomDaImagem.Value));

        }

        Image? Zoom(Image imagemDaAnaliseSemZoom, Size tamanho)
        {
            if (imagemDaAnaliseSemZoom != null)
            {

                Bitmap bmp = new Bitmap(imagemDaAnaliseSemZoom, imagemDaAnaliseSemZoom.Width + (imagemDaAnaliseSemZoom.Width * tamanho.Width / 100),
                                        imagemDaAnaliseSemZoom.Height + (imagemDaAnaliseSemZoom.Height * tamanho.Height / 100));

                lblImagemComTamanhoEmTempoReal.Text = $"Imagem com tamanho em tempo real: {bmp.Width};{bmp.Height} px";
                Graphics g = Graphics.FromImage(bmp);

                LarguraAposZoom = bmp.Width;
                AlturaAposZoom = bmp.Height;

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                return bmp;
            }
            else
                return null;

        }
        //Centraliza a imagem no meio da tela
        private void ArrumaPdImagem()
        {
            RsWidth = (pnlPlanoDeFundoDaImagem.Width - picImagemDaAnalise.Width) / 2;
            RsHeight = (pnlPlanoDeFundoDaImagem.Height - picImagemDaAnalise.Height) / 2;

            pnlPlanoDeFundoDaImagem.Padding = new Padding(RsWidth, RsHeight, RsWidth, RsHeight);
        }

        private void picImagemDaAnalise_Click(object sender, MouseEventArgs e)
        {
            MouseClickX = (e.X);
            MouseClickY = (e.Y);
            MouseP = picImagemDaAnalise.PointToClient(Cursor.Position);
            label1.Text = $"Coordenadas do Click: {MouseClickX}; {MouseClickY} px";

        }
    }
}


