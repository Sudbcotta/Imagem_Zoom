namespace WinFormsApp1
{
    partial class frmDescricaoDoPonto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPt = new Label();
            btnOk = new Button();
            btnCancelar = new Button();
            rbMir = new RadioButton();
            rbXRF = new RadioButton();
            rbVM = new RadioButton();
            gpCentral = new GroupBox();
            pnlGroupboxes = new Panel();
            gpDescricao = new GroupBox();
            txbDescricao = new TextBox();
            gpResultados = new GroupBox();
            txbResultados = new TextBox();
            gpCentral.SuspendLayout();
            pnlGroupboxes.SuspendLayout();
            gpDescricao.SuspendLayout();
            gpResultados.SuspendLayout();
            SuspendLayout();
            // 
            // lblPt
            // 
            lblPt.AutoSize = true;
            lblPt.Location = new Point(16, 13);
            lblPt.Name = "lblPt";
            lblPt.Size = new Size(53, 15);
            lblPt.TabIndex = 0;
            lblPt.Text = "ID Ponto";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(328, 464);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(409, 464);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // rbMir
            // 
            rbMir.AutoSize = true;
            rbMir.Location = new Point(17, 28);
            rbMir.Name = "rbMir";
            rbMir.Size = new Size(46, 19);
            rbMir.TabIndex = 3;
            rbMir.TabStop = true;
            rbMir.Text = "MIR";
            rbMir.UseVisualStyleBackColor = true;
            // 
            // rbXRF
            // 
            rbXRF.AutoSize = true;
            rbXRF.Location = new Point(80, 28);
            rbXRF.Name = "rbXRF";
            rbXRF.Size = new Size(45, 19);
            rbXRF.TabIndex = 4;
            rbXRF.TabStop = true;
            rbXRF.Text = "XRF";
            rbXRF.UseVisualStyleBackColor = true;
            // 
            // rbVM
            // 
            rbVM.AutoSize = true;
            rbVM.Location = new Point(142, 28);
            rbVM.Name = "rbVM";
            rbVM.Size = new Size(43, 19);
            rbVM.TabIndex = 5;
            rbVM.TabStop = true;
            rbVM.Text = "VM";
            rbVM.UseVisualStyleBackColor = true;
            // 
            // gpCentral
            // 
            gpCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpCentral.Controls.Add(pnlGroupboxes);
            gpCentral.Controls.Add(rbVM);
            gpCentral.Controls.Add(rbXRF);
            gpCentral.Controls.Add(rbMir);
            gpCentral.Location = new Point(10, 12);
            gpCentral.Name = "gpCentral";
            gpCentral.Size = new Size(483, 439);
            gpCentral.TabIndex = 1;
            gpCentral.TabStop = false;
            // 
            // pnlGroupboxes
            // 
            pnlGroupboxes.Controls.Add(gpDescricao);
            pnlGroupboxes.Controls.Add(gpResultados);
            pnlGroupboxes.Location = new Point(9, 58);
            pnlGroupboxes.Name = "pnlGroupboxes";
            pnlGroupboxes.Size = new Size(468, 372);
            pnlGroupboxes.TabIndex = 10;
            // 
            // gpDescricao
            // 
            gpDescricao.Controls.Add(txbDescricao);
            gpDescricao.Location = new Point(0, 0);
            gpDescricao.Name = "gpDescricao";
            gpDescricao.Size = new Size(468, 181);
            gpDescricao.TabIndex = 9;
            gpDescricao.TabStop = false;
            gpDescricao.Text = "Descrição:";
            // 
            // txbDescricao
            // 
            txbDescricao.Dock = DockStyle.Fill;
            txbDescricao.Location = new Point(3, 19);
            txbDescricao.Multiline = true;
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new Size(462, 159);
            txbDescricao.TabIndex = 0;
            // 
            // gpResultados
            // 
            gpResultados.Controls.Add(txbResultados);
            gpResultados.Location = new Point(0, 189);
            gpResultados.Name = "gpResultados";
            gpResultados.Size = new Size(468, 174);
            gpResultados.TabIndex = 10;
            gpResultados.TabStop = false;
            gpResultados.Text = "Resultados:";
            // 
            // txbResultados
            // 
            txbResultados.Dock = DockStyle.Fill;
            txbResultados.Location = new Point(3, 19);
            txbResultados.Multiline = true;
            txbResultados.Name = "txbResultados";
            txbResultados.Size = new Size(462, 152);
            txbResultados.TabIndex = 8;
            // 
            // frmDescricaoDoPonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 499);
            Controls.Add(lblPt);
            Controls.Add(gpCentral);
            Controls.Add(btnOk);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MaximumSize = new Size(521, 538);
            MinimumSize = new Size(521, 538);
            Name = "frmDescricaoDoPonto";
            Text = "Técnicas do Ponto";
            Load += Form2_Load;
            gpCentral.ResumeLayout(false);
            gpCentral.PerformLayout();
            pnlGroupboxes.ResumeLayout(false);
            gpDescricao.ResumeLayout(false);
            gpDescricao.PerformLayout();
            gpResultados.ResumeLayout(false);
            gpResultados.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPt;
        private GroupBox gpCentral;
        private Button btnOk;
        private Button btnCancelar;
        private RadioButton rbVM;
        private RadioButton rbXRF;
        private RadioButton rbMir;
        private Panel pnlGroupboxes;
        private TextBox txbResultados;
        private GroupBox gpDescricao;
        private TextBox txbDescricao;
        private GroupBox gpResultados;
    }
}