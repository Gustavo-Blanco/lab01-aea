using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ComboBox comboBox1,comboBox2;
        private string Vnombre, Vdni, Vapellido, Vdireccion, Vtelefono, Vemail, VfecNac, Vdepartamento;
        public Form1()
        {
            InitializeComponent();
            this.comboBox1 = fecNac;
            this.comboBox2 = departamento;
            this.comboBox1.Items.AddRange(new string[] { 
                "martes, 22 de agosto",
                "miercoles, 23 de agosto",
                "jueves, 24 de agosto"});
            this.comboBox2.Items.AddRange(new string[] { 
                "Lima",
                "Ayacucho",
                "Cerro de pasco",
                "La libertad"
            });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            this.Vnombre = nombre.Text;
            this.Vdni = dni.Text;
            this.Vapellido = apellido.Text;
            this.Vdireccion = direccion.Text;
            this.Vtelefono = telefono.Text;
            this.Vemail = email.Text;
            this.VfecNac = fecNac.Text;
            this.Vdepartamento = departamento.Text;

            grid1.Rows.Add(codigo.Text,Vdni, Vnombre,Vapellido,Vdireccion,Vtelefono,Vemail,VfecNac,Vdepartamento);
        }
    }
}
