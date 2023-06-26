using WinFormsApp1;

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
            components = new System.ComponentModel.Container();
            cmtOptions = new ContextMenuStrip(components);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(labelPonto));
            tsmApagar = new ToolStripMenuItem();
            cmtOptions.SuspendLayout();
            SuspendLayout();
            // 
            // labelPonto
            // 
            BackColor = Color.Transparent;
            Name = "labelPonto";
            Size = new Size(56, 22);
            ResumeLayout(false);
            MouseUp += labelPonto_MouseUp;
            ContextMenuStrip = cmtOptions;
            //
            cmtOptions.Items.AddRange(new ToolStripItem[] { tsmApagar });
            cmtOptions.Name = "cmtOptions";
            cmtOptions.Size = new Size(144, 48);
            //
            tsmApagar.Name = "tsmApagar";
            tsmApagar.Size = new Size(143, 22);
            tsmApagar.Text = "Apagar";
            tsmApagar.Click += tsmApagar_Click;
            cmtOptions.ResumeLayout(false);
            ResumeLayout(false );
        }

        #endregion
        private ContextMenuStrip cmtOptions;
        private ToolStripMenuItem tsmApagar;
    }
}
