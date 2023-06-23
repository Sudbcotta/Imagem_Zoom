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
            btnOk = new Button();
            btnCancelar = new Button();
            tabControl1 = new TabControl();
            pageXRF = new TabPage();
            pageVM = new TabPage();
            pageMIR = new TabPage();
            gbMirR = new GroupBox();
            txtResultados = new RichTextBox();
            gbMirO = new GroupBox();
            txtObservacao = new RichTextBox();
            tabControl1.SuspendLayout();
            pageMIR.SuspendLayout();
            gbMirR.SuspendLayout();
            gbMirO.SuspendLayout();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.Location = new Point(324, 464);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.Location = new Point(406, 464);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(pageXRF);
            tabControl1.Controls.Add(pageVM);
            tabControl1.Controls.Add(pageMIR);
            tabControl1.Location = new Point(13, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(479, 444);
            tabControl1.TabIndex = 14;
            // 
            // pageXRF
            // 
            pageXRF.Location = new Point(4, 24);
            pageXRF.Name = "pageXRF";
            pageXRF.Padding = new Padding(3);
            pageXRF.Size = new Size(471, 416);
            pageXRF.TabIndex = 0;
            pageXRF.Text = "XRF";
            pageXRF.UseVisualStyleBackColor = true;
            // 
            // pageVM
            // 
            pageVM.Location = new Point(4, 24);
            pageVM.Name = "pageVM";
            pageVM.Padding = new Padding(3);
            pageVM.Size = new Size(471, 416);
            pageVM.TabIndex = 2;
            pageVM.Text = "VM";
            pageVM.UseVisualStyleBackColor = true;
            // 
            // pageMIR
            // 
            pageMIR.Controls.Add(gbMirR);
            pageMIR.Controls.Add(gbMirO);
            pageMIR.Location = new Point(4, 24);
            pageMIR.Name = "pageMIR";
            pageMIR.Padding = new Padding(3);
            pageMIR.Size = new Size(471, 416);
            pageMIR.TabIndex = 1;
            pageMIR.Text = "MIR";
            pageMIR.UseVisualStyleBackColor = true;
            // 
            // gbMirR
            // 
            gbMirR.Controls.Add(txtResultados);
            gbMirR.Location = new Point(11, 211);
            gbMirR.Name = "gbMirR";
            gbMirR.Size = new Size(430, 190);
            gbMirR.TabIndex = 1;
            gbMirR.TabStop = false;
            gbMirR.Text = "Resultados";
            // 
            // txtResultados
            // 
            txtResultados.BorderStyle = BorderStyle.FixedSingle;
            txtResultados.Location = new Point(15, 22);
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(397, 152);
            txtResultados.TabIndex = 1;
            txtResultados.Text = "";
            // 
            // gbMirO
            // 
            gbMirO.Controls.Add(txtObservacao);
            gbMirO.Location = new Point(11, 12);
            gbMirO.Name = "gbMirO";
            gbMirO.Size = new Size(430, 184);
            gbMirO.TabIndex = 0;
            gbMirO.TabStop = false;
            gbMirO.Text = "Observações";
            gbMirO.Enter += groupBox1_Enter;
            // 
            // txtObservacao
            // 
            txtObservacao.BorderStyle = BorderStyle.FixedSingle;
            txtObservacao.Location = new Point(15, 21);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(397, 149);
            txtObservacao.TabIndex = 0;
            txtObservacao.Text = "";
            // 
            // frmDescricaoDoPonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 499);
            Controls.Add(tabControl1);
            Controls.Add(btnOk);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MaximumSize = new Size(521, 538);
            MinimumSize = new Size(521, 538);
            Name = "frmDescricaoDoPonto";
            Text = "Técnicas do Ponto";
            Load += Form2_Load;
            tabControl1.ResumeLayout(false);
            pageMIR.ResumeLayout(false);
            gbMirR.ResumeLayout(false);
            gbMirO.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnOk;
        private Button btnCancelar;
        private TabControl tabControl1;
        private TabPage pageXRF;
        private TabPage pageVM;
        private TabPage pageMIR;
        private GroupBox gbMirO;
        private GroupBox gbMirR;
        private RichTextBox txtObservacao;
        private RichTextBox txtResultados;
    }
}