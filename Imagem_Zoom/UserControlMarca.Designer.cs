﻿namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMarca));
            lblPonto = new LinkLabel();
            SuspendLayout();
            // 
            // lblPonto
            // 
            lblPonto.ActiveLinkColor = Color.White;
            lblPonto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPonto.AutoSize = true;
            lblPonto.Font = new Font("Arial", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPonto.ForeColor = SystemColors.ControlLightLight;
            lblPonto.LinkColor = Color.White;
            lblPonto.Location = new Point(1, 2);
            lblPonto.Margin = new Padding(7, 7, 3, 0);
            lblPonto.Name = "lblPonto";
            lblPonto.Size = new Size(19, 14);
            lblPonto.TabIndex = 0;
            lblPonto.TabStop = true;
            lblPonto.Text = "10";
            lblPonto.LinkClicked += linkLabel1_LinkClicked;
            // 
            // UserControlMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(lblPonto);
            DoubleBuffered = true;
            MaximumSize = new Size(20, 20);
            Name = "UserControlMarca";
            Size = new Size(20, 20);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public LinkLabel lblPonto;
    }
}
