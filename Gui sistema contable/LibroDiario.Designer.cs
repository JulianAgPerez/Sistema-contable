using System.Windows.Forms;

namespace Gui_sistema_contable
{
    partial class LibroDiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibroDiario));
            pictureBox1 = new PictureBox();
            panelImg = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelImg.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(590, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelImg
            // 
            panelImg.AutoScroll = true;
            panelImg.BackColor = SystemColors.ControlLight;
            panelImg.Controls.Add(pictureBox1);
            panelImg.Dock = DockStyle.Fill;
            panelImg.Location = new Point(0, 0);
            panelImg.Name = "panelImg";
            panelImg.Size = new Size(612, 330);
            panelImg.TabIndex = 1;
            // 
            // LibroDiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 330);
            Controls.Add(panelImg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LibroDiario";
            Text = "Libro diario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelImg.ResumeLayout(false);
            panelImg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public PictureBox pictureBox1;
        private Panel panelImg;
    }
}