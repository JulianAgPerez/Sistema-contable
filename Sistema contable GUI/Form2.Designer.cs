namespace Sistema_contable_GUI
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
            panelBajo = new Panel();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            lbDebito = new Label();
            lbCredito = new Label();
            panelCentro = new Panel();
            dataGridView1 = new DataGridView();
            columCuenta = new DataGridViewTextBoxColumn();
            ColumNombre = new DataGridViewTextBoxColumn();
            ColumDesc = new DataGridViewTextBoxColumn();
            ColumDebe = new DataGridViewTextBoxColumn();
            ColumHaber = new DataGridViewTextBoxColumn();
            panelTop = new Panel();
            lbHasta = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lbDesde = new Label();
            lbNum = new Label();
            lbDiario = new Label();
            textBoxNum = new TextBox();
            comboBoxDiario = new ComboBox();
            panelBajo.SuspendLayout();
            panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelBajo
            // 
            panelBajo.BackColor = Color.Beige;
            panelBajo.Controls.Add(btnSalir);
            panelBajo.Controls.Add(btnEliminar);
            panelBajo.Controls.Add(btnGuardar);
            panelBajo.Controls.Add(lbDebito);
            panelBajo.Controls.Add(lbCredito);
            panelBajo.Dock = DockStyle.Bottom;
            panelBajo.Location = new Point(0, 274);
            panelBajo.Name = "panelBajo";
            panelBajo.Size = new Size(665, 95);
            panelBajo.TabIndex = 8;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(464, 48);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(301, 48);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(133, 48);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lbDebito
            // 
            lbDebito.AutoSize = true;
            lbDebito.Location = new Point(391, 3);
            lbDebito.Name = "lbDebito";
            lbDebito.Size = new Size(72, 15);
            lbDebito.TabIndex = 0;
            lbDebito.Text = "Total débito:";
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
            // panelCentro
            // 
            panelCentro.Controls.Add(dataGridView1);
            panelCentro.Location = new Point(-4, 84);
            panelCentro.Name = "panelCentro";
            panelCentro.Size = new Size(673, 189);
            panelCentro.TabIndex = 7;
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
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ActiveCaption;
            panelTop.Controls.Add(lbHasta);
            panelTop.Controls.Add(dateTimePicker2);
            panelTop.Controls.Add(dateTimePicker1);
            panelTop.Controls.Add(lbDesde);
            panelTop.Controls.Add(lbNum);
            panelTop.Controls.Add(lbDiario);
            panelTop.Controls.Add(textBoxNum);
            panelTop.Controls.Add(comboBoxDiario);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(665, 88);
            panelTop.TabIndex = 6;
            // 
            // lbHasta
            // 
            lbHasta.AutoSize = true;
            lbHasta.Location = new Point(499, 29);
            lbHasta.Name = "lbHasta";
            lbHasta.Size = new Size(40, 15);
            lbHasta.TabIndex = 8;
            lbHasta.Text = "Hasta:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(545, 26);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(102, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(381, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(102, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.Value = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // lbDesde
            // 
            lbDesde.AutoSize = true;
            lbDesde.Location = new Point(334, 29);
            lbDesde.Name = "lbDesde";
            lbDesde.Size = new Size(42, 15);
            lbDesde.TabIndex = 5;
            lbDesde.Text = "Desde:";
            // 
            // lbNum
            // 
            lbNum.AutoSize = true;
            lbNum.Location = new Point(171, 29);
            lbNum.Name = "lbNum";
            lbNum.Size = new Size(37, 15);
            lbNum.TabIndex = 4;
            lbNum.Text = "Num:";
            // 
            // lbDiario
            // 
            lbDiario.AutoSize = true;
            lbDiario.Location = new Point(25, 29);
            lbDiario.Name = "lbDiario";
            lbDiario.Size = new Size(41, 15);
            lbDiario.TabIndex = 3;
            lbDiario.Text = "Diario:";
            // 
            // textBoxNum
            // 
            textBoxNum.Cursor = Cursors.Hand;
            textBoxNum.Location = new Point(214, 26);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(60, 23);
            textBoxNum.TabIndex = 2;
            textBoxNum.TextChanged += textBoxNum_TextChanged;
            // 
            // comboBoxDiario
            // 
            comboBoxDiario.Cursor = Cursors.Hand;
            comboBoxDiario.FormattingEnabled = true;
            comboBoxDiario.Location = new Point(72, 26);
            comboBoxDiario.Name = "comboBoxDiario";
            comboBoxDiario.Size = new Size(69, 23);
            comboBoxDiario.TabIndex = 0;
            comboBoxDiario.SelectedIndexChanged += comboBoxDiario_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 369);
            Controls.Add(panelBajo);
            Controls.Add(panelCentro);
            Controls.Add(panelTop);
            Name = "Form2";
            Text = "Form2";
            panelBajo.ResumeLayout(false);
            panelBajo.PerformLayout();
            panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBajo;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnGuardar;
        private Label lbDebito;
        private Label lbCredito;
        private Panel panelCentro;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn columCuenta;
        private DataGridViewTextBoxColumn ColumNombre;
        private DataGridViewTextBoxColumn ColumDesc;
        private DataGridViewTextBoxColumn ColumDebe;
        private DataGridViewTextBoxColumn ColumHaber;
        private Panel panelTop;
        private Label lbHasta;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label lbDesde;
        private Label lbNum;
        private Label lbDiario;
        private TextBox textBoxNum;
        private ComboBox comboBoxDiario;
    }
}