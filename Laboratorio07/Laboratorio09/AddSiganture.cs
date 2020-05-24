using System;
using System.Windows.Forms;

namespace Laboratorio09
{
    public partial class AddSiganture : UserControl
    {
        public AddSiganture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios");
            }
            else
            {
                try
                {
                    ConnectionDB.ExecuteNonQuery($"INSERT INTO MATERIA(nombre)  VALUES ('{textBox1.Text}')");

                    MessageBox.Show("se ha registrado la materia");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
    }
}