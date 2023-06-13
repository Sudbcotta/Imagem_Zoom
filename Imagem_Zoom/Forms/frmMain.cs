using Imagem_Zoom.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing.Text;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WinFormsApp1;

namespace Imagem_Zoom
{
    public partial class frmMain : Form
    {
        #region propriedades
        private List<UserControlMarca> userControlMarcas { get; set; }
        //public object pontoDaAnalise { get; private set; }
        private List<Label> txtPts;
        Image imgOriginal;
        Label lblTituloDoPonto;
        private int posicaoRelativaDoX;
        private int posicaoRelativaDoY;
        private int capturaDoClickDoX;
        private int capturaDoClickDoY;
        private int larguraAposZoom;
        private int alturaAposZoom;
        public int num;
        private string diretorioDoProjeto;
        private string imagemDaAnalise;
        public uint Contador;
        private double zoom;
        private Image ponto;
        private Color txtPt;

        #endregion propriedades


        #region Construtor

        public frmMain()
        {
            InitializeComponent();
            pnlPlanoDeFundoDaImagem.AutoScroll = true;
            userControlMarcas = new List<UserControlMarca>();
            Contador = 0;
            ponto = Properties.Resources.ptPreto;
            txtPt = Color.Black;
            txtPts = new List<Label>();
        }

        #endregion Construtor

