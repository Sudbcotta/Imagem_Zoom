namespace Imagem_Zoom
{
    partial class labelPonto
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblPoint = new Label();
            SuspendLayout();
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Enabled = false;
            lblPoint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPoint.ForeColor = SystemColors.ButtonHighlight;
            lblPoint.Location = new Point(0, 0);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(45, 15);
            lblPoint.TabIndex = 0;
            lblPoint.Text = "Pt_000";
            // 
            // labelPonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblPoint);
            Name = "labelPonto";
            Size = new Size(43, 17);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPoint;
    }
}
