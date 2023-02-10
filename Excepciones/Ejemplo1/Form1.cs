using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, resultado;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                resultado = a / b;
                lblResultado.Text = "= " + resultado;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Cargar solo numeros");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No dividir por 0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido " + ex.Message);
            }
            finally
            {
                // operacion sensible que se ejecuta si o si,
                // sin importar si hay excepciones o no
            }
        }
    }
}
