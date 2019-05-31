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
    public partial class Receta : Form
    {
        public Receta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Receta_Load(object sender, EventArgs e)
        {

        }

        ultimoEntities mur = new ultimoEntities();
        private void btnMostrar2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = mur.Recetas.ToList();

        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            Recetas nuevareceta = new Recetas();
            nuevareceta.Nombre_Receta = txtNombre2.Text;
            nuevareceta.Pais = txtPais.Text;
            nuevareceta.Ingrediente1 = txtIngrediente1.Text;
            nuevareceta.Ingrediente2 = txtIngrediente2.Text;
            nuevareceta.Ingrediente3 = txtIngrediente3.Text;
            nuevareceta.Preparacion = txtPreparacion.Text;
            nuevareceta.Cantidad_Personas = txtC_Personas.Text;
            mur.Recetas.Add(nuevareceta);
            if (mur.SaveChanges() == 1)
            {
                MessageBox.Show("se agrego con exito");
            }
            else
            {
                MessageBox.Show("no se agrego con exito");
            }
            mostrarLista();
            limpiar();
        }
        public void mostrarLista()
        {
            dataGridView2.DataSource = mur.Recetas.ToList();
        }
        //metodo limpiar para limpiar los tex box
    public void limpiar()
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(txtId2.Text);
            Recetas c = (from p in mur.Recetas
                          where p.Id == idd//antes la avia creado aqui conver.tointo32(txtID.text) y no funciona
                          select p).First();
            mur.Recetas.Remove(c);
            mur.SaveChanges();
            MessageBox.Show("Ha sido eliminado Satisfactoriamente por perro");
            mostrarLista();

        }

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(txtId2.Text);
            Recetas c = (from p in mur.Recetas
                          where p.Id == idd
                          select p).First();

          c.Nombre_Receta = txtNombre2.Text;
           c.Pais = txtPais.Text;
            c.Ingrediente1 = txtIngrediente1.Text;
            c.Ingrediente2 = txtIngrediente2.Text;
            c.Ingrediente3 = txtIngrediente3.Text;
            c.Preparacion = txtPreparacion.Text;
            c.Cantidad_Personas = txtC_Personas.Text;
            mur.SaveChanges();
            MessageBox.Show("Ha sido Modificado Satisfactoriamente ");
            mostrarLista();




        }
    }
}
