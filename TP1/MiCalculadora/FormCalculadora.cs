using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Cerrara el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Convertirá el resultado, de existir, a binario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Operando().DecimalBinario(this.lblResultado.Text);
        }

        /// <summary>
        /// Convertirá el resultado, de existir y ser binario, a decimal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = new Operando().BinarioDecimal(this.lblResultado.Text);
        }

        /// <summary>
        /// Borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperator.Text = "";
            this.lblResultado.Text = "";
            //lstOperaciones.Items.Clear();
        }

        /// <summary>
        /// Borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            char CharOperator;
            char.TryParse(operador, out CharOperator);
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), CharOperator);
        }

        /// <summary>
        /// Recibirá los dos números y el operador para luego llamar al método Operar de Calculadora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            //string msj;
            double numero = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperator.Text);
            this.lblResultado.Text = numero.ToString();
            this.lstOperaciones.Items.Add($"{this.txtNumero1.Text} " +
                                          $"{this.cmbOperator.Text} " +
                                          $"{this.txtNumero2.Text} = " +
                                          $"{this.lblResultado.Text}");
        }

        /// <summary>
        /// Al cerrar de cualquier metodo, va a preguntar al usuario si quiere salir, si pone SI se cerrará, si contesta NO debe continuar en ejecucion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.No)
            {
                e.Cancel = true;//Cancela el cierre del formulario
            }
        }

        /// <summary>
        /// Llama al metodo limpiar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            Operando num1 = new Operando(txtNumero1.Text);
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            Operando num2 = new Operando(txtNumero2.Text);
        }
    }
}
