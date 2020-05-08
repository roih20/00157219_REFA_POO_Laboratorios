using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = new List<String>() {"Morado", "Celeste", "Rosado"};
        }



        private void buttonbBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void buttoRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BackColor = System.Drawing.ColorTranslator.FromHtml("#" + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Morado = "#4B088A", celeste = "#81F7F3", rosado = " #FE2EF7";

            switch (comboBox1.SelectedItem)
            {
                case 0:
                    BackColor = ColorTranslator.FromHtml(Morado);
                    break;
                
                case 1:
                    BackColor = ColorTranslator.FromHtml(celeste);
                    break;
                
                case 2:
                    BackColor = ColorTranslator.FromHtml(rosado);
                    break;
                
            }

       
           
        }

    }

}