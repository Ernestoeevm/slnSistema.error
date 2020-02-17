using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCESO_AL_SISTEMA
{
    public partial class Form1 : Form
    {
        //variables globales
        string usuario = "SISE";
        string clave = "SISE";


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != usuario || textBox2.Text != clave)
            {
                if (textBox1.Text != usuario)
                {
                    MessageBox.Show("¡¡¡USUARIO INCORRECTO!!!");
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }
                if (textBox2.Text != clave)
                {
                    MessageBox.Show("¡¡¡CONTRASEÑA INCORRECTA!!!");
                    textBox2.Clear();
                    textBox2.Focus();
                    return;
                }
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                Principal form = new Principal();
                form.ShowDialog();
            }
        }
    }
}
