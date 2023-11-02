namespace Gui_sistema_contable
{
    public partial class RegistroAsiento : Form
    {
        public RegistroAsiento()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++) // Agregar 10 filas al cargar el formulario
            {
                dataGridView1.Rows.Add();
            }
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                // Suponiendo que deseas calcular la suma de las columnas 2 y 3
                if (e.ColumnIndex == 3)
                    RecalcularSuma(3, lbDebito, "Debito ");
                else
                    RecalcularSuma(4, lbCredito, "Credito ");
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbFecha_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}