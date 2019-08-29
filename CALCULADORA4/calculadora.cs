using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA4
{
    public partial class calculadora : Form
    {
        bool secuencia = true, punto = true;
        double primero;
        double segundo;
        double resultado;
        string operacion, borrado;
        public calculadora()
        {
            InitializeComponent();
        }
        clases.Classuma obj = new clases.Classuma();
        clases.Clasresta obj2 = new clases.Clasresta();
        clases.Clasmultiplicacion obj3 = new clases.Clasmultiplicacion();
        clases.Clasdivision obj4 = new clases.Clasdivision();
        clases.Clasporciento obj5 = new clases.Clasporciento();
        private void Button0_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textRESULTADO.Text = textRESULTADO.Text + "9";
        }

        private void ButtonPUNTO_Click(object sender, EventArgs e)
        {
            if (punto == true)
            {
                textRESULTADO.Text = textRESULTADO.Text + ".";
                punto = false;
            }
            else
            {
                return;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ButtonMAS_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(textRESULTADO.Text);
            textRESULTADO.Clear();
        }

        private void ButtonMENOS_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(textRESULTADO.Text);
            textRESULTADO.Clear();
        }

        private void ButtonENTRE_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(textRESULTADO.Text);
            textRESULTADO.Clear();
        }

        private void ButtonPOR_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(textRESULTADO.Text);
            textRESULTADO.Clear();
        }

        private void ButtonIGUAL_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textRESULTADO.Text);
            double sum;
            double res;
            double mul;
            double div;
            double porc;

            switch(operacion){
                case "+":
                    sum = obj.sumar((primero),(segundo));
                    textRESULTADO.Text = sum.ToString();
                    break;
                case "-":
                    res = obj2.restar((primero), (segundo));
                    textRESULTADO.Text = res.ToString();
                    break;
                case "*":
                    mul = obj3.multiplicar((primero), (segundo));
                    textRESULTADO.Text = mul.ToString();
                    break;
                case "/":
                    div = obj4.dividir((primero), (segundo));
                    textRESULTADO.Text = div.ToString();
                    break;
                case "%":
                    porc = obj5.porciento((primero), (segundo));
                    textRESULTADO.Text = porc.ToString();
                    break;


            }
        }
        private void ButtonC_Click(object sender, EventArgs e)
        {
            textRESULTADO.Clear();
        }

        private void ButtonPORCIENTO_Click(object sender, EventArgs e)
        {
            operacion = "%";
            primero = double.Parse(textRESULTADO.Text);
            textRESULTADO.Clear();
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = textRESULTADO.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            textRESULTADO.Text = borrado;

            if (textRESULTADO.Text == "")
            {
                textRESULTADO.Text = "0";
                secuencia = true;
            }
            if (textRESULTADO.Text == "-")
            {
                textRESULTADO.Text = "0";
                secuencia = true;
            }
        }
    }
}
