using System.Diagnostics;
using System.Security.Cryptography;

namespace Imagem_Zoom
{
    public partial class Form1 : Form
    {
        Image imgOriginal;

        public Form1()
        {
            InitializeComponent();
            panel1.AutoScroll = true;
            //pictureBox1.MouseWheel += pictureBox1_MouseWheel;
            //pictureBox1.MouseWheel += pictureBox1_MouseMove;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog cleiton = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "JPEG|*.jpg" })
            {
                if (cleiton.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(cleiton.FileName);
                    imgOriginal = pictureBox1.Image;
                    Thread.Sleep(20);
                    ResizeContainer();
                    label2.Text = $"{pictureBox1.Width};{pictureBox1.Height} px";
                }

            }
        }
        Image? Zoom(Image img, Size size)
        {
            if (img != null)
            {
                Bitmap bmp = new Bitmap(img, img.Width + (img.Width * size.Width / 100), img.Height + (img.Height * size.Height / 100));
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
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
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


    }
}