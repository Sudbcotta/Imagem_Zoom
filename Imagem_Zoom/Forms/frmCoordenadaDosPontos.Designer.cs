namespace Imagem_Zoom.Forms
{
    partial class frmCoordenadaDosPontos
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlDGV = new Panel();
            dgvCoordenadas = new DataGridView();
            pnlDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCoordenadas).BeginInit();
            SuspendLayout();
            // 
            // pnlDGV
            // 
            pnlDGV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDGV.AutoScroll = true;
            pnlDGV.Controls.Add(dgvCoordenadas);
            pnlDGV.Location = new Point(12, 12);
            pnlDGV.Name = "pnlDGV";
            pnlDGV.Size = new Size(371, 137);
            pnlDGV.TabIndex = 0;
            // 
            // dgvCoordenadas
            // 
            dgvCoordenadas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCoordenadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCoordenadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCoordenadas.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCoordenadas.Dock = DockStyle.Fill;
            dgvCoordenadas.Location = new Point(0, 0);
            dgvCoordenadas.Margin = new Padding(5);
            dgvCoordenadas.Name = "dgvCoordenadas";
            dgvCoordenadas.RowHeadersWidth = 45;
            dgvCoordenadas.RowTemplate.Height = 25;
            dgvCoordenadas.Size = new Size(371, 137);
            dgvCoordenadas.TabIndex = 0;
            // 
            // frmCoordenadaDosPontos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 161);
            Controls.Add(pnlDGV);
            MaximumSize = new Size(411, 400);
            MinimumSize = new Size(411, 200);
            Name = "frmCoordenadaDosPontos";
            Text = "Lista da Coordenada dos Pontos";
            pnlDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCoordenadas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDGV;
        private DataGridView dgvCoordenadas;
    }
}