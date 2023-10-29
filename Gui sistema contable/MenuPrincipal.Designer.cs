namespace Gui_sistema_contable
{
    partial class MenuPrincipal
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
            panelMenu = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            btnGenerarImg = new Button();
            btnAbrirRegistroAsiento = new Button();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightSteelBlue;
            panelMenu.Controls.Add(panel1);
            panelMenu.Controls.Add(btnGenerarImg);
            panelMenu.Controls.Add(btnAbrirRegistroAsiento);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(567, 230);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 230, 230, 230);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 123);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 22.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(8, 19);
            label1.Name = "label1";
            label1.Size = new Size(547, 39);
            label1.TabIndex = 0;
            label1.Text = "El Buen Sabor contable edition";
            label1.Click += label1_Click;
            // 
            // btnGenerarImg
            // 
            btnGenerarImg.Location = new Point(337, 165);
            btnGenerarImg.Name = "btnGenerarImg";
            btnGenerarImg.Size = new Size(187, 33);
            btnGenerarImg.TabIndex = 1;
            btnGenerarImg.Text = "Mostrar libro mayor";
            btnGenerarImg.UseVisualStyleBackColor = true;
            btnGenerarImg.Click += btnGenerarImg_Click;
            // 
            // btnAbrirRegistroAsiento
            // 
            btnAbrirRegistroAsiento.Location = new Point(52, 165);
            btnAbrirRegistroAsiento.Name = "btnAbrirRegistroAsiento";
            btnAbrirRegistroAsiento.Size = new Size(191, 33);
            btnAbrirRegistroAsiento.TabIndex = 0;
            btnAbrirRegistroAsiento.Text = "Crear nuevo asiento contable";
            btnAbrirRegistroAsiento.UseVisualStyleBackColor = true;
            btnAbrirRegistroAsiento.Click += button1_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 230);
            Controls.Add(panelMenu);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnGenerarImg;
        private Button btnAbrirRegistroAsiento;
        private Panel panel1;
        private Label label1;
    }
}