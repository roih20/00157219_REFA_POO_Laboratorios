using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio09
{
    public partial class Form1 : Form
    {

        private UserControl current = null;
        public Form1()
        {
            InitializeComponent();
            current = registerStudent1;

        }


        private void buttonEstudiante_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new registerStudent();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);

        }

        private void buttonMateria_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new AddSiganture();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);

        }

        private void buttonInscripcion_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new Inscription();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new ViewData();
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);

        }
    }
}