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
            btnAbrirProjeto = new Button();
            imageList1 = new ImageList(components);
            pnlPlanoDeFundoDaImagem = new Panel();
            lblImagemComTamanhoOriginal = new Label();
            pnlPlanoDeFundoParaDimensoesDaImagem = new Panel();
            lblCoordenada = new Label();
            lblImagemComTamanhoEmTempoReal = new Label();
            btnAtualizaXml = new Button();
            trbZoomDaImagem = new TrackBar();
            pnlPlanoDeFundoParaControles = new Panel();
            lblZoom = new Label();
            ofdAbrirImagem = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picImagemDaAnalise).BeginInit();
            pnlPlanoDeFundoDaImagem.SuspendLayout();
            pnlPlanoDeFundoParaDimensoesDaImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbZoomDaImagem).BeginInit();
            pnlPlanoDeFundoParaControles.SuspendLayout();
            SuspendLayout();
            // 
            // picImagemDaAnalise
            // 
            picImagemDaAnalise.Location = new Point(0, 0);
            picImagemDaAnalise.Margin = new Padding(0);
            picImagemDaAnalise.Name = "picImagemDaAnalise";
            picImagemDaAnalise.Size = new Size(917, 471);
            picImagemDaAnalise.SizeMode = PictureBoxSizeMode.AutoSize;
            picImagemDaAnalise.TabIndex = 1;
            picImagemDaAnalise.TabStop = false;
            picImagemDaAnalise.MouseClick += picImagemDaAnalise_Click;
            // 
            // btnAbrirProjeto
            // 
            btnAbrirProjeto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbrirProjeto.ImageKey = "101671.png";
            btnAbrirProjeto.ImageList = imageList1;
            btnAbrirProjeto.Location = new Point(9, 13);
            btnAbrirProjeto.Name = "btnAbrirProjeto";
            btnAbrirProjeto.Size = new Size(81, 23);
            btnAbrirProjeto.TabIndex = 3;
            btnAbrirProjeto.Text = "Open File";
            btnAbrirProjeto.TextAlign = ContentAlignment.MiddleRight;
            btnAbrirProjeto.UseVisualStyleBackColor = true;
            btnAbrirProjeto.Click += btnAbrirProjeto_Click;
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
            pnlPlanoDeFundoDaImagem.Location = new Point(119, 12);
            pnlPlanoDeFundoDaImagem.Name = "pnlPlanoDeFundoDaImagem";
            pnlPlanoDeFundoDaImagem.Size = new Size(919, 473);
            pnlPlanoDeFundoDaImagem.TabIndex = 5;
            pnlPlanoDeFundoDaImagem.MouseWheel += MouseWheel;
            // 
            // lblImagemComTamanhoOriginal
            // 
            lblImagemComTamanhoOriginal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImagemComTamanhoOriginal.AutoSize = true;
            lblImagemComTamanhoOriginal.Location = new Point(107, 10);
            lblImagemComTamanhoOriginal.Name = "lblImagemComTamanhoOriginal";
            lblImagemComTamanhoOriginal.Size = new Size(143, 15);
            lblImagemComTamanhoOriginal.TabIndex = 6;
            lblImagemComTamanhoOriginal.Text = "Tamanho Original: X; Y px";
            // 
            // pnlPlanoDeFundoParaDimensoesDaImagem
            // 
            pnlPlanoDeFundoParaDimensoesDaImagem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPlanoDeFundoParaDimensoesDaImagem.Controls.Add(lblCoordenada);
            pnlPlanoDeFundoParaDimensoesDaImagem.Controls.Add(lblImagemComTamanhoEmTempoReal);
            pnlPlanoDeFundoParaDimensoesDaImagem.Controls.Add(lblImagemComTamanhoOriginal);
            pnlPlanoDeFundoParaDimensoesDaImagem.Location = new Point(12, 491);
            pnlPlanoDeFundoParaDimensoesDaImagem.Name = "pnlPlanoDeFundoParaDimensoesDaImagem";
            pnlPlanoDeFundoParaDimensoesDaImagem.Size = new Size(1025, 37);
            pnlPlanoDeFundoParaDimensoesDaImagem.TabIndex = 8;
            // 
            // lblCoordenada
            // 
            lblCoordenada.AutoSize = true;
            lblCoordenada.Location = new Point(614, 10);
            lblCoordenada.Name = "lblCoordenada";
            lblCoordenada.Size = new Size(149, 15);
            lblCoordenada.TabIndex = 10;
            lblCoordenada.Text = "Coordenadas do Click: X; Y";
            // 
            // lblImagemComTamanhoEmTempoReal
            // 
            lblImagemComTamanhoEmTempoReal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImagemComTamanhoEmTempoReal.AutoSize = true;
            lblImagemComTamanhoEmTempoReal.Location = new Point(298, 10);
            lblImagemComTamanhoEmTempoReal.Name = "lblImagemComTamanhoEmTempoReal";
            lblImagemComTamanhoEmTempoReal.Size = new Size(251, 15);
            lblImagemComTamanhoEmTempoReal.TabIndex = 9;
            lblImagemComTamanhoEmTempoReal.Text = "Imagem com tamanho em tempo real: X; Y px\n";
            // 
            // btnAtualizaXml
            // 
            btnAtualizaXml.ImageAlign = ContentAlignment.MiddleLeft;
            btnAtualizaXml.ImageKey = "Custom-Icon-Design-Mono-General-4-Refresh.512.png";
            btnAtualizaXml.ImageList = imageList1;
            btnAtualizaXml.Location = new Point(9, 42);
            btnAtualizaXml.Name = "btnAtualizaXml";
            btnAtualizaXml.Padding = new Padding(0, 0, 7, 0);
            btnAtualizaXml.Size = new Size(81, 23);
            btnAtualizaXml.TabIndex = 9;
            btnAtualizaXml.Text = "Refresh";
            btnAtualizaXml.TextAlign = ContentAlignment.MiddleRight;
            btnAtualizaXml.UseVisualStyleBackColor = true;
            btnAtualizaXml.Click += btnAtualizaXml_Click;
            // 
            // trbZoomDaImagem
            // 
            trbZoomDaImagem.Location = new Point(9, 71);
            trbZoomDaImagem.Maximum = 300;
            trbZoomDaImagem.Minimum = -90;
            trbZoomDaImagem.Name = "trbZoomDaImagem";
            trbZoomDaImagem.Size = new Size(81, 45);
            trbZoomDaImagem.TabIndex = 4;
            trbZoomDaImagem.Value = 1;
            trbZoomDaImagem.Visible = false;
            trbZoomDaImagem.Scroll += trbZoomDaImagem_Scroll;
            // 
            // pnlPlanoDeFundoParaControles
            // 
            pnlPlanoDeFundoParaControles.Controls.Add(btnAbrirProjeto);
            pnlPlanoDeFundoParaControles.Controls.Add(lblZoom);
            pnlPlanoDeFundoParaControles.Controls.Add(btnAtualizaXml);
            pnlPlanoDeFundoParaControles.Controls.Add(trbZoomDaImagem);
            pnlPlanoDeFundoParaControles.Location = new Point(12, 12);
            pnlPlanoDeFundoParaControles.Name = "pnlPlanoDeFundoParaControles";
            pnlPlanoDeFundoParaControles.Size = new Size(101, 473);
            pnlPlanoDeFundoParaControles.TabIndex = 2;
            // 
            // lblZoom
            // 
            lblZoom.AutoSize = true;
            lblZoom.Location = new Point(31, 98);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(39, 15);
            lblZoom.TabIndex = 10;
            lblZoom.Text = "Zoom";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 539);
            Controls.Add(pnlPlanoDeFundoDaImagem);
            Controls.Add(pnlPlanoDeFundoParaDimensoesDaImagem);
            Controls.Add(pnlPlanoDeFundoParaControles);
            Name = "Form1";
            Text = "Imagem Zoom";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)picImagemDaAnalise).EndInit();
            pnlPlanoDeFundoDaImagem.ResumeLayout(false);
            pnlPlanoDeFundoDaImagem.PerformLayout();
            pnlPlanoDeFundoParaDimensoesDaImagem.ResumeLayout(false);
            pnlPlanoDeFundoParaDimensoesDaImagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbZoomDaImagem).EndInit();
            pnlPlanoDeFundoParaControles.ResumeLayout(false);
            pnlPlanoDeFundoParaControles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox picImagemDaAnalise;
        private Button btnAbrirProjeto;
        private Panel pnlPlanoDeFundoDaImagem;
        private Label lblImagemComTamanhoOriginal;
        private Panel pnlPlanoDeFundoParaDimensoesDaImagem;
        private Label lblImagemComTamanhoEmTempoReal;
        private Button btnAtualizaXml;
        private TrackBar trbZoomDaImagem;
        private Panel pnlPlanoDeFundoParaControles;
        private Label lblZoom;
        private OpenFileDialog ofdAbrirImagem;
        private ImageList imageList1;
        private Label lblCoordenada;
    }
}