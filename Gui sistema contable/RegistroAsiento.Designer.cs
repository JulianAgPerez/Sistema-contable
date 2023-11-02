using System.Windows.Forms;

namespace Gui_sistema_contable
{
    partial class RegistroAsiento
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

        public void RecalcularSuma(int columnIndex, Label label, String msj)
        {
            int suma = 0;
            // Recorre todas las filas del DataGridView
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[columnIndex].Value != null)
                {
                    suma += Convert.ToInt32(dataGridView1.Rows[i].Cells[columnIndex].Value);
                }
            }
            label.Text = msj + "total: " + suma.ToString();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAsiento));
            panelTop = new Panel();
            lbHasta = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            lbDesde = new Label();
            lbNum = new Label();
            lbDiario = new Label();
            textBoxNum = new TextBox();
            comboBoxDiario = new ComboBox();
            panelCentro = new Panel();
            dataGridView1 = new DataGridView();
            ColumCuenta = new DataGridViewComboBoxColumn();
            columNombre = new DataGridViewTextBoxColumn();
            ColumDesc = new DataGridViewTextBoxColumn();
            ColumDebe = new DataGridViewTextBoxColumn();
            ColumHaber = new DataGridViewTextBoxColumn();
            panelBajo = new Panel();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            lbDebito = new Label();
            lbCredito = new Label();
            panelTop.SuspendLayout();
            panelCentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelBajo.SuspendLayout();
            SuspendLayout();
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
            panelTop.Size = new Size(673, 88);
            panelTop.TabIndex = 0;
            // 
            // lbHasta
            // 
            lbHasta.AutoSize = true;
            lbHasta.Location = new Point(499, 29);
            lbHasta.Name = "lbHasta";
            lbHasta.Size = new Size(40, 15);
            lbHasta.TabIndex = 8;
            lbHasta.Text = "Hasta:";
            lbHasta.Click += label1_Click;
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
            lbDesde.Click += lbFecha_Click;
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
            textBoxNum.BackColor = Color.Gainsboro;
            textBoxNum.Cursor = Cursors.Hand;
            textBoxNum.Enabled = false;
            textBoxNum.Location = new Point(214, 26);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.ReadOnly = true;
            textBoxNum.Size = new Size(60, 23);
            textBoxNum.TabIndex = 2;
            // 
            // comboBoxDiario
            // 
            comboBoxDiario.Cursor = Cursors.Hand;
            comboBoxDiario.FormattingEnabled = true;
            comboBoxDiario.Location = new Point(72, 26);
            comboBoxDiario.Name = "comboBoxDiario";
            comboBoxDiario.Size = new Size(69, 23);
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
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumCuenta, columNombre, ColumDesc, ColumDebe, ColumHaber });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(673, 189);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumCuenta
            // 
            ColumCuenta.HeaderText = "Cuenta";
            ColumCuenta.Items.AddRange(new object[] { "1000: Vender merca", "1001        Comprar fafa", "1002", "1003", "1004", "1005", "2000", "2001" });
            ColumCuenta.Name = "ColumCuenta";
            ColumCuenta.Resizable = DataGridViewTriState.True;
            ColumCuenta.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // columNombre
            // 
            columNombre.HeaderText = "Nombre";
            columNombre.Name = "columNombre";
            columNombre.ReadOnly = true;
            columNombre.Resizable = DataGridViewTriState.True;
            // 
            // ColumDesc
            // 
            ColumDesc.HeaderText = "Descripcion";
            ColumDesc.Name = "ColumDesc";
            // 
            // ColumDebe
            // 
            ColumDebe.HeaderText = "Debe";
            ColumDebe.Name = "ColumDebe";
            // 
            // ColumHaber
            // 
            ColumHaber.HeaderText = "Haber";
            ColumHaber.Name = "ColumHaber";
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
            panelBajo.Location = new Point(0, 270);
            panelBajo.Name = "panelBajo";
            panelBajo.Size = new Size(673, 95);
            panelBajo.TabIndex = 2;
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
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(133, 48);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // lbDebito
            // 
            lbDebito.AutoSize = true;
            lbDebito.Location = new Point(391, 3);
            lbDebito.Name = "lbDebito";
            lbDebito.Size = new Size(72, 15);
            lbDebito.TabIndex = 0;
            lbDebito.Text = "Debito total:";
            lbDebito.Click += label3_Click;
            // 
            // lbCredito
            // 
            lbCredito.AutoSize = true;
            lbCredito.Location = new Point(527, 3);
            lbCredito.Name = "lbCredito";
            lbCredito.Size = new Size(76, 15);
            lbCredito.TabIndex = 1;
            lbCredito.Text = "Credito total:";
            // 
            // RegistroAsiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 365);
            Controls.Add(panelBajo);
            Controls.Add(panelCentro);
            Controls.Add(panelTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistroAsiento";
            Text = "Registro de nuevo asiento contable";
            Load += Form1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCentro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelBajo.ResumeLayout(false);
            panelBajo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lbDiario;
        private TextBox textBoxNum;
        private ComboBox comboBoxDiario;
        private Label lbDesde;
        private Label lbNum;
        private Panel panelCentro;
        private DataGridView dataGridView1;
        private Panel panelBajo;
        private Label lbDebito;
        private Label lbCredito;
        private DateTimePicker dateTimePicker1;
        private Label lbHasta;
        private DateTimePicker dateTimePicker2;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridViewComboBoxColumn ColumCuenta;
        private DataGridViewTextBoxColumn columNombre;
        private DataGridViewTextBoxColumn ColumDesc;
        private DataGridViewTextBoxColumn ColumDebe;
        private DataGridViewTextBoxColumn ColumHaber;
    }
}