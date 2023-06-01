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
            picImagemDaAnalise = new PictureBox();
            imageList1 = new ImageList(components);
            pnlPlanoDeFundoDaImagem = new Panel();
            lblImagemComTamanhoOriginal = new Label();
            lblCoordMouse = new Label();
            lblImagemComTamanhoEmTempoReal = new Label();
            ofdAbrirImagem = new OpenFileDialog();
            groupBox2 = new GroupBox();
            PointCheck = new CheckBox();
            lblZoom = new Label();
            trbZoomDaImagem = new TrackBar();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            btnAtualizaXml = new Button();
            btnAbrirProjeto = new Button();
            pnlPlanoDeFundoParaControles = new Panel();
            groupBox4 = new GroupBox();
            groupBox3 = new GroupBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)picImagemDaAnalise).BeginInit();
            pnlPlanoDeFundoDaImagem.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbZoomDaImagem).BeginInit();
            groupBox1.SuspendLayout();
            pnlPlanoDeFundoParaControles.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // picImagemDaAnalise
            // 
            picImagemDaAnalise.Location = new Point(0, 0);
            picImagemDaAnalise.Margin = new Padding(0);
            picImagemDaAnalise.Name = "picImagemDaAnalise";
            picImagemDaAnalise.Size = new Size(870, 450);
            picImagemDaAnalise.SizeMode = PictureBoxSizeMode.AutoSize;
            picImagemDaAnalise.TabIndex = 1;
            picImagemDaAnalise.TabStop = false;
            picImagemDaAnalise.MouseClick += picImagemDaAnalise_Click;
            picImagemDaAnalise.MouseMove += picImagemDaAnalise_MouseMove;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Custom-Icon-Design-Mono-General-4-Refresh.512.png");
            imageList1.Images.SetKeyName(1, "101671.png");
            // 
            // pnlPlanoDeFundoDaImagem
            // 
            pnlPlanoDeFundoDaImagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPlanoDeFundoDaImagem.AutoScroll = true;
            pnlPlanoDeFundoDaImagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlPlanoDeFundoDaImagem.BackColor = Color.Transparent;
            pnlPlanoDeFundoDaImagem.BorderStyle = BorderStyle.FixedSingle;
            pnlPlanoDeFundoDaImagem.Controls.Add(picImagemDaAnalise);
            pnlPlanoDeFundoDaImagem.Location = new Point(146, 12);
            pnlPlanoDeFundoDaImagem.Name = "pnlPlanoDeFundoDaImagem";
            pnlPlanoDeFundoDaImagem.Size = new Size(914, 517);
            pnlPlanoDeFundoDaImagem.TabIndex = 5;
            pnlPlanoDeFundoDaImagem.MouseWheel += MouseWheel;
            // 
            // lblImagemComTamanhoOriginal
            // 
            lblImagemComTamanhoOriginal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImagemComTamanhoOriginal.AutoSize = true;
            lblImagemComTamanhoOriginal.Location = new Point(9, 28);
            lblImagemComTamanhoOriginal.Name = "lblImagemComTamanhoOriginal";
            lblImagemComTamanhoOriginal.Size = new Size(69, 15);
            lblImagemComTamanhoOriginal.TabIndex = 6;
            lblImagemComTamanhoOriginal.Text = "Size: X; Y px";
            // 
            // lblCoordMouse
            // 
            lblCoordMouse.AutoSize = true;
            lblCoordMouse.Location = new Point(8, 24);
            lblCoordMouse.Name = "lblCoordMouse";
            lblCoordMouse.Size = new Size(66, 15);
            lblCoordMouse.TabIndex = 11;
            lblCoordMouse.Text = "Coord.: X;Y\r\n";
            // 
            // lblImagemComTamanhoEmTempoReal
            // 
            lblImagemComTamanhoEmTempoReal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImagemComTamanhoEmTempoReal.AutoSize = true;
            lblImagemComTamanhoEmTempoReal.Location = new Point(9, 53);
            lblImagemComTamanhoEmTempoReal.Name = "lblImagemComTamanhoEmTempoReal";
            lblImagemComTamanhoEmTempoReal.Size = new Size(86, 15);
            lblImagemComTamanhoEmTempoReal.TabIndex = 9;
            lblImagemComTamanhoEmTempoReal.Text = "RT-Size: X; Y px\r\n";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PointCheck);
            groupBox2.Controls.Add(lblZoom);
            groupBox2.Controls.Add(trbZoomDaImagem);
            groupBox2.Location = new Point(6, -3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 159);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Controles";
            // 
            // PointCheck
            // 
            PointCheck.AutoSize = true;
            PointCheck.Location = new Point(6, 132);
            PointCheck.Name = "PointCheck";
            PointCheck.Size = new Size(107, 19);
            PointCheck.TabIndex = 15;
            PointCheck.Text = "Mostrar Pontos";
            PointCheck.UseVisualStyleBackColor = true;
            PointCheck.CheckedChanged += PointCheck_CheckedChanged;
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Location = new Point(37, 106);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(39, 15);
            lblZoom.TabIndex = 10;
            lblZoom.Text = "Zoom";
            // 
            // trbZoomDaImagem
            // 
            trbZoomDaImagem.Location = new Point(5, 75);
            trbZoomDaImagem.Maximum = 400;
            trbZoomDaImagem.Minimum = 10;
            trbZoomDaImagem.Name = "trbZoomDaImagem";
            trbZoomDaImagem.Size = new Size(100, 45);
            trbZoomDaImagem.TabIndex = 4;
            trbZoomDaImagem.Value = 100;
            trbZoomDaImagem.Visible = false;
            trbZoomDaImagem.Scroll += trbZoomDaImagem_Scroll;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(6, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(114, 96);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pontos";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(7, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(100, 64);
            listBox1.TabIndex = 11;
            // 
            // btnAtualizaXml
            // 
            btnAtualizaXml.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizaXml.ImageKey = "Custom-Icon-Design-Mono-General-4-Refresh.512.png";
            btnAtualizaXml.ImageList = imageList1;
            btnAtualizaXml.Location = new Point(12, 44);
            btnAtualizaXml.Name = "btnAtualizaXml";
            btnAtualizaXml.Padding = new Padding(0, 0, 12, 0);
            btnAtualizaXml.Size = new Size(100, 25);
            btnAtualizaXml.TabIndex = 9;
            btnAtualizaXml.Text = "Atualizar";
            btnAtualizaXml.TextAlign = ContentAlignment.MiddleRight;
            btnAtualizaXml.UseVisualStyleBackColor = true;
            btnAtualizaXml.Click += btnAtualizaXml_Click;
            // 
            // btnAbrirProjeto
            // 
            btnAbrirProjeto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirProjeto.ImageKey = "101671.png";
            btnAbrirProjeto.ImageList = imageList1;
            btnAbrirProjeto.Location = new Point(12, 15);
            btnAbrirProjeto.Name = "btnAbrirProjeto";
            btnAbrirProjeto.Padding = new Padding(0, 0, 22, 0);
            btnAbrirProjeto.Size = new Size(100, 25);
            btnAbrirProjeto.TabIndex = 3;
            btnAbrirProjeto.Text = "Abrir";
            btnAbrirProjeto.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirProjeto.UseVisualStyleBackColor = true;
            btnAbrirProjeto.Click += btnAbrirProjeto_Click;
            // 
            // pnlPlanoDeFundoParaControles
            // 
            pnlPlanoDeFundoParaControles.Controls.Add(groupBox4);
            pnlPlanoDeFundoParaControles.Controls.Add(groupBox3);
            pnlPlanoDeFundoParaControles.Controls.Add(btnAbrirProjeto);
            pnlPlanoDeFundoParaControles.Controls.Add(btnAtualizaXml);
            pnlPlanoDeFundoParaControles.Controls.Add(groupBox1);
            pnlPlanoDeFundoParaControles.Controls.Add(groupBox2);
            pnlPlanoDeFundoParaControles.Location = new Point(12, 13);
            pnlPlanoDeFundoParaControles.Name = "pnlPlanoDeFundoParaControles";
            pnlPlanoDeFundoParaControles.Size = new Size(128, 516);
            pnlPlanoDeFundoParaControles.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblImagemComTamanhoEmTempoReal);
            groupBox4.Controls.Add(lblImagemComTamanhoOriginal);
            groupBox4.Location = new Point(6, 315);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(113, 100);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Imagem";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblCoordMouse);
            groupBox3.Location = new Point(6, 260);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(114, 49);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mouse";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 541);
            Controls.Add(pnlPlanoDeFundoDaImagem);
            Controls.Add(pnlPlanoDeFundoParaControles);
            MinimumSize = new Size(1000, 500);
            Name = "Form1";
            Text = "Imagem Zoom";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)picImagemDaAnalise).EndInit();
            pnlPlanoDeFundoDaImagem.ResumeLayout(false);
            pnlPlanoDeFundoDaImagem.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbZoomDaImagem).EndInit();
            groupBox1.ResumeLayout(false);
            pnlPlanoDeFundoParaControles.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picImagemDaAnalise;
        private Panel pnlPlanoDeFundoDaImagem;
        private Label lblImagemComTamanhoOriginal;
        private Label lblImagemComTamanhoEmTempoReal;
        private OpenFileDialog ofdAbrirImagem;
        private ImageList imageList1;
        private Label lblCoordMouse;
        private GroupBox groupBox2;
        private CheckBox PointCheck;
        private Label lblZoom;
        private TrackBar trbZoomDaImagem;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button btnAtualizaXml;
        private Button btnAbrirProjeto;
        private Panel pnlPlanoDeFundoParaControles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
    }
}