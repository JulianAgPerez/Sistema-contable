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
            btnAbrirRegistroAsiento = new Button();
            button2 = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.LightSteelBlue;
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnAbrirRegistroAsiento);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(610, 389);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // btnAbrirRegistroAsiento
            // 
            btnAbrirRegistroAsiento.Location = new Point(48, 53);
            btnAbrirRegistroAsiento.Name = "btnAbrirRegistroAsiento";
            btnAbrirRegistroAsiento.Size = new Size(186, 23);
            btnAbrirRegistroAsiento.TabIndex = 0;
            btnAbrirRegistroAsiento.Text = "Crear nuevo asiento contable";
            btnAbrirRegistroAsiento.UseVisualStyleBackColor = true;
            btnAbrirRegistroAsiento.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(59, 101);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 389);
            Controls.Add(panelMenu);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button button2;
        private Button btnAbrirRegistroAsiento;
    }
}