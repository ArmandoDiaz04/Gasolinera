using GasolineraDos.Administrador;
using GasolineraDos.Conexion;
using GasolineraDos.Models;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.Data.SqlClient;
using System;
using System.Diagnostics;
using iText.Layout;
using iText.Kernel.Font;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.IO.Font;
using iText.IO.Font.Constants;
using System.Runtime.InteropServices;

namespace Gasolinera
{
    public partial class frmVenta : Form
    {
        private TextBox textField;
        private ContextBd contexto;
        private FileInfo rutaArchivo;
        private Ventas ven;
        private Venta venta;
        private DetalleVenta detalleVenta;

        public frmVenta()
        {
            InitializeComponent();
            llenarCombo();
            ven = new Ventas();
        }
        public void llenarCombo()
        {
            string[] elementos = { "---Seleccione una opción--", "SUPER", "REGULAR", "DIESEL" };
            this.comboBox1.Items.AddRange(elementos);
            comboBox1.SelectedIndex = 0;
        }
        private void frmVenta_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textField.Text += button.Text;
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                int bomba = 0;
                double pGaso = 0;

                if (this.comboBox1.Text.Trim() == "SUPER")
                {
                    bomba = 1;
                    pGaso = 4.42;
                }
                else if (this.comboBox1.Text.Trim() == "REGULAR")
                {
                    bomba = 2; pGaso = 4.13;
                }
                else if (this.comboBox1.Text.Trim() == "DIESEL")
                {
                    bomba = 3;
                    pGaso = 3.65;
                }
                else if (this.comboBox1.Text.Trim() == "---Seleccione una opción--")
                {
                    MessageBox.Show("Seleccione un tipo de gasolina");
                    return;
                }

                string emple = Microsoft.VisualBasic.Interaction.InputBox("Ingrese id de empleado:", "Mensaje");
                int idep = int.Parse(emple);

                double calcu = double.Parse(txtPrecio.Text);
                double pre = calcu * pGaso;
                double tt = pre * 1.13;

                venta = new Venta
                {
                    IdEmpleado = idep,
                    IdCliente = 1,
                    Precio = pre,
                    ImpuestoF = 2.0,
                    IVA = 0.13,
                    Total = tt
                };

                // detalle insert 
                detalleVenta = new DetalleVenta
                {
                    ID_BOMBA = bomba,
                    Cantidad = calcu,
                    Descuento = 0,
                    Precio = tt
                };

                ven.CrearVenta(venta, detalleVenta);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button2.Text;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtPrecio.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtPrecio.Text += button10.Text;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGalones_Click(object sender, EventArgs e)
        {

        }

