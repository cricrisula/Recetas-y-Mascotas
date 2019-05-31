using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_Ultima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            Form mascotas = new Mascota();
            mascotas.Show();
        }

        private void btnRecetas_Click(object sender, EventArgs e)
        {
            Form recetas = new Receta();
            recetas.Show();
        }
    }
}
