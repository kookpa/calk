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

        private void Form1_Load(object sender, EventArgs e)
        {

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
            else if (operador == "x")
            {
                resultado = num1 * num2;
            }
            else if (operador == "/")
            {
                resultado = num1 / num2;
            }
            return resultado;
        }
        public int resultadosoma(int num1, int num2)
        {
            int resultado = 0;
            resultado = num1 + num2;
            return resultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2= int.Parse(txbnumero2.Text);

            Button botao = (Button)sender;
            string operadorSelecionado = botao.Text;
            
            int total;
            total = calculos(numero1, numero2, "+");
            int resultado;

            resultado = numero1 + numero2;
            lbresultado.Text = resultado.ToString();
        }

        public int resultadomenos(int num1, int num2)
        {
            int resultado = 0;
            resultado = num1 - num2;
            return resultado;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2 = int.Parse(txbnumero2.Text);
            int resultado;
            int total;

            total = calculos(numero1, numero2, "-");

            resultado = numero1 - numero2;
            lbresultado.Text = resultado.ToString();

        }
        public int resultadovezes(int num1, int num2)
        {
            int resultado = 0;
            resultado = num1 * num2;
            return resultado;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2 = int.Parse(txbnumero2.Text);

            int resultado;
            int total;

            total = calculos(numero1, numero2, "*");
            resultado = numero1 * numero2;
            lbresultado.Text = resultado.ToString();
        }
        public int resultadodividir(int num1, int num2)
        {
            int resultado = 0;
            resultado = num1 / num2;
            return resultado;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txbnumero1.Text);
            int numero2 = int.Parse(txbnumero2.Text);

            int resultado;
            int total;

            total = calculos(numero1, numero2, "/");
            resultado = numero1 / numero2;
            lbresultado.Text = resultado.ToString();
        }
    }
}