        private void buttonDollar_Click(object sender, EventArgs e)
        {
            try
            {
                int bomba = 0;
                double pGaso = 0;

                if (this.comboBox1.Text.Trim() == "SUPER")
                {
                    bomba = 1;
                    pGaso = 4.42;
                }
                else if (this.comboBox1.Text.Trim() == "REGULAR")
                {
                    bomba = 2; pGaso = 4.13;
                }
                else if (this.comboBox1.Text.Trim() == "DIESEL")
                {
                    bomba = 3;
                    pGaso = 3.65;
                }
                else if (this.comboBox1.Text.Trim() == "---Seleccione una opción--")
                {
                    MessageBox.Show("Seleccione un tipo de gasolina");
                    return;
                }

                string emple = Microsoft.VisualBasic.Interaction.InputBox("Ingrese id de empleado:", "Mensaje");
                int idep = int.Parse(emple);

                double calcu = double.Parse(txtPrecio.Text);
                double gal = calcu - (calcu * 0.13) / pGaso;

                venta = new Venta
                {
                    IdEmpleado = idep,
                    IdCliente = 1,
                    Precio = calcu,
                    ImpuestoF = 2.0,
                    IVA = 0.13,
                    Total = gal
                };

                // detalle insert 
                detalleVenta = new DetalleVenta
                {
                    ID_BOMBA = bomba,
                    Cantidad = calcu,
                    Descuento = 0,
                    Precio = gal
                };

                ven.CrearVenta(venta, detalleVenta);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void button11_Click_1(object sender, EventArgs e)
        {  // Verificar si 'venta' es nulo
            if (venta == null)
            {
                MessageBox.Show("No se encontró información de venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nombreArchivo = $"factura{venta.IdVenta + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year}.pdf";
            string rutaDirectorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaArchivo = Path.Combine(rutaDirectorio, nombreArchivo);
            GenerarFactura(rutaArchivo);

            try
            {
                // Abrir el archivo PDF utilizando ShellExecute
                ShellExecute(IntPtr.Zero, "open", rutaArchivo, null, null, 5);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el archivo PDF. Asegúrate de tener una aplicación predeterminada asociada con la extensión '.pdf' en tu sistema.", "Error de Apertura de Archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ejecución de archivo por aplicacion predeterminada
        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        public void GenerarFactura(string rutaArchivo)
        {
            // Crear un documento PDF
            var pdfWriter = new iText.Kernel.Pdf.PdfWriter(rutaArchivo);
            var pdfDoc = new iText.Kernel.Pdf.PdfDocument(pdfWriter);
            var font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            var fontSize = 8f;

            // Ajustar el tamaño del PDF
            var pageSize = new iText.Kernel.Geom.PageSize(350f, pdfDoc.GetDefaultPageSize().GetHeight());
            pdfDoc.SetDefaultPageSize(pageSize);

            // Crear el contenido del documento
            var document = new iText.Layout.Document(pdfDoc);

            // Agregar el encabezado de la factura
            document.Add(new iText.Layout.Element.Paragraph("Factura de Venta")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(20)
                .SetFont(font));
            document.Add(new iText.Layout.Element.Paragraph("GASOLINERA DOS")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
               .SetFontSize(20)
               .SetFont(font));

            document.Add(new iText.Layout.Element.Paragraph("Santa Ana sur Pte. 1314 \n col. Valencia\n Tel 7842 2026")
               .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFont(font));

            document.Add(new iText.Layout.Element.Paragraph("Fecha: " + DateTime.Now.ToShortDateString())
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                .SetFont(font));

            document.Add(new iText.Layout.Element.Paragraph("<=====================================>"));

            // Agregar los detalles de la venta
            document.Add(new iText.Layout.Element.Paragraph("Detalle de la Venta:")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(16)
                .SetFont(font));

            document.Add(new iText.Layout.Element.Paragraph("ID Venta: ............................" + venta.IdVenta)
                .SetFont(font));
            document.Add(new iText.Layout.Element.Paragraph("ID BOMBA: ............................" + detalleVenta.ID_BOMBA)
               .SetFont(font));

            document.Add(new iText.Layout.Element.Paragraph("Cliente: ............................" + venta.Cliente)
                .SetFont(font));
            document.Add(new iText.Layout.Element.Paragraph("Precio:............................ $" + detalleVenta.Precio)
                .SetFont(font));
            document.Add(new iText.Layout.Element.Paragraph("Cantidad: ............................" + detalleVenta.Cantidad)
                .SetFont(font));
            document.Add(new iText.Layout.Element.Paragraph("Subtotal: ............................$" + venta.Precio)
                .SetFont(font));
            document.Add(new iText.Layout.Element.Paragraph("IVA: ............................$" + venta.IVA)
                .SetFont(font));
            document.Add(new iText.Layout.Element.Paragraph("Total: ............................$" + venta.Total)
                .SetFont(font));

            document.Add(new iText.Layout.Element.Paragraph("<=====================================>"));

            document.Add(new iText.Layout.Element.Paragraph("Gracias por preferirnos :3")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                .SetFontSize(16)
                .SetFont(font));

            // Cerrar el documento
            document.Close();

            // Abrir el archivo PDF
           // System.Diagnostics.Process.Start(rutaArchivo);
        }


    }
}
