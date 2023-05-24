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
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            lblPonto.AutoSize = true;
            lblPonto.ForeColor = Color.White;
            lblPonto.Location = new Point(0, 5);
            lblPonto.Name = "label1";
            lblPonto.Size = new Size(38, 15);
            lblPonto.TabIndex = 0;
            lblPonto.Text = "label1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(48, 40);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // UserControlMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(linkLabel1);
            Controls.Add(lblPonto);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            MaximumSize = new Size(30, 20);
            MinimumSize = new Size(30, 20);
            Name = "UserControlMarca";
            Size = new Size(30, 20);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblPonto;
        private LinkLabel linkLabel1;
    }
}
