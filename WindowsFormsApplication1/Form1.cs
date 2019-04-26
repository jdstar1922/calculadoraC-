using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        char operacion = 'N';
        int numero1 = 0;
        int numero2 = 0;
        int resultado = 0;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "0";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt_Pantalla.Text = txt_Pantalla.Text + "9";
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion = '+';
            numero1 = Convert.ToInt32(txt_Pantalla.Text);
            txt_Pantalla.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion = '-';
            numero1 = Convert.ToInt32(txt_Pantalla.Text);
            txt_Pantalla.Text = "";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacion = '*';
            numero1 = Convert.ToInt32(txt_Pantalla.Text);
            txt_Pantalla.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacion = '/';
            numero1 = Convert.ToInt32(txt_Pantalla.Text);
            txt_Pantalla.Text = "";
        }
        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            operacion = '%';
            numero1 = Convert.ToInt32(txt_Pantalla.Text);
            txt_Pantalla.Text = "";
        }
        private void btnRaiz_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(txt_Pantalla.Text);
            ClaseCalculadora calculadora = new ClaseCalculadora(numero1, 0, resultado, operacion);
            calculadora.Raiz();
            txt_Pantalla.Text = calculadora.Raiz().ToString();
        }  

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToInt32(txt_Pantalla.Text);
            ClaseCalculadora calculadora = new ClaseCalculadora(numero1, numero2, resultado, operacion);
            switch (calculadora.OperacionPublica)
            {
                case '+':
                    {
                        resultado = calculadora.Sumar();
                        break;
                    }
                case '-':
                    {
                        resultado = calculadora.Restar();
                        break;
                    }
                case '*':
                    {
                        resultado = calculadora.Multiplicar();
                        break;
                    }
                case '/':
                    {
                        resultado = calculadora.Dividir();
                        break;
                    }
                case '%':
                    {
                        resultado = calculadora.Porcentaje();
                        break;
                    }
            }
            txt_Pantalla.Text = resultado.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operacion = 'N';
            txt_Pantalla.Text = "";
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            if (txt_Pantalla.Text != "")
            {
                String cadena = txt_Pantalla.Text;
                cadena = cadena.Substring(0, cadena.Length - 1);
                txt_Pantalla.Text = cadena;
            }
            
        }

        
    }
}
