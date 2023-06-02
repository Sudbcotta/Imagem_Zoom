namespace Imagem_Zoom
{
    partial class frmMain
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
            picImagemDaAnalise = new PictureBox();
            pnlPlanoDeFundoDaImagem = new Panel();
            lblImagemComTamanhoOriginal = new Label();
            lblCoordMouse = new Label();
            lblImagemComTamanhoEmTempoReal = new Label();
            ofdAbrirImagem = new OpenFileDialog();
            PointCheck = new CheckBox();
            lblZoom = new Label();
            trbZoomDaImagem = new TrackBar();
            pnlPlanoDeFundoParaControles = new Panel();
            gbZoom = new GroupBox();
            grpTamanhoDaImagem = new GroupBox();
            grpCoordenadaDoMouse = new GroupBox();
            msMenuDoForms = new MenuStrip();
            projetoToolStripMenuItem = new ToolStripMenuItem();
            abrirProjetoToolStripMenuItem = new ToolStripMenuItem();
            atualizarXMLToolStripMenuItem = new ToolStripMenuItem();
            ferramentasToolStripMenuItem = new ToolStripMenuItem();
            mostrarListaDePontosToolStripMenuItem = new ToolStripMenuItem();
            mostrarPontosToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)picImagemDaAnalise).BeginInit();
            pnlPlanoDeFundoDaImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbZoomDaImagem).BeginInit();
            pnlPlanoDeFundoParaControles.SuspendLayout();
            gbZoom.SuspendLayout();
            grpTamanhoDaImagem.SuspendLayout();
            grpCoordenadaDoMouse.SuspendLayout();
            msMenuDoForms.SuspendLayout();
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
            // pnlPlanoDeFundoDaImagem
            // 
            pnlPlanoDeFundoDaImagem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPlanoDeFundoDaImagem.AutoScroll = true;
            pnlPlanoDeFundoDaImagem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlPlanoDeFundoDaImagem.BackColor = Color.Transparent;
            pnlPlanoDeFundoDaImagem.BorderStyle = BorderStyle.FixedSingle;
            pnlPlanoDeFundoDaImagem.Controls.Add(picImagemDaAnalise);
            pnlPlanoDeFundoDaImagem.Location = new Point(183, 39);
            pnlPlanoDeFundoDaImagem.Name = "pnlPlanoDeFundoDaImagem";
            pnlPlanoDeFundoDaImagem.Size = new Size(1197, 596);
            pnlPlanoDeFundoDaImagem.TabIndex = 5;
            pnlPlanoDeFundoDaImagem.MouseWheel += MouseWheel;
            // 
            // lblImagemComTamanhoOriginal
            // 
            lblImagemComTamanhoOriginal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImagemComTamanhoOriginal.AutoSize = true;
            lblImagemComTamanhoOriginal.Location = new Point(21, 24);
            lblImagemComTamanhoOriginal.Name = "lblImagemComTamanhoOriginal";
            lblImagemComTamanhoOriginal.Size = new Size(95, 15);
            lblImagemComTamanhoOriginal.TabIndex = 6;
            lblImagemComTamanhoOriginal.Text = "Original: 0 | 0  px";
            // 
            // lblCoordMouse
            // 
            lblCoordMouse.Anchor = AnchorStyles.None;
            lblCoordMouse.AutoSize = true;
            lblCoordMouse.Location = new Point(45, 23);
            lblCoordMouse.Name = "lblCoordMouse";
            lblCoordMouse.Size = new Size(54, 15);
            lblCoordMouse.TabIndex = 11;
            lblCoordMouse.Text = "X: 0 | Y: 0";
            lblCoordMouse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblImagemComTamanhoEmTempoReal
            // 
            lblImagemComTamanhoEmTempoReal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImagemComTamanhoEmTempoReal.AutoSize = true;
            lblImagemComTamanhoEmTempoReal.Location = new Point(13, 50);
            lblImagemComTamanhoEmTempoReal.Name = "lblImagemComTamanhoEmTempoReal";
            lblImagemComTamanhoEmTempoReal.Size = new Size(111, 15);
            lblImagemComTamanhoEmTempoReal.TabIndex = 9;
            lblImagemComTamanhoEmTempoReal.Text = "Tempo Real: 0 | 0 px";
            // 
            // ofdAbrirImagem
            // 
            ofdAbrirImagem.Filter = "\"Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp\"";
            ofdAbrirImagem.RestoreDirectory = true;
            // 
            // PointCheck
            // 
            PointCheck.AutoSize = true;
            PointCheck.Location = new Point(27, 36);
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
            lblZoom.Location = new Point(59, 62);
            lblZoom.Name = "lblZoom";
            lblZoom.Size = new Size(39, 15);
            lblZoom.TabIndex = 10;
            lblZoom.Text = "Zoom";
            // 
            // trbZoomDaImagem
            // 
            trbZoomDaImagem.Location = new Point(29, 32);
            trbZoomDaImagem.Maximum = 400;
            trbZoomDaImagem.Minimum = 10;
            trbZoomDaImagem.Name = "trbZoomDaImagem";
            trbZoomDaImagem.Size = new Size(101, 45);
            trbZoomDaImagem.TabIndex = 4;
            trbZoomDaImagem.Value = 100;
            trbZoomDaImagem.Scroll += trbZoomDaImagem_Scroll;
            // 
            // pnlPlanoDeFundoParaControles
            // 
            pnlPlanoDeFundoParaControles.Controls.Add(PointCheck);
            pnlPlanoDeFundoParaControles.Controls.Add(gbZoom);
            pnlPlanoDeFundoParaControles.Controls.Add(grpTamanhoDaImagem);
            pnlPlanoDeFundoParaControles.Controls.Add(grpCoordenadaDoMouse);
            pnlPlanoDeFundoParaControles.Location = new Point(12, 40);
            pnlPlanoDeFundoParaControles.Name = "pnlPlanoDeFundoParaControles";
            pnlPlanoDeFundoParaControles.Size = new Size(165, 595);
            pnlPlanoDeFundoParaControles.TabIndex = 2;
            // 
            // gbZoom
            // 
            gbZoom.Controls.Add(lblZoom);
            gbZoom.Controls.Add(trbZoomDaImagem);
            gbZoom.Location = new Point(6, 61);
            gbZoom.Name = "gbZoom";
            gbZoom.Size = new Size(156, 94);
            gbZoom.TabIndex = 17;
            gbZoom.TabStop = false;
            gbZoom.Text = "Zoom";
            // 
            // grpTamanhoDaImagem
            // 
            grpTamanhoDaImagem.Controls.Add(lblImagemComTamanhoEmTempoReal);
            grpTamanhoDaImagem.Controls.Add(lblImagemComTamanhoOriginal);
            grpTamanhoDaImagem.Location = new Point(6, 248);
            grpTamanhoDaImagem.Name = "grpTamanhoDaImagem";
            grpTamanhoDaImagem.Size = new Size(156, 77);
            grpTamanhoDaImagem.TabIndex = 16;
            grpTamanhoDaImagem.TabStop = false;
            grpTamanhoDaImagem.Text = "Tamanho da Imagem";
            // 
            // grpCoordenadaDoMouse
            // 
            grpCoordenadaDoMouse.Controls.Add(lblCoordMouse);
            grpCoordenadaDoMouse.Location = new Point(6, 178);
            grpCoordenadaDoMouse.Name = "grpCoordenadaDoMouse";
            grpCoordenadaDoMouse.Size = new Size(156, 49);
            grpCoordenadaDoMouse.TabIndex = 15;
            grpCoordenadaDoMouse.TabStop = false;
            grpCoordenadaDoMouse.Text = "Coordenada do Mouse";
            // 
            // msMenuDoForms
            // 
            msMenuDoForms.Items.AddRange(new ToolStripItem[] { projetoToolStripMenuItem, ferramentasToolStripMenuItem });
            msMenuDoForms.Location = new Point(0, 0);
            msMenuDoForms.Name = "msMenuDoForms";
            msMenuDoForms.Size = new Size(1404, 24);
            msMenuDoForms.TabIndex = 6;
            msMenuDoForms.Text = "menuStrip1";
            // 
            // projetoToolStripMenuItem
            // 
            projetoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirProjetoToolStripMenuItem, atualizarXMLToolStripMenuItem });
            projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            projetoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D0;
            projetoToolStripMenuItem.Size = new Size(57, 20);
            projetoToolStripMenuItem.Text = "Projeto";
            // 
            // abrirProjetoToolStripMenuItem
            // 
            abrirProjetoToolStripMenuItem.Name = "abrirProjetoToolStripMenuItem";
            abrirProjetoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            abrirProjetoToolStripMenuItem.Size = new Size(187, 22);
            abrirProjetoToolStripMenuItem.Text = "Abrir Projeto";
            abrirProjetoToolStripMenuItem.Click += abrirProjetoToolStripMenuItem_Click;
            // 
            // atualizarXMLToolStripMenuItem
            // 
            atualizarXMLToolStripMenuItem.Enabled = false;
            atualizarXMLToolStripMenuItem.Name = "atualizarXMLToolStripMenuItem";
            atualizarXMLToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            atualizarXMLToolStripMenuItem.Size = new Size(187, 22);
            atualizarXMLToolStripMenuItem.Text = "Atualizar XML";
            atualizarXMLToolStripMenuItem.Click += atualizarXMLToolStripMenuItem_Click;
            // 
            // ferramentasToolStripMenuItem
            // 
            ferramentasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mostrarListaDePontosToolStripMenuItem, mostrarPontosToolStripMenuItem });
            ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            ferramentasToolStripMenuItem.Size = new Size(84, 20);
            ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // mostrarListaDePontosToolStripMenuItem
            // 
            mostrarListaDePontosToolStripMenuItem.Name = "mostrarListaDePontosToolStripMenuItem";
            mostrarListaDePontosToolStripMenuItem.Size = new Size(198, 22);
            mostrarListaDePontosToolStripMenuItem.Text = "Mostrar Lista de Pontos";
            mostrarListaDePontosToolStripMenuItem.Click += mostrarListaDePontosToolStripMenuItem_Click;
            // 
            // mostrarPontosToolStripMenuItem
            // 
            mostrarPontosToolStripMenuItem.Name = "mostrarPontosToolStripMenuItem";
            mostrarPontosToolStripMenuItem.Size = new Size(198, 22);
            mostrarPontosToolStripMenuItem.Text = "Mostrar Pontos";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 661);
            Controls.Add(pnlPlanoDeFundoDaImagem);
            Controls.Add(pnlPlanoDeFundoParaControles);
            Controls.Add(msMenuDoForms);
            MainMenuStrip = msMenuDoForms;
            MinimumSize = new Size(1000, 500);
            Name = "frmMain";
            Text = "Imagem Zoom";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)picImagemDaAnalise).EndInit();
            pnlPlanoDeFundoDaImagem.ResumeLayout(false);
            pnlPlanoDeFundoDaImagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbZoomDaImagem).EndInit();
            pnlPlanoDeFundoParaControles.ResumeLayout(false);
            pnlPlanoDeFundoParaControles.PerformLayout();
            gbZoom.ResumeLayout(false);
            gbZoom.PerformLayout();
            grpTamanhoDaImagem.ResumeLayout(false);
            grpTamanhoDaImagem.PerformLayout();
            grpCoordenadaDoMouse.ResumeLayout(false);
            grpCoordenadaDoMouse.PerformLayout();
            msMenuDoForms.ResumeLayout(false);
            msMenuDoForms.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picImagemDaAnalise;
        private Panel pnlPlanoDeFundoDaImagem;
        private Label lblImagemComTamanhoOriginal;
        private Label lblImagemComTamanhoEmTempoReal;
        private OpenFileDialog ofdAbrirImagem;
        private Label lblCoordMouse;
        private CheckBox PointCheck;
        private Label lblZoom;
        private TrackBar trbZoomDaImagem;
        private Panel pnlPlanoDeFundoParaControles;
        private GroupBox grpTamanhoDaImagem;
        private GroupBox grpCoordenadaDoMouse;
        private GroupBox gbZoom;
        private MenuStrip msMenuDoForms;
        private ToolStripMenuItem projetoToolStripMenuItem;
        private ToolStripMenuItem abrirProjetoToolStripMenuItem;
        private ToolStripMenuItem atualizarXMLToolStripMenuItem;
        private ToolStripMenuItem ferramentasToolStripMenuItem;
        private ToolStripMenuItem mostrarListaDePontosToolStripMenuItem;
        private ToolStripMenuItem mostrarPontosToolStripMenuItem;
    }
}