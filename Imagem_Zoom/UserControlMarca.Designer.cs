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
            corDoPontoTextoToolStripMenuItem = new ToolStripMenuItem();
            azulToolStripMenuItem = new ToolStripMenuItem();
            verdeToolStripMenuItem = new ToolStripMenuItem();
            vermelhoToolStripMenuItem = new ToolStripMenuItem();
            pretoToolStripMenuItem = new ToolStripMenuItem();
            brancoToolStripMenuItem = new ToolStripMenuItem();
            amareloToolStripMenuItem = new ToolStripMenuItem();
            rosaToolStripMenuItem = new ToolStripMenuItem();
            lilásToolStripMenuItem = new ToolStripMenuItem();
            cmtOptions.SuspendLayout();
            SuspendLayout();
            // 
            // cmtOptions
            // 
            cmtOptions.Items.AddRange(new ToolStripItem[] { tsmPropriedades, tsmApagar, corDoPontoTextoToolStripMenuItem });
            cmtOptions.Name = "cmtOptions";
            cmtOptions.Size = new Size(179, 70);
            // 
            // tsmPropriedades
            // 
            tsmPropriedades.Name = "tsmPropriedades";
            tsmPropriedades.Size = new Size(178, 22);
            tsmPropriedades.Text = "Propriedades";
            tsmPropriedades.Click += tsmPropriedades_Click;
            // 
            // tsmApagar
            // 
            tsmApagar.Name = "tsmApagar";
            tsmApagar.Size = new Size(178, 22);
            tsmApagar.Text = "Apagar";
            tsmApagar.Click += tsmApagar_Click;
            // 
            // corDoPontoTextoToolStripMenuItem
            // 
            corDoPontoTextoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { azulToolStripMenuItem, verdeToolStripMenuItem, vermelhoToolStripMenuItem, pretoToolStripMenuItem, brancoToolStripMenuItem, amareloToolStripMenuItem, rosaToolStripMenuItem, lilásToolStripMenuItem });
            corDoPontoTextoToolStripMenuItem.Name = "corDoPontoTextoToolStripMenuItem";
            corDoPontoTextoToolStripMenuItem.Size = new Size(178, 22);
            corDoPontoTextoToolStripMenuItem.Text = "Cor do Ponto/Texto";
            // 
            // azulToolStripMenuItem
            // 
            azulToolStripMenuItem.Name = "azulToolStripMenuItem";
            azulToolStripMenuItem.Size = new Size(124, 22);
            azulToolStripMenuItem.Text = "Azul";
            azulToolStripMenuItem.Click += azulToolStripMenuItem_Click;
            // 
            // verdeToolStripMenuItem
            // 
            verdeToolStripMenuItem.Name = "verdeToolStripMenuItem";
            verdeToolStripMenuItem.Size = new Size(124, 22);
            verdeToolStripMenuItem.Text = "Verde";
            verdeToolStripMenuItem.Click += verdeToolStripMenuItem_Click;
            // 
            // vermelhoToolStripMenuItem
            // 
            vermelhoToolStripMenuItem.Name = "vermelhoToolStripMenuItem";
            vermelhoToolStripMenuItem.Size = new Size(124, 22);
            vermelhoToolStripMenuItem.Text = "Vermelho";
            vermelhoToolStripMenuItem.Click += vermelhoToolStripMenuItem_Click;
            // 
            // pretoToolStripMenuItem
            // 
            pretoToolStripMenuItem.Name = "pretoToolStripMenuItem";
            pretoToolStripMenuItem.Size = new Size(124, 22);
            pretoToolStripMenuItem.Text = "Preto";
            pretoToolStripMenuItem.Click += pretoToolStripMenuItem_Click;
            // 
            // brancoToolStripMenuItem
            // 
            brancoToolStripMenuItem.Name = "brancoToolStripMenuItem";
            brancoToolStripMenuItem.Size = new Size(124, 22);
            brancoToolStripMenuItem.Text = "Branco";
            brancoToolStripMenuItem.Click += brancoToolStripMenuItem_Click;
            // 
            // amareloToolStripMenuItem
            // 
            amareloToolStripMenuItem.Name = "amareloToolStripMenuItem";
            amareloToolStripMenuItem.Size = new Size(124, 22);
            amareloToolStripMenuItem.Text = "Amarelo";
            amareloToolStripMenuItem.Click += amareloToolStripMenuItem_Click;
            // 
            // rosaToolStripMenuItem
            // 
            rosaToolStripMenuItem.Name = "rosaToolStripMenuItem";
            rosaToolStripMenuItem.Size = new Size(124, 22);
            rosaToolStripMenuItem.Text = "Rosa";
            rosaToolStripMenuItem.Click += rosaToolStripMenuItem_Click;
            // 
            // lilásToolStripMenuItem
            // 
            lilásToolStripMenuItem.Name = "lilásToolStripMenuItem";
            lilásToolStripMenuItem.Size = new Size(124, 22);
            lilásToolStripMenuItem.Text = "Lilás";
            lilásToolStripMenuItem.Click += lilásToolStripMenuItem_Click;
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
        private ToolStripMenuItem corDoPontoTextoToolStripMenuItem;
        private ToolStripMenuItem azulToolStripMenuItem;
        private ToolStripMenuItem verdeToolStripMenuItem;
        private ToolStripMenuItem vermelhoToolStripMenuItem;
        private ToolStripMenuItem pretoToolStripMenuItem;
        private ToolStripMenuItem brancoToolStripMenuItem;
        private ToolStripMenuItem amareloToolStripMenuItem;
        private ToolStripMenuItem rosaToolStripMenuItem;
        private ToolStripMenuItem lilásToolStripMenuItem;
    }
}
