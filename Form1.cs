using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyCambioGrupo4_IIB
{
    public partial class Form1 : Form
    {
        // Definición de las denominaciones de monedas
        private int[] denominaciones = { 100, 50, 25, 10, 5, 1 };
        //monedas disponibles de cada denominación
        private int[] monedasDisponibles = { 10, 10, 10, 10, 10, 100 };

        public Form1()
        {
            InitializeComponent();
            //imagen de las monedas
            var originalImage = Image.FromFile(@"monedas.png");
            var resizedImage = new Bitmap(originalImage, new Size(140, 320));
            ilabel.Size = resizedImage.Size;
            ilabel.Image = resizedImage;
            originalImage.Dispose();
            // inhabilitar cuadros inecesarios
            tBCambio.Enabled = false;
            lBResultDinamico.Enabled = false;
            lBResultVoraz.Enabled = false;
            tBD100.Enabled = false;
            tBD50.Enabled = false;
            tBD25.Enabled = false;
            tBD10.Enabled = false;
            tBD5.Enabled = false;
            tBD1.Enabled = false;
            tBV100.Enabled = false;
            tBV50.Enabled = false;
            tBV25.Enabled = false;
            tBV10.Enabled = false;
            tBV5.Enabled = false;
            tBV1.Enabled = false;
            txtExecutionTimeD.Enabled = false;
            txtExecutionTimeV.Enabled = false;
        }

        private void bCambio_Click(object sender, EventArgs e)
        {
            // Leer los valores de los textBox
            double total = Convert.ToDouble(tBTotal.Text);
            double precio = Convert.ToDouble(tBPrecio.Text);
            //verificar que el total sea mayor al precio
            if (total <= precio)
            {
                MessageBox.Show("El total debe ser mayor que el precio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método si la validación falla
            }
            else
            {
                //inhabilitar cuadros para evitar ediciones
                tBTotal.Enabled = false;
                tBPrecio.Enabled = false;
                // Calcular el cambio
                double cambio = total - precio;
                // Mostrar el cambio
                tBCambio.Text = cambio.ToString("C2");
                // Realizar el cambio con Programación Dinámica
                int[] cambioDinamico = CalcularCambioDinamico(cambio);
                // Realizar el cambio con Algoritmo Voraz
                int[] cambioVoraz = CalcularCambioVoraz(cambio);
                // Mostrar los resultados en los listBox y text boxes
                MostrarCambioEnListBox(lBResultDinamico, cambioDinamico);
                MostrarCambioEnListBox(lBResultVoraz, cambioVoraz);
                MostrarMonedasEnTextBoxes(cambioDinamico, tBD100, tBD50, tBD25, tBD10, tBD5, tBD1);
                MostrarMonedasEnTextBoxes(cambioVoraz, tBV100, tBV50, tBV25, tBV10, tBV5, tBV1);
            }
        }

        private void MostrarMonedasEnTextBoxes(int[] cambio, TextBox tB100, TextBox tB50, TextBox tB25, TextBox tB10, TextBox tB5, TextBox tB1)
        {
            if (cambio != null)
            {
                tB100.Text = cambio[0].ToString();
                tB50.Text = cambio[1].ToString();
                tB25.Text = cambio[2].ToString();
                tB10.Text = cambio[3].ToString();
                tB5.Text = cambio[4].ToString();
                tB1.Text = cambio[5].ToString();
            }
            else
            {
                tB100.Text = "X";
                tB50.Text = "X";
                tB25.Text = "X";
                tB10.Text = "X";
                tB5.Text = "X";
                tB1.Text = "X";
            }
        }

        //memoización para ver la cantidad minima de monedas
        private int[] CalcularCambioDinamico(double cambio)
        {
            lBDinamico.Items.Add($"Cambio al que debe llegar: {cambio.ToString("N2")} ");
            int[] cantidadMonedas = new int[denominaciones.Length];
            int cambioCentavos = (int)(cambio * 100);
            lBDinamico.Items.Add($"Cambio al que debe llegar en centavos: {cambioCentavos} \n");
            DateTime startTime = DateTime.Now;
            int[][] memoizationTable = new int[denominaciones.Length][];
            for (int i = 0; i < denominaciones.Length; i++)
            {
                memoizationTable[i] = new int[cambioCentavos + 1];
                for (int j = 0; j <= cambioCentavos; j++)
                {
                    memoizationTable[i][j] = -1; // Initialize with a value indicating uncalculated
                }
            }
            for (int i = 0; i < denominaciones.Length; i++)
            {
                lBDinamico.Items.Add($" ");
                //imprime la denominación de la moneda
                lBDinamico.Items.Add($"\n\tMonedas de {(denominaciones[i] == 100 ? "1 $" : $"{denominaciones[i]} ctvs")}");
                int numMonedas = Math.Min(cambioCentavos / denominaciones[i], monedasDisponibles[i]);
                cantidadMonedas[i] = numMonedas;
                //imprime la cantidad de monedas que se utilizó en el cambio
                lBDinamico.Items.Add($"Cantidad de monedas utilizadas: {cantidadMonedas[i]} ");
                monedasDisponibles[i] -= numMonedas;
                //imprime las monedas disponibles despues de restar las usadas para dar el cambio
                lBDinamico.Items.Add($"Monedas disponibles: {monedasDisponibles[i]} ");
                cambioCentavos -= numMonedas * denominaciones[i];
                //imprime el cambio que todavía no se toma en cuenta
                lBDinamico.Items.Add($"Cambio faltante: {cambioCentavos} ");
            }
            DateTime endTime = DateTime.Now;
            TimeSpan executionTime = endTime - startTime;
            txtExecutionTimeD.Text = executionTime.TotalMilliseconds.ToString();

            return cambioCentavos == 0 ? cantidadMonedas : null;
        }


        private int[] CalcularCambioVoraz(double cambio)
        {
            lBVoraz.Items.Add($"Cambio al que debe llegar: {cambio.ToString("N2")} ");
            int[] cantidadMonedas = new int[denominaciones.Length];

            int cambioCentavos = (int)(cambio * 100);
            lBVoraz.Items.Add($"Cambio al que debe llegar en centavos: {cambioCentavos} \n");

            DateTime startTime = DateTime.Now;
            for (int i = 0; i < denominaciones.Length; i++)
            {
                lBVoraz.Items.Add($" ");
                lBVoraz.Items.Add($"\n\tMonedas de {(denominaciones[i] == 100 ? "1 $" : $"{denominaciones[i]} ctvs")}");
                cantidadMonedas[i] = cambioCentavos / denominaciones[i];
                lBVoraz.Items.Add($"Cantidad de monedas: {cantidadMonedas[i]} ");
                cambioCentavos -= cantidadMonedas[i] * denominaciones[i];
                lBVoraz.Items.Add($"Cambio faltante: {cambioCentavos} ");
            }
            DateTime endTime = DateTime.Now;
            TimeSpan executionTime = endTime - startTime;
            txtExecutionTimeV.Text = executionTime.TotalMilliseconds.ToString();

            return cantidadMonedas;
        }

        private void MostrarCambioEnListBox(ListBox listBox, int[] cambio)
        {
            listBox.Items.Clear();
            if (cambio != null)
            {
                for (int i = 0; i < cambio.Length; i++)
                {
                    listBox.Items.Add($"${denominaciones[i] / 100}.{denominaciones[i] % 100:D2}: {cambio[i]}");
                }
            }
            else
            {
                listBox.Items.Add("Falta de monedas para dar cambio.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar los TextBox y ListBox
            tBTotal.Clear();
            tBPrecio.Clear();
            tBCambio.Clear();
            tBD100.Clear();
            tBD50.Clear();
            tBD25.Clear();
            tBD10.Clear();
            tBD5.Clear();
            tBD1.Clear();
            tBV100.Clear();
            tBV50.Clear();
            tBV25.Clear();
            tBV10.Clear();
            tBV5.Clear();
            tBV1.Clear();
            txtExecutionTimeD.Clear();
            txtExecutionTimeV.Clear();

            lBResultDinamico.Items.Clear();
            lBResultVoraz.Items.Clear();
            lBDinamico.Items.Clear();
            lBVoraz.Items.Clear();
            lBDinamico.Items.Clear();
            lBVoraz.Items.Clear();

            // Habilitar los TextBox y ListBox para recibir ingresos nuevamente
            tBTotal.Enabled = true;
            tBPrecio.Enabled = true;
        }
        //Inhabilitar la edición de los listbox, permitiendo el mover el scroll
        private void lBDinamico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void lBVoraz_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //VALIDACIONES
        private void tBTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número, coma o tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número, coma o tecla de retroceso, cancelar el evento KeyPress
                e.Handled = true;
            }

            // Si ya hay una coma en el texto, evitar agregar otra coma
            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }

            // Validar que después de la coma solo se ingresen dos decimales
            if (((TextBox)sender).Text.Contains(",") && ((TextBox)sender).Text.Split(',')[1].Length >= 2 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void tBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si el carácter ingresado es un número, coma o tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)Keys.Back)
            {
                // Si no es un número, coma o tecla de retroceso, cancelar el evento KeyPress
                e.Handled = true;
            }

            // Si ya hay una coma en el texto, evitar agregar otra coma
            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }

            // Validar que después de la coma solo se ingresen dos decimales
            if (((TextBox)sender).Text.Contains(",") && ((TextBox)sender).Text.Split(',')[1].Length >= 2 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}




