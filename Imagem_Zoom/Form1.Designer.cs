namespace Imagem_Zoom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            trackBar1 = new TrackBar();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(45, 28);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.MaximumSize = new Size(1920, 1080);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(537, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageKey = "101671.png";
            button1.ImageList = imageList1;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(83, 23);
            button1.TabIndex = 3;
            button1.Text = "Open File";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Custom-Icon-Design-Mono-General-4-Refresh.512.png");
            imageList1.Images.SetKeyName(1, "101671.png");
            // 
            // trackBar1
            // 
            trackBar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            trackBar1.Location = new Point(466, 18);
            trackBar1.Maximum = 300;
            trackBar1.Minimum = -99;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(128, 45);
            trackBar1.TabIndex = 4;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 69);
            panel1.MaximumSize = new Size(2560, 1080);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 375);
            panel1.TabIndex = 5;
            panel1.MouseWheel += MouseWheel;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(0, 12);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 6;
            label1.Text = "Original Size : X ; Y px";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 439);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 27);
            panel2.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(440, 11);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 9;
            label4.Text = "Real-Time Size : X ; Y px";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(507, 48);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Zoom";
            // 
            // button2
            // 
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.ImageKey = "Custom-Icon-Design-Mono-General-4-Refresh.512.png";
            button2.ImageList = imageList1;
            button2.Location = new Point(12, 40);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 9;
            button2.Text = "Refresh XML";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 474);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Imagem Zoom";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private TrackBar trackBar1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private Button button2;
        private ImageList imageList1;
    }
}