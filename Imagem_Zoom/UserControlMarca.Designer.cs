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
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMarca));
            cmtOptions = new ContextMenuStrip(components);
            tsmPropriedades = new ToolStripMenuItem();
            tsmApagar = new ToolStripMenuItem();
            cmtOptions.SuspendLayout();
            SuspendLayout();
            // 
            // cmtOptions
            // 
            cmtOptions.Items.AddRange(new ToolStripItem[] { tsmPropriedades, tsmApagar });
            cmtOptions.Name = "cmtOptions";
            cmtOptions.Size = new Size(144, 48);
            // 
            // tsmPropriedades
            // 
            tsmPropriedades.Name = "tsmPropriedades";
            tsmPropriedades.Size = new Size(143, 22);
            tsmPropriedades.Text = "Propriedades";
            tsmPropriedades.Click += tsmPropriedades_Click;
            // 
            // tsmApagar
            // 
            tsmApagar.Name = "tsmApagar";
            tsmApagar.Size = new Size(143, 22);
            tsmApagar.Text = "Apagar";
            tsmApagar.Click += tsmApagar_Click;
            // 
            // UserControlMarca
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ContextMenuStrip = cmtOptions;
            DoubleBuffered = true;
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(0);
            Name = "UserControlMarca";
            Size = new Size(18, 18);
            MouseUp += UserControlMarca_MouseUp;
            cmtOptions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip cmtOptions;
        private ToolStripMenuItem tsmPropriedades;
        private ToolStripMenuItem tsmApagar;
    }
}
