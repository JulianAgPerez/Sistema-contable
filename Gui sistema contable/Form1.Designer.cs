namespace Gui_sistema_contable
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
            panelTop = new Panel();
            lbFecha = new Label();
            lbNum = new Label();
            lbDiario = new Label();
            textBoxNum = new TextBox();
            comboBoxFecha = new ComboBox();
            comboBoxDiario = new ComboBox();
            panelCentro = new Panel();
            dataGridView1 = new DataGridView();
            columCuenta = new DataGridViewTextBoxColumn();
            ColumNombre = new DataGridViewTextBoxColumn();
            ColumDesc = new DataGridViewTextBoxColumn();
            ColumDebe = new DataGridViewTextBoxColumn();
            ColumHaber = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            lbCredito = new Label();
            lbDebito = new Label();
            btnGrabar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            panelTop.SuspendLayout();
            panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ActiveCaption;
            panelTop.Controls.Add(lbFecha);
            panelTop.Controls.Add(lbNum);
            panelTop.Controls.Add(lbDiario);
            panelTop.Controls.Add(textBoxNum);
            panelTop.Controls.Add(comboBoxFecha);
            panelTop.Controls.Add(comboBoxDiario);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(673, 88);
            panelTop.TabIndex = 0;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.Location = new Point(480, 31);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(41, 15);
            lbFecha.TabIndex = 5;
            lbFecha.Text = "Fecha:";
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Location = new Point(274, 31);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(37, 15);
            lbNum.TabIndex = 4;
            lbNum.Text = "Num:";
            // 
            // lbDiario
            // 
            lbDiario.AutoSize = true;
            lbDiario.Location = new Point(36, 31);
            lbDiario.Name = "lbDiario";
            lbDiario.Size = new Size(41, 15);
            lbDiario.TabIndex = 3;
            lbDiario.Text = "Diario:";
            // 
            // textBoxNum
            // 
            textBoxNum.Cursor = Cursors.Hand;
            textBoxNum.Location = new Point(317, 26);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(100, 23);
            textBoxNum.TabIndex = 2;
            // 
            // comboBoxFecha
            // 
            comboBoxFecha.Cursor = Cursors.Hand;
            comboBoxFecha.FormattingEnabled = true;
            comboBoxFecha.Location = new Point(527, 26);
            comboBoxFecha.Name = "comboBoxFecha";
            comboBoxFecha.Size = new Size(121, 23);
            comboBoxFecha.TabIndex = 1;
            // 
            // comboBoxDiario
            // 
            comboBoxDiario.Cursor = Cursors.Hand;
            comboBoxDiario.FormattingEnabled = true;
            comboBoxDiario.Location = new Point(83, 26);
            comboBoxDiario.Name = "comboBoxDiario";
            comboBoxDiario.Size = new Size(121, 23);
            comboBoxDiario.TabIndex = 0;
            // 
            // panelCentro
            // 
            panelCentro.Controls.Add(dataGridView1);
            panelCentro.Location = new Point(0, 84);
            panelCentro.Name = "panelCentro";
            panelCentro.Size = new Size(673, 189);
            panelCentro.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columCuenta, ColumNombre, ColumDesc, ColumDebe, ColumHaber });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(673, 189);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // columCuenta
            // 
            columCuenta.HeaderText = "Cuenta";
            columCuenta.Name = "columCuenta";
            columCuenta.ReadOnly = true;
            // 
            // ColumNombre
            // 
            ColumNombre.HeaderText = "Nombre";
            ColumNombre.Name = "ColumNombre";
            ColumNombre.ReadOnly = true;
            // 
            // ColumDesc
            // 
            ColumDesc.HeaderText = "Descripcion";
            ColumDesc.Name = "ColumDesc";
            ColumDesc.ReadOnly = true;
            // 
            // ColumDebe
            // 
            ColumDebe.HeaderText = "Debe";
            ColumDebe.Name = "ColumDebe";
            ColumDebe.ReadOnly = true;
            // 
            // ColumHaber
            // 
            ColumHaber.HeaderText = "Haber";
            ColumHaber.Name = "ColumHaber";
            ColumHaber.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnGrabar);
            panel1.Controls.Add(lbDebito);
            panel1.Controls.Add(lbCredito);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 273);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 92);
            panel1.TabIndex = 2;
            // 
            // lbCredito
            // 
            lbCredito.AutoSize = true;
            lbCredito.Location = new Point(527, 3);
            lbCredito.Name = "lbCredito";
            lbCredito.Size = new Size(75, 15);
            lbCredito.TabIndex = 1;
            lbCredito.Text = "Total crédito:";
            // 
            // lbDebito
            // 
            lbDebito.AutoSize = true;
            lbDebito.Location = new Point(391, 3);
            lbDebito.Name = "lbDebito";
            lbDebito.Size = new Size(72, 15);
            lbDebito.TabIndex = 0;
            lbDebito.Text = "Total débito:";
            lbDebito.Click += label3_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Image = Properties.Resources.check_1828643;
            btnGrabar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGrabar.Location = new Point(97, 39);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 2;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(274, 39);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button2_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(480, 39);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 365);
            Controls.Add(panel1);
            Controls.Add(panelCentro);
            Controls.Add(panelTop);
            Name = "Form1";
            Text = "juliApp";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lbDiario;
        private TextBox textBoxNum;
        private ComboBox comboBoxFecha;
        private ComboBox comboBoxDiario;
        private Label lbFecha;
        private Label lbNum;
        private Panel panelCentro;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn columCuenta;
        private DataGridViewTextBoxColumn ColumNombre;
        private DataGridViewTextBoxColumn ColumDesc;
        private DataGridViewTextBoxColumn ColumDebe;
        private DataGridViewTextBoxColumn ColumHaber;
        private Panel panel1;
        private Label lbDebito;
        private Label lbCredito;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnGrabar;
    }
}