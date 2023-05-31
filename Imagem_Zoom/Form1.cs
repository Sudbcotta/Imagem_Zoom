using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics;
using System.Net.Http.Headers;
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

        private int larguraAposZoom;
        private int alturaAposZoom;
        private string imagemDaAnalise;
        private string diretorioDoProjeto;
        private int RsWidth;
        private int RsHeight;
        private Point MouseP;
        private int MouseClickX;
        private int MouseClickY;
        private int McpX;
        private int McpY;
        private double zoom;
        private double x;
        private double y;
        private int Relax;
        private int Relay;
        private List<UserControlMarca> userControlMarcas { get; set; }

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
            lblCoordMouse.Visible = false;
            lblImagemComTamanhoEmTempoReal.Visible = false;
            lblImagemComTamanhoOriginal.Visible = false;
            listBox1.Visible = false;
            userControlMarcas = new List<UserControlMarca>();
            lblPt.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
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
            //arquivoXml.WriteComment("");

            arquivoXml.WriteElementString("NomeDaImagem", nomeDaImagemComExtensao);
            arquivoXml.WriteElementString("LarguraDaImagem", largura.ToString());
            arquivoXml.WriteElementString("AlturaDaImagem", altura.ToString());
            arquivoXml.WriteEndElement();

            arquivoXml.Flush();
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
                lblCoordMouse.Visible = true;
                lblImagemComTamanhoEmTempoReal.Visible = true;
                lblImagemComTamanhoOriginal.Visible = true;
                listBox1.Visible = true;
                lblPt.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = true;

                Thread.Sleep(20);

                lblImagemComTamanhoOriginal.Text = $"Tamanho Original: {imgOriginal.Width}; {imgOriginal.Height} px";
                CriacaoDaPastaEXml(picImagemDaAnalise.Width, picImagemDaAnalise.Height, nomeDaImagemComDiretorio);

                LarguraAposZoom = imgOriginal.Width;
                AlturaAposZoom = imgOriginal.Height;

            }

        }
        // botão para atualizar os dados do XML
        private void btnAtualizaXml_Click(object sender, EventArgs e)
        {
            //trbZoomDaImagem = 0;

            XElement escreveXml = new XElement("Atualização");

            escreveXml.Add(new XElement("LarguraAtual", LarguraAposZoom.ToString()));
            escreveXml.Add(new XElement("AlturaAtual", AlturaAposZoom.ToString()));
            escreveXml.Add(new XComment("Ponto_"));
            escreveXml.Add(new XElement("Coordenada-X-do-Clique", (Relax).ToString()));
            escreveXml.Add(new XElement("Coordenada-Y-do-Clique", (Relay).ToString()));
            XElement xml = XElement.Load($@"{DiretorioDoProjeto + "\\" + ImagemDaAnalise}.xml");
            xml.Add(escreveXml);
            xml.Save($@"{DiretorioDoProjeto + "\\" + ImagemDaAnalise}.xml");
            //MessageBox.Show("Arquivo XML atualizado com sucesso.", "Arquivo XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        Image? Zoom(Image imagemDaAnaliseSemZoom, double zoomFactor)
        {
            if (imagemDaAnaliseSemZoom != null)
            {
                //calculo do zoom
                int width = (int)(imagemDaAnaliseSemZoom.Width * zoomFactor);
                int height = (int)(imagemDaAnaliseSemZoom.Height * zoomFactor);
                Bitmap bmp = new Bitmap(imagemDaAnaliseSemZoom, width, height);

                //exibe o tamanho da imagem em tempo real (a cada etapa de zoom)
                lblImagemComTamanhoEmTempoReal.Text = $"Imagem com tamanho em tempo real: {bmp.Width};{bmp.Height} px";
                Graphics g = Graphics.FromImage(bmp);

                if (LarguraAposZoom == 0)
                {
                    //Atribui um valor para mostrar o tamanho da imagem em tempo real no XML 
                    LarguraAposZoom = imgOriginal.Width;
                    AlturaAposZoom = imgOriginal.Height;
                }
                else
                {
                    LarguraAposZoom = bmp.Width;
                    AlturaAposZoom = bmp.Height;
                }
                //gera a interpolação da imagem para que o zoom não tire qualidade da mesma
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

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
            if (RsWidth < 0)
            {
                RsWidth = 0;
            }
            if (RsHeight < 0)
            {
                RsHeight = 0;
            }
            pnlPlanoDeFundoDaImagem.Padding = new Padding(RsWidth, RsHeight, RsWidth, RsHeight);

        }

        private void picImagemDaAnalise_Click(object sender, MouseEventArgs e)
        {
            MouseClickX = (e.X);
            MouseClickY = (e.Y);

            //Armazena o click do mouse em uma variável
            McpX = MouseClickX;
            McpY = MouseClickY;

            //pega as coordenadas do click do mouse (x,y)
            MouseP = picImagemDaAnalise.PointToClient(Cursor.Position);

            //Lista para user Control Marcar

            var user = new UserControlMarca();

            user.Name = string.Format($"UserControlMarca{userControlMarcas.Count()}");
            user.Id = userControlMarcas.Count();
            user.lblPonto.Text = $"Pt_{userControlMarcas.Count()}";

            zoom = trbZoomDaImagem.Value / 100f;

            user.RelativeLocation = new Point((int)(McpX / zoom), (int)(McpY / zoom));

            Relax = user.RelativeLocation.X;
            Relay = user.RelativeLocation.Y;

            McpX += -user.Width / 2;
            McpY += -user.Height / 2;

            user.Location = new Point(McpX, McpY);

            var pic = (PictureBox)sender;
            pic.Controls.Add(user);

            userControlMarcas.Add(user);

            btnAtualizaXml_Click(sender, e);
            listBox1.Items.Add(String.Format("{0} x:{1} y:{2}", user.lblPonto.Text, user.Left, user.Top));
        }
        //Alinhamento do ponto de acordo com o zoom da imagem
        private void Conserta_ponto()
        {
            listBox1.Items.Clear();

            foreach (UserControlMarca user in userControlMarcas)
            {
                x = (trbZoomDaImagem.Value / 100f) * user.RelativeLocation.X;
                y = (trbZoomDaImagem.Value / 100f) * user.RelativeLocation.Y;

                x += -user.Width / 2;
                y += -user.Height / 2;

                user.Location = new Point((int)x, (int)y);
                listBox1.Items.Add(String.Format("{0} x:{1} y:{2}", user.lblPonto.Text, user.Left, user.Top));
            }
        }

        //Zoom aplicado ao mouse wheel
        private void MouseWheel(object sender, MouseEventArgs e)
        {

            int delta = (e.Delta / 10 * SystemInformation.MouseWheelScrollDelta / 120);

            if ((trbZoomDaImagem.Value + delta >= trbZoomDaImagem.Minimum) && (trbZoomDaImagem.Value + delta <= trbZoomDaImagem.Maximum))
            {
                trbZoomDaImagem.Value = trbZoomDaImagem.Value + delta;

                picImagemDaAnalise.Image = Zoom(imgOriginal, trbZoomDaImagem.Value / 100f);
            }
            ArrumaPdImagem();
            Conserta_ponto();
        }

        private void trbZoomDaImagem_Scroll(object sender, EventArgs e)
        {
            picImagemDaAnalise.Image = Zoom(imgOriginal, trbZoomDaImagem.Value / 100f);
            ArrumaPdImagem();
            Conserta_ponto();
        }

        private void picImagemDaAnalise_MouseMove(object sender, MouseEventArgs e)
        {
            lblCoordMouse.Text = String.Format("Coordenadas Mouse: {0};{1}", e.X, e.Y);
        }


    }
}


