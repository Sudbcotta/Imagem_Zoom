using System.Diagnostics;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Xml;

namespace Imagem_Zoom
{
    public partial class Form1 : Form
    {
        Image imgOriginal;

        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;

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
                    new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
                label4.Text = $"Real-Time Size : {bmp.Width};{bmp.Height} px";
                Graphics g = Graphics.FromImage(bmp);
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
            int delta = e.Delta / 12 * SystemInformation.MouseWheelScrollDelta / 120;

            if ((trackBar1.Value + delta > trackBar1.Minimum) && (trackBar1.Value + delta < trackBar1.Maximum))
            {

                trackBar1.Value = trackBar1.Value + delta;

                if (trackBar1.Value > 0)
                {
                    pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
                }
                else
                {
                    pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
                }
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                pictureBox1.Image = Zoom(imgOriginal, new Size(trackBar1.Value, trackBar1.Value));
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

            viewPort.Left = x; viewPort.Top = y;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            ResizeContainer();
        }
        private void CriacaoDaPastaEXml(int largura, int altura, string imagemComSeuDiretorio)
        {

            //largAtual = pictureBox1;
            //altAtual = pictureBox1;
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
            //arquivoXml.WriteElementString("LarguraPósZoom",largAtual.ToString());
            //arquivoXml.WriteElementString("AlturaPósZoom",altAtual.ToString());

            arquivoXml.Close();
            MessageBox.Show("Arquivo XML gerado com sucesso.", "Arquivo XML", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
