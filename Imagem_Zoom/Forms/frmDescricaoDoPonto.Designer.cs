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
            tabTEcnicas = new TabControl();
            pageXRF = new TabPage();
            pageVM = new TabPage();
            pageMIR = new TabPage();
            gbMirR = new GroupBox();
            txtResultados = new RichTextBox();
            gbMirO = new GroupBox();
            txtObservacao = new RichTextBox();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox2 = new GroupBox();
            richTextBox2 = new RichTextBox();
            groupBox3 = new GroupBox();
            richTextBox3 = new RichTextBox();
            groupBox4 = new GroupBox();
            richTextBox4 = new RichTextBox();
            tabTEcnicas.SuspendLayout();
            pageXRF.SuspendLayout();
            pageVM.SuspendLayout();
            pageMIR.SuspendLayout();
            gbMirR.SuspendLayout();
            gbMirO.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
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
            // tabTEcnicas
            // 
            tabTEcnicas.Controls.Add(pageXRF);
            tabTEcnicas.Controls.Add(pageVM);
            tabTEcnicas.Controls.Add(pageMIR);
            tabTEcnicas.Location = new Point(14, 12);
            tabTEcnicas.Name = "tabTEcnicas";
            tabTEcnicas.SelectedIndex = 0;
            tabTEcnicas.Size = new Size(479, 444);
            tabTEcnicas.TabIndex = 14;
            // 
            // pageXRF
            // 
            pageXRF.Controls.Add(groupBox3);
            pageXRF.Controls.Add(groupBox4);
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
            pageVM.Controls.Add(groupBox1);
            pageVM.Controls.Add(groupBox2);
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
            gbMirR.Location = new Point(13, 213);
            gbMirR.Name = "gbMirR";
            gbMirR.Size = new Size(444, 190);
            gbMirR.TabIndex = 1;
            gbMirR.TabStop = false;
            gbMirR.Text = "Resultados";
            // 
            // txtResultados
            // 
            txtResultados.BorderStyle = BorderStyle.FixedSingle;
            txtResultados.Location = new Point(15, 22);
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(415, 152);
            txtResultados.TabIndex = 1;
            txtResultados.Text = "";
            // 
            // gbMirO
            // 
            gbMirO.Controls.Add(txtObservacao);
            gbMirO.Location = new Point(13, 14);
            gbMirO.Name = "gbMirO";
            gbMirO.Size = new Size(444, 184);
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
            txtObservacao.Size = new Size(415, 149);
            txtObservacao.TabIndex = 0;
            txtObservacao.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(13, 213);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 190);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados";
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(15, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(415, 152);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Location = new Point(13, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 184);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Observações";
            // 
            // richTextBox2
            // 
            richTextBox2.BorderStyle = BorderStyle.FixedSingle;
            richTextBox2.Location = new Point(15, 21);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(415, 149);
            richTextBox2.TabIndex = 0;
            richTextBox2.Text = "";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(richTextBox3);
            groupBox3.Location = new Point(13, 213);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(444, 190);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados";
            // 
            // richTextBox3
            // 
            richTextBox3.BorderStyle = BorderStyle.FixedSingle;
            richTextBox3.Location = new Point(15, 22);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(415, 152);
            richTextBox3.TabIndex = 1;
            richTextBox3.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox4);
            groupBox4.Location = new Point(13, 14);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(444, 184);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Observações";
            // 
            // richTextBox4
            // 
            richTextBox4.BorderStyle = BorderStyle.FixedSingle;
            richTextBox4.Location = new Point(15, 21);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(415, 149);
            richTextBox4.TabIndex = 0;
            richTextBox4.Text = "";
            // 
            // frmDescricaoDoPonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 499);
            Controls.Add(tabTEcnicas);
            Controls.Add(btnOk);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MaximumSize = new Size(521, 538);
            MinimumSize = new Size(521, 538);
            Name = "frmDescricaoDoPonto";
            Text = "Técnicas do Ponto";
            Load += Form2_Load;
            tabTEcnicas.ResumeLayout(false);
            pageXRF.ResumeLayout(false);
            pageVM.ResumeLayout(false);
            pageMIR.ResumeLayout(false);
            gbMirR.ResumeLayout(false);
            gbMirO.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnOk;
        private Button btnCancelar;
        private TabControl tabTEcnicas;
        private TabPage pageXRF;
        private TabPage pageVM;
        private TabPage pageMIR;
        private GroupBox gbMirO;
        private GroupBox gbMirR;
        private RichTextBox txtObservacao;
        private RichTextBox txtResultados;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox2;
        private RichTextBox richTextBox2;
        private GroupBox groupBox3;
        private RichTextBox richTextBox3;
        private GroupBox groupBox4;
        private RichTextBox richTextBox4;
    }
}