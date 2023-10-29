using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui_sistema_contable
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroAsiento reg = new RegistroAsiento();
            reg.FormClosed += (s, args) => this.Show();
            this.Hide();
            reg.Show();

        }

        private void btnGenerarImg_Click(object sender, EventArgs e)
        {
            // Crear un nuevo objeto Bitmap para la imagen
            using (Bitmap bitmap = new Bitmap(800, 600))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    // Rellenar el fondo con un color
                    g.Clear(Color.White);

                    // Definir la fuente y el pincel para el texto
                    using (Font font = new Font("Arial", 12))
                    using (SolidBrush brush = new SolidBrush(Color.Black))
                    {
                        // Definir los datos del libro diario
                        string[,] journalData = {
                        { "Fecha", "Cuenta", "Descripción", "Débito", "Crédito" },
                        { "01/10/2023", "Cuenta 1", "Venta de productos", "500", "" },
                        { "01/10/2023", "Cuenta 2", "Gastos de envío", "", "50" },
                        // Agrega más filas de datos aquí
                    };

                        // Definir la posición inicial para dibujar la tabla
                        int x = 50;
                        int y = 50;

                        // Dibujar encabezados de columna
                        for (int col = 0; col < journalData.GetLength(1); col++)
                        {
                            g.DrawString(journalData[0, col], font, brush, x, y);
                            x += 150; // Ajustar la posición X para la siguiente columna
                        }

                        // Dibujar filas de datos
                        y += 20; // Ajustar la posición Y para los datos
                        for (int row = 1; row < journalData.GetLength(0); row++)
                        {
                            x = 50; // Restablecer la posición X para la primera columna
                            for (int col = 0; col < journalData.GetLength(1); col++)
                            {
                                g.DrawString(journalData[row, col], font, brush, x, y);
                                x += 150; // Ajustar la posición X para la siguiente columna
                            }
                            y += 20; // Ajustar la posición Y para la siguiente fila
                        }
                    }
                }
                if (bitmap != null)
                {
                    // Guardar la imagen como un archivo
                    bitmap.Save("LibroDiario.png", ImageFormat.Png);
                    // Obtiene la carpeta donde se encuentra y asigna la imagen al pictureBox
                    //pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, "LibroDiario.png");
                }
                else
                {
                    // Manejar el caso en el que el bitmap no se creó correctamente
                    MessageBox.Show("No se pudo generar la imagen.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
