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
            gpCentral = new GroupBox();
            chkVm = new CheckBox();
            chkXrf = new CheckBox();
            chkMir = new CheckBox();
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
            // gpCentral
            // 
            gpCentral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpCentral.Controls.Add(chkVm);
            gpCentral.Controls.Add(chkXrf);
            gpCentral.Controls.Add(chkMir);
            gpCentral.Controls.Add(pnlGroupboxes);
            gpCentral.Location = new Point(10, 12);
            gpCentral.Name = "gpCentral";
            gpCentral.Size = new Size(483, 439);
            gpCentral.TabIndex = 1;
            gpCentral.TabStop = false;
            // 
            // chkVm
            // 
            chkVm.AutoSize = true;
            chkVm.Location = new Point(128, 29);
            chkVm.Name = "chkVm";
            chkVm.Size = new Size(44, 19);
            chkVm.TabIndex = 13;
            chkVm.Text = "VM";
            chkVm.UseVisualStyleBackColor = true;
            // 
            // chkXrf
            // 
            chkXrf.AutoSize = true;
            chkXrf.Location = new Point(71, 29);
            chkXrf.Name = "chkXrf";
            chkXrf.Size = new Size(46, 19);
            chkXrf.TabIndex = 12;
            chkXrf.Text = "XRF";
            chkXrf.UseVisualStyleBackColor = true;
            // 
            // chkMir
            // 
            chkMir.AutoSize = true;
            chkMir.Checked = true;
            chkMir.CheckState = CheckState.Checked;
            chkMir.Location = new Point(12, 29);
            chkMir.Name = "chkMir";
            chkMir.Size = new Size(47, 19);
            chkMir.TabIndex = 11;
            chkMir.Text = "MIR";
            chkMir.UseVisualStyleBackColor = true;
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
        private Panel pnlGroupboxes;
        private TextBox txbResultados;
        private GroupBox gpDescricao;
        private TextBox txbDescricao;
        private GroupBox gpResultados;
        private CheckBox chkVm;
        private CheckBox chkXrf;
        private CheckBox chkMir;
    }
}