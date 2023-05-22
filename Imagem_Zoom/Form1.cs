using System.Diagnostics;
using System.Drawing.Printing;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Linq;

namespace Imagem_Zoom
{
    public partial class Form1 : Form
    {
        Image imgOriginal;

        private int largS;
        private int altS;
        //private int junin;
        private string camiProj;
        private string imgS;


        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            trackBar1.Visible = false;
            label2.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nomeDaImagemComDiretorio = "";
            using (OpenFileDialog cleiton = new OpenFileDialog()
            { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {
                if (cleiton.ShowDialog() == DialogResult.OK)
                {
                    nomeDaImagemComDiretorio = cleiton.FileName;
                    pictureBox1.Image = Image.FromFile(cleiton.FileName);
                    imgOriginal = pictureBox1.Image;
                    trackBar1.Visible = true;
                    label2.Visible = true;
                    button2.Visible = true;
                    Thread.Sleep(20);
                    ResizeContainer();
                    label1.Text = $"Original Size : {imgOriginal.Width};{imgOriginal.Height} px";
                    CriacaoDaPastaEXml(pictureBox1.Width, pictureBox1.Height, nomeDaImagemComDiretorio);

                }

            }
        }
        Image? Zoom(Image img, Size size)
        {

            if (img != null)
            {

                Bitmap bmp =
                    new Bitmap
                    (img, img.Width + (img.Width * size.Width / 100),
                    img.Height + (img.Height * size.Height / 100));
                label4.Text = $"Real-Time Size : {bmp.Width};{bmp.Height} px";
                //label3.Text = $"Delta : {junin}";
                Graphics g = Graphics.FromImage(bmp);
                largS = bmp.Width;
                altS = bmp.Height;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                ResizeContainer();

                return bmp;
            }
            else
            {
                return null;
            }
        }

        private void MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / 10 * SystemInformation.MouseWheelScrollDelta / 100;
            //valor de cada etapa do scroll do mouse
            //junin = delta ++;
            if ((trackBar1.Value + delta >= trackBar1.Minimum) && (trackBar1.Value + delta <= trackBar1.Maximum))
            {

                trackBar1.Value = trackBar1.Value + delta;

                if (trackBar1.Value >= 0)
                {
                    pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
                }
                if (trackBar1.Value <= -42)
                {
                    MessageBox.Show("A função Zoom Out chegou ao seu limite.", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (trackBar1.Value >= 290)
                {
                    MessageBox.Show("A função Zoom In chegou ao seu limite.", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = -50;
            trackBar1.Maximum = 300;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.UseWaitCursor = false;

            this.DoubleBuffered = true; //minimizes the strutter

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {


            if (trackBar1.Value >= 0)
            {
                pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            }
            if (trackBar1.Value >= 290)
            {
                MessageBox.Show("A função Zoom In chegou ao seu limite.", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (trackBar1.Value <= -42)
            {
                MessageBox.Show("A função Zoom Out chegou ao seu limite.", "Zoom", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (pictureBox1.Image != null)
            {
                pictureBox1.Dispose();
            }
        }
        private void ResizeContainer()
        {
            Control container = panel1;
            Control viewPort = pictureBox1;


            int x = container.Width / 2 - viewPort.Width / 2;
            int y = container.Height / 2 - viewPort.Height / 2;

            viewPort.Left = x;
            viewPort.Top = y;

        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeContainer();
        }

        //Cria o XML com o nome da pintura e o tamanho original dela
        private void CriacaoDaPastaEXml(int largura, int altura, string imagemComSeuDiretorio)
        {
            string img = Path.GetFileNameWithoutExtension(imagemComSeuDiretorio);
            string caminhoDoProjeto = $@"C:\{img}";
            string nomeDaImagemComExtensao = Path.GetFileName(imagemComSeuDiretorio);

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
            imgS = img;
            camiProj = caminhoDoProjeto;
        }

        //atualiza o XML (tamanho)
        private void button2_Click(object sender, EventArgs e)
        {
            XElement x = new XElement("Atualização");

            x.Add(new XElement("LarguraPosZoom", largS.ToString()));
            x.Add(new XElement("AlturaPosZoom", altS.ToString()));

            XElement xml = XElement.Load($@"{camiProj + "\\" + imgS}.xml");
            xml.Add(x);
            xml.Save($@"{camiProj + "\\" + imgS}.xml");
            MessageBox.Show("Arquivo XML atualizado com sucesso.", "Arquivo XML", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
