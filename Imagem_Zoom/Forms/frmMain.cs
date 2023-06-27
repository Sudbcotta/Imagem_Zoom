using Imagem_Zoom.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing.Text;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WinFormsApp1;

namespace Imagem_Zoom
{
    public partial class frmMain : Form
    {
        #region propriedades
        private List<UserControlMarca> userControlMarcas { get; set; }
        private List<labelPonto> labelPontos { get; set; }
        Image imgOriginal;
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
        public Point coordRelaLabel;

        IDictionary<uint, string[]> pontoXml = new Dictionary<int, string[]>();

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
            this.TransparencyKey = Color.Transparent;
            labelPontos = new List<labelPonto>();
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

        #region Arquivo e Pasta
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
        #endregion Arquivo e Pasta

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
                gerarInterpolacaoDaImagem.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
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
                atualizaCoordenadaLbl();

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
            atualizaCoordenadaLbl();

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
            if (tssMostrarPontos.Checked)
            {
                capturaDoClickDoX = (e.X);
                capturaDoClickDoY = (e.Y);
                UserControlMarca pontoDaAnalise = new UserControlMarca();
                labelPonto lblPts = new labelPonto();
                Contador += 1;

                pontoDaAnalise.Name = string.Format($"UserControlMarca{userControlMarcas.Count()}");
                pontoDaAnalise.Id = (int)Contador;

                num = num + 1;

                pontoDaAnalise.Visible = tssMostrarPontos.Checked;

                pontoDaAnalise.Draggable(true);
                zoom = trbZoomDaImagem.Value / 100f;

                pontoDaAnalise.RelativeLocation = new Point((int)(capturaDoClickDoX / zoom), (int)(capturaDoClickDoY / zoom));
                lblPts.RelaLocationLbl = new Point((int)(e.X / zoom) + 10, (int)(e.Y / zoom) + 10);

                posicaoRelativaDoX = pontoDaAnalise.RelativeLocation.X;
                posicaoRelativaDoY = pontoDaAnalise.RelativeLocation.Y;

                capturaDoClickDoX += -pontoDaAnalise.Width / 2;
                capturaDoClickDoY += -pontoDaAnalise.Height / 2;

                pontoDaAnalise.Location = new Point(capturaDoClickDoX, capturaDoClickDoY);

                pontoDaAnalise.BackgroundImage = ponto;
                PictureBox? pic = (PictureBox)sender;
                pic.Controls.Add(pontoDaAnalise);
                userControlMarcas.Add(pontoDaAnalise);

                lblPts.Location = new Point(e.X + 10, e.Y + 10);
                lblPts.IdLabel = (int)Contador;
                lblPts.Visible = true;
                lblPts.Text = ($"Pt_{num}");
                lblPts.Font = new Font("Calibri", 10, FontStyle.Bold);
                lblPts.ForeColor = txtPt;
                lblPts.BackColor = Color.Transparent;
                lblPts.Margin = new Padding(0);
                lblPts.Padding = new Padding(0);
                lblPts.Size = new Size(45, 19);
                lblPts.Draggable(true);

                labelPontos.Add(lblPts);
                pic.Controls.Add(lblPts);

                //tssAtualizarPontoXML();
            }
            else
                MessageBox.Show("Marque a caixa para poder marcar pontos na imagem ou abra uma imagem!", "Pontos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
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
        /// Apaga uma label da lista de labels
        /// </summary>
        /// <param name="x"></param>
        public void apagarLabel(labelPonto x)
        {
            picImagemDaAnalise.Controls.Remove(x);
            labelPontos.Remove(x);
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
        /// Atualiza a coordenada da label
        /// </summary>
        private void atualizaCoordenadaLbl()
        {
            foreach (labelPonto lblPts in labelPontos)
            {
                double x1 = (trbZoomDaImagem.Value / 100f) * lblPts.RelaLocationLbl.X;
                double y1 = (trbZoomDaImagem.Value / 100f) * lblPts.RelaLocationLbl.Y;

                x1 += -lblPts.Width / 2;
                y1 += -lblPts.Height / 2;

                lblPts.Location = new Point((int)x1 + 10, (int)y1 + 10);
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
        private void tssMostraListaPontos_Click(object sender, EventArgs e)
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
            tssMostrarPontos.Checked = !tssMostrarPontos.Checked;
            foreach (UserControlMarca user in userControlMarcas)
                user.Visible = tssMostrarPontos.Checked ? true : false;
            foreach (labelPonto lbl in labelPontos)
                lbl.Visible = tssMostrarPontos.Checked ? true : false;
        }
        /// <summary>
        /// Colorir os pontos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tssPreto_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptPreto;
                    ponto = Properties.Resources.ptPreto;
                }
            }
            foreach (labelPonto lbl in labelPontos)
            {

                if (lbl != null)
                {
                    lbl.ForeColor = Color.Black;
                    txtPt = Color.Black;
                }

            }
        }
        private void tssBranco_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {

                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptBranco;
                    ponto = Properties.Resources.ptBranco;

                }

            }
            foreach (labelPonto lbl in labelPontos)
            {
                if (lbl != null)
                {
                    lbl.ForeColor = Color.White;
                    txtPt = Color.White;
                }
            }
        }
        private void tssVermelho_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {

                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptVermelho;
                    ponto = Properties.Resources.ptVermelho;
                }

            }
            foreach (labelPonto lbl in labelPontos)
            {

                if (lbl != null)
                {
                    lbl.ForeColor = Color.Red;
                    txtPt = Color.Red;
                }

            }
        }
        private void tssAzul_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {

                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptAzul;
                    ponto = Properties.Resources.ptAzul;
                }

            }
            foreach (labelPonto lbl in labelPontos)
            {

                if (lbl != null)
                {
                    lbl.ForeColor = Color.Blue;
                    txtPt = Color.Blue;
                }

            }
        }
        private void tssVerde_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {

                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptVerde;
                    ponto = Properties.Resources.ptVerde;
                }
            }
            foreach (labelPonto lbl in labelPontos)
            {
                if (lbl != null)
                {
                    lbl.ForeColor = Color.LimeGreen;
                    txtPt = Color.LimeGreen;
                }
            }
        }
        private void tssAmarelo_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {

                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptAmarelo;
                    ponto = Properties.Resources.ptAmarelo;
                }
            }
            foreach (labelPonto lbl in labelPontos)
            {
                if (lbl != null)
                {
                    lbl.ForeColor = Color.Yellow;
                    txtPt = Color.Yellow;
                }
            }
        }
        private void tssRosa_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {

                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptRosa;
                    ponto = Properties.Resources.ptRosa;
                }
            }
            foreach (labelPonto lbl in labelPontos)
            {
                if (lbl != null)
                {
                    lbl.ForeColor = Color.HotPink;
                    txtPt = Color.HotPink;
                }
            }
        }
        private void tssLilas_Click(object sender, EventArgs e)
        {
            foreach (UserControlMarca user in userControlMarcas)
            {
                if (user != null)
                {
                    user.BackgroundImage = Properties.Resources.ptLilas;
                    ponto = Properties.Resources.ptLilas;

                }
            }
            foreach (labelPonto lbl in labelPontos)
            {
                if (lbl != null)
                {
                    lbl.ForeColor = Color.RebeccaPurple;
                    txtPt = Color.RebeccaPurple;
                }
            }
        }
        private void tssApagarPontos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja apagar todos os ponto?", "Pontos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                picImagemDaAnalise.Controls.Clear();
                labelPontos.Clear();
                userControlMarcas.Clear();
            }
        }
        #endregion Pontos

        #region Projeto
        /// <summary>
        /// Atualiza o XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tssAtualizarPontoXML()
        {
            var a = new string[] { posicaoRelativaDoX.ToString(), posicaoRelativaDoY.ToString() };

            pontoXml.Add(Contador, a);
            //pontoXml.Keys[
            
            XElement escreveXml = new XElement("Atualização");
            escreveXml.Add(new XComment($"Ponto_{Contador}"));
            escreveXml.Add(new XElement("Coordenada-X-do-Clique", (posicaoRelativaDoX).ToString()));
            escreveXml.Add(new XElement("Coordenada-Y-do-Clique", (posicaoRelativaDoY).ToString()));
            escreveXml.Add(new XComment($"Ponto_{Contador}"));

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
                tssAtualizarXML.Enabled = true;
                trbZoomDaImagem.Enabled = true;
                tssMostrarPontos.Checked = true;
                tssMostrarPontos.Enabled = true;
                tssMostrarListaPontos.Enabled = true;
                tssCorDoPonto.Enabled = true;
                tssApagarTodosPontos.Enabled = true;
                tssGerarJpeg.Enabled = true;
            }
        }
        /// <summary>
        /// Tentativa de gerar um JPEG da imagem com os pontos nela inseridos
        /// </summary>
        public void gerarJPEG()
        {
            if (picImagemDaAnalise.Image != null)
            {
                Bitmap imgControls = new Bitmap(picImagemDaAnalise.Width, picImagemDaAnalise.Height);

                using (Graphics gPeg = Graphics.FromImage(imgControls))
                {
                    picImagemDaAnalise.DrawToBitmap(imgControls, picImagemDaAnalise.ClientRectangle);
                }
                using (SaveFileDialog salvarJPEG = new SaveFileDialog())
                {
                    salvarJPEG.Filter = "Arquivos de Imagem|*.png;*.jpg;*.jpeg;*.bmp";
                    salvarJPEG.Title = "Salvar Imagem com Pontos/Labels";

                    if (salvarJPEG.ShowDialog() == DialogResult.OK)
                    {
                        string nomeArquivo = salvarJPEG.FileName;

                        picImagemDaAnalise.Image.Save(nomeArquivo, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                }
            }
        }
        /// <summary>
        /// sla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gerarJPEGComPontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picImagemDaAnalise.Image != null)
            {
                gerarJPEG();
            }
        }
        #endregion Projeto

        private void tssAtualizarXMLC(object sender, EventArgs e)
        {
            XElement escreveXml = new XElement("Atualização");
            escreveXml.Add(new XElement("Fator-de-Zoom", ((double)zoom*100f).ToString(),"%"));

            StringBuilder criaString = new StringBuilder();

            foreach(UserControlMarca pts in userControlMarcas)
            {
                
            }
            XmlSerializer serializar = new XmlSerializer(typeof(List<UserControlMarca>));
            using(StreamWriter escritor = new StreamWriter("lista.xml"))
            {
                serializar.Serialize(escritor, userControlMarcas);
            }

            XElement arquivoXml = XElement.Load($@"{diretorioDoProjeto + "\\" + imagemDaAnalise}.xml");

            arquivoXml.Add(escreveXml);
            arquivoXml.Save($@"{diretorioDoProjeto + "\\" + imagemDaAnalise}.xml");
        }
    }
}


