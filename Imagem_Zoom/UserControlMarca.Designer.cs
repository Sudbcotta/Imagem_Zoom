namespace WinFormsApp1
{
    partial class UserControlMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMarca));
            lblPonto = new Label();
            SuspendLayout();
            // 
            // lblPonto
            // 
            lblPonto.AutoSize = true;
            lblPonto.ForeColor = Color.White;
            lblPonto.Location = new Point(-2, 5);
            lblPonto.Name = "lblPonto";
            lblPonto.Size = new Size(38, 15);
            lblPonto.TabIndex = 0;
            lblPonto.Text = "label1";
            // 
            // UserControlMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(lblPonto);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            MaximumSize = new Size(50, 50);
            MinimumSize = new Size(30, 20);
            Name = "UserControlMarca";
            Size = new Size(30, 20);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblPonto;
    }
}
