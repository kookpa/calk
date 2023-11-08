using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void escolhaOperador(int numero, string operadorEscolido)
        {
          lbtemp.Text = numero.ToString();
            lbop.Text = operadorEscolido;
            txbnumero1.Text = "";
        }
        public int calculos(int num1, int num2, string operador)
        {
            int resultado = 0;
            if (operador == "+")
            {
                resultado = num1 + num2;
            }
            else if (operador == "-")
            {
                resultado = num1 - num2;
            }
            else if (operador == "*")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/")
            {
                resultado = num1 / num2;
            }
            return resultado;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2 = 0;
            int total;

            //total = calculos(numero1, numero2);
            int resultado;

            resultado = numero1 + numero2;
             lbresultado.Text = resultado.ToString();
            escolhaOperador(numero1, "+");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2 = 0;
            int resultado;
            int total;

           // total = calculos(numero1, numero2, "-");

            resultado = numero1 - numero2;
            //lbresultado.Text = resultado.ToString();
            

        }
        private void button4_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2 = 0;

            int resultado;
            int total;

            //total = calculos(numero1, numero2, "*");
            resultado = numero1 * numero2;
            //lbresultado.Text = resultado.ToString();
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2 = 0;

            int resultado;
            int total;

            //total = calculos(numero1, numero2, "/");
             resultado = numero1 / numero2;
            //lbresultado.Text = resultado.ToString();
            
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            Button valorbotao = (Button)sender;
            // MessageBox.Show(valorbotao.Text);
            //txbnumero1.Text = txbnumero1 + valorbotao.Text;

            txbnumero1.Text += valorbotao.Text;
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbnumero1.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (txbnumero1.Text != "" && txbnumero1.Text != "Error")
            { int numero1 = int.Parse(txbnumero1.Text);
                int numero2 = 0;
                int total;
                Button botao = (Button)sender;
                string operadorSelecionado = botao.Text;
                escolhaOperador(numero1, operadorSelecionado);
            }
            else
            {
                lbtemp.Text = "Error";
            }
        }
    }
}
