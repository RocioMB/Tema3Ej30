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
            string nombreRMB2324 = "";
            string passRMB2324 = "";

            int i = 3;
            while (i <= 5 && !(nombreRMB2324 == "root" && passRMB2324 == "1234"))
            {
                nombreRMB2324 = Interaction.InputBox("Introduzca nombre:", "Ejercicio 30");
                passRMB2324 = Interaction.InputBox("Introduzca contraseña:", "Ejercicio 30");

                // i++;
            }
            if (nombreRMB2324 == "root" && passRMB2324 == "123")
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
