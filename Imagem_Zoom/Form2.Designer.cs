namespace WinFormsApp1
{
    partial class Form2
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
            lblPt = new Label();
            button2 = new Button();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            groupBox3 = new GroupBox();
            textBox2 = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lblPt
            // 
            lblPt.AutoSize = true;
            lblPt.Location = new Point(16, 13);
            lblPt.Name = "lblPt";
            lblPt.Size = new Size(53, 15);
            lblPt.TabIndex = 0;
            lblPt.Text = "ID Ponto";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.Location = new Point(321, 464);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(398, 464);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(17, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "MIR";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(80, 28);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "XRF";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(142, 28);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(43, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "VM";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(10, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 439);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Location = new Point(9, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(468, 372);
            panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox1);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(468, 181);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descrição:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(462, 159);
            textBox1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox2);
            groupBox3.Location = new Point(0, 189);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(468, 174);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultados:";
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 19);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(462, 152);
            textBox2.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 499);
            Controls.Add(lblPt);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(521, 538);
            MinimumSize = new Size(521, 538);
            Name = "Form2";
            Text = "Técnicas do Ponto";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPt;
        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel1;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private GroupBox groupBox3;
    }
}