        #region Form
        /// <summary>
        /// Mudança do tamanho da tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            centralizaImagemDaAnalise();
        }
        /// <summary>
        /// Fechamento do Formulário
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (picImagemDaAnalise.Image != null)
                picImagemDaAnalise.Dispose();
        }
        #endregion Form

        /// <summary>
        /// Criação da Pasta e do Arquivo XML
        /// </summary>
        /// <param name="largura"></param>
        /// <param name="altura"></param>
        /// <param name="imagemComSeuDiretorio"></param>
        private void CriacaoDaPastaEXml(int largura, int altura, string imagemComSeuDiretorio)
        {

            string img = Path.GetFileNameWithoutExtension(imagemComSeuDiretorio);
            string caminhoDoProjeto = $@"C:\{img}";
            string nomeDaImagemComExtensao = Path.GetFileName(imagemComSeuDiretorio);

            centralizaImagemDaAnalise();

            if (!Directory.Exists(caminhoDoProjeto))
                Directory.CreateDirectory(caminhoDoProjeto);

            File.Copy(imagemComSeuDiretorio, caminhoDoProjeto + "\\" + nomeDaImagemComExtensao, true);

            XmlTextWriter arquivoXml =
                new XmlTextWriter($@"{caminhoDoProjeto + "\\" + img}.xml", System.Text.Encoding.UTF8);

            arquivoXml.WriteStartDocument();
            arquivoXml.Formatting = Formatting.Indented;

            arquivoXml.WriteStartElement("Dados");
            arquivoXml.WriteElementString("NomeDaImagem", nomeDaImagemComExtensao);
            arquivoXml.WriteElementString("LarguraDaImagem", largura.ToString());
            arquivoXml.WriteElementString("AlturaDaImagem", altura.ToString());

            arquivoXml.WriteEndElement();

            arquivoXml.Flush();
            arquivoXml.Close();
            MessageBox.Show("Arquivo XML gerado com sucesso.", "Arquivo XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
            imagemDaAnalise = img;
            diretorioDoProjeto = caminhoDoProjeto;



        }

        #region Manipulação da Imagem
        /// <summary>
        /// Faz os Cálculos do Zoom da Imagem
        /// </summary>
        /// <param name="imagemDaAnaliseSemZoom"></param>
        /// <param name="zoomFactor"></param>
        /// <returns></returns>
        Image? zoomDaImagem(Image imagemDaAnaliseSemZoom, double zoomFactor)
        {
            if (imagemDaAnaliseSemZoom != null)
            {
                int width = (int)(imagemDaAnaliseSemZoom.Width * zoomFactor);
                int height = (int)(imagemDaAnaliseSemZoom.Height * zoomFactor);

                Bitmap bmp = new Bitmap(imagemDaAnaliseSemZoom, width, height);

                lblImagemComTamanhoEmTempoReal.Text = string.Format("Tempo Real: {0} | {1} px", bmp.Width, bmp.Height);

                Graphics gerarInterpolacaoDaImagem = Graphics.FromImage(bmp);

                if (larguraAposZoom == 0)
                {
                    larguraAposZoom = imgOriginal.Width;
                    alturaAposZoom = imgOriginal.Height;
                }
                else
                {
                    larguraAposZoom = bmp.Width;
                    alturaAposZoom = bmp.Height;
                }

                gerarInterpolacaoDaImagem.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                gerarInterpolacaoDaImagem.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                gerarInterpolacaoDaImagem.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighSpeed;
                gerarInterpolacaoDaImagem.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;

                return bmp;
            }
            else
                return null;
        }
        /// <summary>
        /// Centraliza a imagem na meio do picture box
        /// </summary>
        private void centralizaImagemDaAnalise()
        {

            int RsWidth = (pnlPlanoDeFundoDaImagem.Width - picImagemDaAnalise.Width) / 2;
            int RsHeight = (pnlPlanoDeFundoDaImagem.Height - picImagemDaAnalise.Height) / 2;

            if (RsWidth < 0)
                RsWidth = 0;

            if (RsHeight < 0)
                RsHeight = 0;

            pnlPlanoDeFundoDaImagem.Padding = new Padding(RsWidth, RsHeight, RsWidth, RsHeight);
        }
        /// <summary>
        /// Recebe os dados do scroll do mouse e transforma em dados para o funcionamento do Zoom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MouseWheel(object sender, MouseEventArgs e)
        {
            if (picImagemDaAnalise.Image != null)
            {
                int delta = (e.Delta / 12 * SystemInformation.MouseWheelScrollDelta / 120);

                if ((trbZoomDaImagem.Value + delta >= trbZoomDaImagem.Minimum) && (trbZoomDaImagem.Value + delta <= trbZoomDaImagem.Maximum))
                {
                    trbZoomDaImagem.Value = trbZoomDaImagem.Value + delta;
                    picImagemDaAnalise.Image = zoomDaImagem(imgOriginal, trbZoomDaImagem.Value / 100f);
                }

                centralizaImagemDaAnalise();
                atualizaCoordenadaDoPonto();
            }
        }
        /// <summary>
        /// Recebe dados da track bar e converte para realizar o zoom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trbZoomDaImagem_Scroll(object sender, EventArgs e)
        {
            picImagemDaAnalise.Image = zoomDaImagem(imgOriginal, trbZoomDaImagem.Value / 100f);
            centralizaImagemDaAnalise();
            atualizaCoordenadaDoPonto();
        }
        #endregion Manipulação da Imagem

        #region Pontos
        /// <summary>
        /// Marcação do Ponto na imagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void picImagemDaAnalise_Click(object sender, MouseEventArgs e)
        {
            if (mostrarPontosToolStripMenuItem.Checked)
            {
                capturaDoClickDoX = (e.X);
                capturaDoClickDoY = (e.Y);
                UserControlMarca pontoDaAnalise = new UserControlMarca();

                Contador += 1;

                pontoDaAnalise.Name = string.Format($"UserControlMarca{userControlMarcas.Count()}");
                pontoDaAnalise.Id = (int)Contador;

                num = num + 1;

                pontoDaAnalise.Visible = mostrarPontosToolStripMenuItem.Checked;

                pontoDaAnalise.Draggable(true);

                zoom = trbZoomDaImagem.Value / 100f;

                pontoDaAnalise.RelativeLocation = new Point((int)(capturaDoClickDoX / zoom), (int)(capturaDoClickDoY / zoom));

                posicaoRelativaDoX = pontoDaAnalise.RelativeLocation.X;
                posicaoRelativaDoY = pontoDaAnalise.RelativeLocation.Y;

                capturaDoClickDoX += -pontoDaAnalise.Width / 2;
                capturaDoClickDoY += -pontoDaAnalise.Height / 2;

                pontoDaAnalise.Location = new Point(capturaDoClickDoX, capturaDoClickDoY);
                lblTituloDoPonto = criaLblPonto(pontoDaAnalise);
                picImagemDaAnalise.Controls.Add(lblTituloDoPonto);
                pontoDaAnalise.BackgroundImage = ponto;

                PictureBox? pic = (PictureBox)sender;
                pic.Controls.Add(pontoDaAnalise);

                userControlMarcas.Add(pontoDaAnalise);
                atualizarXMLToolStripMenuItem_Click(sender, e);
            }
            else
                MessageBox.Show("Marque a caixa para poder marcar pontos na imagem ou abra uma imagem!", "Pontos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public Label criaLblPonto(UserControlMarca ponto)
        {

            Label lblPonto = new Label();
            Size offset = new Size(5, 19);
            lblPonto.Location = ponto.Location + offset;
            lblPonto.Visible = true;
            lblPonto.Text = ($"Pt_{num}");
            lblPonto.Font = new Font("Calibri", 10);
            lblPonto.ForeColor = Color.Black;
            lblPonto.BackColor = System.Drawing.Color.Transparent;
            lblPonto.Margin = new Padding(0);
            lblPonto.Padding = new Padding(0);
            lblPonto.Size = new Size(45, 17);
            lblPonto.Draggable(true);
            txtPts.Add(lblPonto);
            return lblPonto;

        }
        //public void mudaCorDaLbl()
        //{
        //    foreach (Label txt in txtPts)
        //    {
        //        txt.ForeColor = Color.White;
        //        txtPt = Color.White;
        //    }
        //}
        /// <summary>
        /// Configura a nova coordenada ao arrastar o ponto
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Point arrastaPonto(int x, int y)
        {
            zoom = trbZoomDaImagem.Value / 100f;
            return new Point((int)(x / zoom), (int)(y / zoom));
        }
        /// <summary>
        /// Apaga um objeto da lista
        /// </summary>
        /// <param name="x"></param>
        public void apagarPonto(UserControlMarca x)
        {
            picImagemDaAnalise.Controls.Remove(x);
            userControlMarcas.Remove(x);
        }
        /// <summary>
        /// Atualiza as coordenadas do ponto de acordo com o zoom
        /// </summary>
        private void atualizaCoordenadaDoPonto()
        {

            foreach (UserControlMarca pontoDaAnalise in userControlMarcas)
            {

                double x = (trbZoomDaImagem.Value / 100f) * pontoDaAnalise.RelativeLocation.X;
                double y = (trbZoomDaImagem.Value / 100f) * pontoDaAnalise.RelativeLocation.Y;

                x += -pontoDaAnalise.Width / 2;
                y += -pontoDaAnalise.Height / 2;

                pontoDaAnalise.Location = new Point((int)x, (int)y);
            }
        }
        /// <summary>
        /// Captura a coordenada do mouse em tempo real
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picImagemDaAnalise_MouseMove(object sender, MouseEventArgs e)
        {

            if (picImagemDaAnalise.Image != null)
                lblCoordMouse.Text = String.Format("X:{0} | Y:{1}", e.X, e.Y);
        }
        /// <summary>
        /// Exibe uma lista com todos os pontos marcados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarListaDePontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picImagemDaAnalise.Image != null && userControlMarcas.Count != 0)
            {
                frmCoordenadaDosPontos frmCoordenadaDosPontos = new frmCoordenadaDosPontos(userControlMarcas);
                frmCoordenadaDosPontos.ShowDialog();
            }

        }
        /// <summary>
        /// Marcação para exibir ou não os pontos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mostrarPontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarPontosToolStripMenuItem.Checked = !mostrarPontosToolStripMenuItem.Checked;
            foreach (UserControlMarca user in userControlMarcas)
                user.Visible = mostrarPontosToolStripMenuItem.Checked ? true : false;

        }
        #endregion Pontos

        #region Projeto
        /// <summary>
        /// Atualiza o XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void atualizarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XElement escreveXml = new XElement("Atualização");

            escreveXml.Add(new XElement("LarguraAtual", larguraAposZoom.ToString()));
            escreveXml.Add(new XElement("AlturaAtual", alturaAposZoom.ToString()));
            escreveXml.Add(new XComment("Ponto_"));
            escreveXml.Add(new XElement("Coordenada-X-do-Clique", (posicaoRelativaDoX).ToString()));
            escreveXml.Add(new XElement("Coordenada-Y-do-Clique", (posicaoRelativaDoY).ToString()));

            XElement arquivoXml = XElement.Load($@"{diretorioDoProjeto + "\\" + imagemDaAnalise}.xml");

            arquivoXml.Add(escreveXml);
            arquivoXml.Save($@"{diretorioDoProjeto + "\\" + imagemDaAnalise}.xml");
        }
        /// <summary>
        /// Abre o projeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abrirProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nomeDaImagemComDiretorio = string.Empty;

            ofdAbrirImagem.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif";

            if (ofdAbrirImagem.ShowDialog() == DialogResult.OK)
            {
                nomeDaImagemComDiretorio = ofdAbrirImagem.FileName;
                picImagemDaAnalise.Image = Image.FromFile(ofdAbrirImagem.FileName);
                imgOriginal = picImagemDaAnalise.Image;

                Thread.Sleep(20);

                lblImagemComTamanhoOriginal.Text = String.Format("Original: {0} | {1} px", imgOriginal.Width, imgOriginal.Height);
                CriacaoDaPastaEXml(picImagemDaAnalise.Width, picImagemDaAnalise.Height, nomeDaImagemComDiretorio);

                larguraAposZoom = imgOriginal.Width;
                alturaAposZoom = imgOriginal.Height;
                atualizarXMLToolStripMenuItem.Enabled = true;
                trbZoomDaImagem.Enabled = true;
                mostrarPontosToolStripMenuItem.Checked = true;
                mostrarPontosToolStripMenuItem.Enabled = true;
                mostrarListaDePontosToolStripMenuItem.Enabled = true;

            }
        }
        #endregion Projeto


        private void pretoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                //Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptPreto;
                    ponto = Properties.Resources.ptPreto;
                    //mudaCorDaLbl();
                }

            }
        }

        private void brancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                //Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptBranco;
                    ponto = Properties.Resources.ptBranco;
                }

            }
        }

        private void vermelhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                //Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptVermelho;
                    ponto = Properties.Resources.ptVermelho;
                }

            }
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                //Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptAzul;
                    ponto = Properties.Resources.ptAzul;
                }

            }
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                //Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptVerde;
                    ponto = Properties.Resources.ptVerde;
                }

            }
        }

        private void amareloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                //Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptAmarelo;
                    ponto = Properties.Resources.ptAmarelo;
                }

            }
        }

        private void rosaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                //Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptRosa;
                    ponto = Properties.Resources.ptRosa;
                }

            }
        }

        private void lilásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                //Stream? myStream = myAssembly.GetManifestResourceStream("Imagem_Zoom.Pontos.ptPreto.png");
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptLilas;
                    ponto = Properties.Resources.ptLilas;
                }

            }
        }
    }
}


