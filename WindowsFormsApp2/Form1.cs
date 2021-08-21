using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ComboBox cb1 = operacion;
            ComboBox cb2 = combo2;

            cb1.Items.AddRange(new string[] { "suma","resta","division","multiplicacion"});
            cb2.Items.AddRange(new string[] { "Celcius", "Fahrenheit" });

            foreach (var item in numeroPrimos())
            {
                Console.WriteLine(item);
                tabla.Rows.Add(item.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Cn1 = Double.Parse(n1.Text);
            double Cn2 = Double.Parse(n2.Text);
            string operation = operacion.Text;
            double result = 0;

            switch (operation)
            {
                case "suma":
                    result = suma(Cn1,Cn2);
                    break;
                case "resta":
                    result = resta(Cn1, Cn2);
                    break;
                case "division":
                    result = dividir(Cn1, Cn2);
                    break;
                case "multiplicacion":
                    result = multiplicar(Cn1, Cn2);
                    break;
                default:
                    break;
            }

            MessageBox.Show("El resultado es: "+result.ToString());
        }

        private List<int> numeroPrimos()
        {
            List<int> numeros = new List<int>();
            int count = 2;

            while (numeros.Count < 10)
            {
                bool primo = true;

                for (int x = 2; x < count; x++)
                {

                    if (count % x == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    numeros.Add(count);
                }
                count++;
            }

            return numeros;
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {

        }

        private double suma(double a, double b) => a + b;
        private double resta(double a, double b) => a - b;
        private double multiplicar(double a, double b) => a * b;
        private double dividir(double a, double b) => a / b;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void calcular2_Click(object sender, EventArgs e)
        {
            int opcion = combo2.Text == "Celcius" ? 0 : 1;
            MessageBox.Show("El resultado es: " + CelciusOrFarenheit(opcion,Double.Parse(convertir.Text)).ToString());

        }

        private double CelciusOrFarenheit(int opcion, double numero)
        {
            if (opcion == 0)
            {
                return 5 * (numero - 32) / 9;
            }
            else
            {
                return ((9 * numero) / 5) + 32;
            }
        }
    }
}
