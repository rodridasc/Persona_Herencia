using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            // esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda
            MessageBox.Show("Datos guardados");
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de borrar las cajas de texto

        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de terminar la ejecucion de la interfaz
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limpiar_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


