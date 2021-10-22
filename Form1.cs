using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClassSuma ObjS = new Clases.ClassSuma();
        Clases.ClassResta ObjR = new Clases.ClassResta();
        Clases.ClassMultiplicacion ObjM = new Clases.ClassMultiplicacion();
        Clases.ClassDivision ObjD = new Clases.ClassDivision();

        private void button3_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(TBXpantalla.Text);
            double sum;
            double res;
            double mul;
            double div;

            switch (operador)
            {
                case "+":
                    sum = ObjS.Sumar((primero), (segundo));
                    TBXpantalla.Text = sum.ToString();
                    break;

                case "-":
                    res = ObjR.Restar((primero), (segundo));
                    TBXpantalla.Text = res.ToString();
                    break;

                case "*":
                    mul = ObjM.Multiplicar((primero), (segundo));
                    TBXpantalla.Text = mul.ToString();
                    break;

                case "/":
                    div = ObjD.Dividir((primero), (segundo));
                    TBXpantalla.Text = div.ToString();
                    break;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "3";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TBXpantalla.Text = TBXpantalla.Text + "9";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(TBXpantalla.Text);
            TBXpantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(TBXpantalla.Text);
            TBXpantalla.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(TBXpantalla.Text);
            TBXpantalla.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(TBXpantalla.Text);
            TBXpantalla.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            TBXpantalla.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (TBXpantalla.Text.Length == 1)
                TBXpantalla.Text = "";
            else
                TBXpantalla.Text = TBXpantalla.Text.Substring(0, TBXpantalla.Text.Length - 1);
        }
    }
}
