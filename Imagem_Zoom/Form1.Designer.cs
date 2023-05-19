namespace Imagem_Zoom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            imageList1 = new ImageList(components);
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            button2 = new Button();
            trackBar1 = new TrackBar();
            panel3 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Margin = new Padding(0, 80, 0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.ImageKey = "101671.png";
            button1.ImageList = imageList1;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 3;
            button1.Text = "Open File";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Custom-Icon-Design-Mono-General-4-Refresh.512.png");
            imageList1.Images.SetKeyName(1, "101671.png");
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.Transparent;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(109, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 408);
            panel1.TabIndex = 5;
            panel1.MouseWheel += MouseWheel;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 6;
            label1.Text = "Original Size : X ; Y px";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(596, 37);
            panel2.TabIndex = 8;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(0, 21);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 9;
            label4.Text = "Real-Time Size : X ; Y px";
            // 
            // button2
            // 
            button2.ImageKey = "Custom-Icon-Design-Mono-General-4-Refresh.512.png";
            button2.ImageList = imageList1;
            button2.Location = new Point(0, 29);
            button2.Name = "button2";
            button2.Size = new Size(45, 23);
            button2.TabIndex = 9;
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(3, 58);
            trackBar1.Maximum = 300;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(81, 45);
            trackBar1.TabIndex = 4;
            trackBar1.Value = 1;
            trackBar1.Visible = false;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(trackBar1);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(91, 408);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 88);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 10;
            label2.Text = "Zoom";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 474);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Imagem Zoom";
            FormClosing += Form1_FormClosing;
            Resize += Form1_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private Button button2;
        private ImageList imageList1;
        private TrackBar trackBar1;
        private Panel panel3;
        private Label label2;
    }
}