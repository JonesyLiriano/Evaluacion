using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Click(object sender, EventArgs e)
        {
            Ejercicio1 e1 = new Ejercicio1();
            e1.MdiParent = this.MdiParent;
            e1.Show();
        }

        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 e2 = new Ejercicio2();
            e2.MdiParent = this.MdiParent;
            e2.Show();
        }

        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 e3 = new Ejercicio3();
            e3.MdiParent = this.MdiParent;
            e3.Show();
        }


        private void Salir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //nada
            }
        }

        private void Ejercicio4_Click_1(object sender, EventArgs e)
            {
            Ejercicio4 e4 = new Ejercicio4();
            e4.MdiParent = this.MdiParent;
            e4.Show();
            }
        }
}
