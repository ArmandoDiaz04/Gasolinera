using GasolineraDos.Administrador;
using GasolineraDos.Conexion;
using GasolineraDos.Models;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
        private double puntos;
        private int bomba;
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

        private double precioGasolina()
        {
            bomba = 0;
        
            if (this.comboBox1.Text.Trim() == "SUPER")
            {
                bomba = 1;
            }
            else if (this.comboBox1.Text.Trim() == "REGULAR")
            {
                bomba = 2;
            }
            else if (this.comboBox1.Text.Trim() == "DIESEL")
            {
                bomba = 3;
            }
            else if (this.comboBox1.Text.Trim() == "---Seleccione una opción--")
            {
                MessageBox.Show("Seleccione un tipo de gasolina");
            }

            using (var context = new ContextBd())
            {
                // ID de la bomba que deseas consultar

                var precio = context.Bombas
                    .Where(b => b.ID_BOMBA == bomba)
                    .Select(b => b.Precio)
                    .FirstOrDefault();

                if (precio != null)
                {
                    return (double)precio;
                }
                else
                {
                    // No se encontró el precio para la bomba especificada
                    MessageBox.Show("No se encontró el precio para la bomba especificada.");
                    return 0;
                }
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
               

                string emple = Microsoft.VisualBasic.Interaction.InputBox("Ingrese id de empleado:", "Mensaje");
                int idep = int.Parse(emple);
                double pGaso = this.precioGasolina();

                if (int.TryParse(emple, out idep))
                {
                    if (pGaso>0)
                    {
                        double calcu = double.Parse(txtPrecio.Text);
                        double pre = calcu * pGaso;
                        double tt = pre * 1.13;
                        puntos = tt;
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
                        //ven.ReducirCantidadGasolina(bomba, (decimal)calcu);
                        this.GeneraFactura();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizr la venta.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    // El valor ingresado no es un número entero válido
                    // Muestra un mensaje de error
                    MessageBox.Show("El valor ingresado no es un número entero válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
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


                string emple = Microsoft.VisualBasic.Interaction.InputBox("Ingrese id de empleado:", "Mensaje");
                int idep = int.Parse(emple);
                double pGaso = this.precioGasolina();

                if (int.TryParse(emple, out idep))
                {
                    if (pGaso>0)
                    {
                        double calcu = double.Parse(txtPrecio.Text);
                        double gal = calcu - (calcu * 0.13) / pGaso;
                        puntos = gal;
                        venta = new Venta
                        {
                            IdEmpleado = idep,
                            //IdCliente = 1,
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
                        this.GeneraFactura();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo realizr la venta.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    // El valor ingresado no es un número entero válido
                    // Muestra un mensaje de error
                    MessageBox.Show("El valor ingresado no es un número entero válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
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
        private void GeneraFactura()
        {
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

           // document.Add(new iText.Layout.Element.Paragraph("Cliente: ............................" + venta.Cliente)
             //   .SetFont(font));
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

        private void button11_Click_2(object sender, EventArgs e)
        {
            string cliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Dui del Cliente:", "Canje de puntos");
            int idCliente = int.Parse(cliente);

            using (var context = new ContextBd())
            {
                var idClienteParam = new SqlParameter("@IdCliente", idCliente);
                var puntosParam = new SqlParameter("@Puntos", Convert.ToInt32(venta.Precio));

                try
                {
                    int rowsAffected = context.Database.ExecuteSqlRaw("EXEC AcumularPuntos @IdCliente, @Puntos", idClienteParam, puntosParam);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Se han acumulado los puntos de manera exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El cliente con el ID especificado no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("¡Ups! ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button12_Click(object sender, EventArgs e)
        {

            string idClienteInput = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Dui del Cliente:", "Cobro con puntos");
            int idCliente;

            if (int.TryParse(idClienteInput, out idCliente))
            {
                try
                {
                 

                    string emple = Microsoft.VisualBasic.Interaction.InputBox("Ingrese id de empleado:", "Mensaje");
                    int idep = int.Parse(emple);
                    if (int.TryParse(idClienteInput, out idCliente))
                    {
                        double pGaso = this.precioGasolina();

                        if (pGaso>0)
                        {
                            double calcu = double.Parse(txtPrecio.Text);
                            double gal = calcu - (calcu * 0.13) / pGaso;
                            puntos = gal;
                            venta = new Venta
                            {
                                IdEmpleado = idep,
                                //IdCliente = 1,
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


                            using (var context = new ContextBd())
                            {
                                var cliente = context.Clientes.FirstOrDefault(c => c.IdCliente == Convert.ToInt32(idCliente));

                                if (cliente != null)
                                {
                                    if (cliente.Puntos >= venta.Precio)
                                    {
                                        // Utilizar una nueva variable 'puntosARestar'
                                        int puntosARestar = Convert.ToInt32(venta.Precio);

                                        var puntosParam = new SqlParameter("@puntos_restar", puntosARestar);
                                        var idClienteParam = new SqlParameter("@id_cliente", idCliente);

                                        context.Database.ExecuteSqlRaw("EXEC RestarPuntos @id_cliente, @puntos_restar", idClienteParam, puntosParam);

                                        // Los puntos se restaron correctamente
                                        MessageBox.Show("Se han realizado el pago con puntos de manera exitosa.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        ven.CrearVenta(venta, detalleVenta);
                                        this.GeneraFactura();
                                    }
                                    else
                                    {
                                        // Puntos insuficientes
                                        MessageBox.Show("Puntos insuficientes para realizar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    // Cliente no encontrado
                                    MessageBox.Show("No existe el cliente consultado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizr la venta.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        // El valor ingresado no es un número entero válido
                        // Muestra un mensaje de error
                        MessageBox.Show("El identificador de empleado no es válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (Exception ex)
                {
                    // Ocurrió un error al restar los puntos
                    // Manejar el error adecuadamente
                    Console.WriteLine("Error al restar puntos: " + ex.Message);
                }
            }
            else
            {
                // El valor ingresado no es un número entero válido
                // Muestra un mensaje de error
                MessageBox.Show("El DUI ingresado no existe en el sistema.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }

        private void button13_Click(object sender, EventArgs e)
        {

            Cliente cli = new Cliente();

            string dui = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el DUI:", "Obtener puntos y nombre del cliente", "");
            int idCliente;

           

            if (int.TryParse(dui, out idCliente))
            {
                cli.ObtenerPuntosYNombreCliente(idCliente);
            }
            else
            {
                MessageBox.Show("El DUI ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
