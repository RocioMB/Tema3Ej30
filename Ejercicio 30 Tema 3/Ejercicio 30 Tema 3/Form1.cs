using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_30_Tema_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void introducirBtn_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string pass = "";

            int i = 1;
            while (i <= 5 && !(nombre == "root" && pass == "1234"))
            {
                nombre = Interaction.InputBox("Introduzca nombre:", "Ejercicio 30");
                pass = Interaction.InputBox("Introduzca contraseña:", "Ejercicio 30");

                i++;
            }
            if (nombre == "root" && pass == "1234")
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("Se ha superado el número de intentos permitido");
            }
        }
    }
}
