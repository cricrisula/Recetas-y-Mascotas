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
    public partial class Mascota : Form
    {
        public Mascota()
        {
            InitializeComponent();
        }


        private void Mascota_Load(object sender, EventArgs e)
        {

        }

        ultimoEntities muv = new ultimoEntities();
        private void btnMostrar_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = muv.Mascotas.ToList();


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // hay variables que hay que convertirlas antes de mandar atraer informacion 
            // atraves de linq ya que arroja una excepcion mera marceana haha
            int idd = Convert.ToInt32( txtId.Text);
            Mascotas c = (from p in muv.Mascotas
                          where p.Id == idd//antes la avia creado aqui conver.tointo32(txtID.text) y no funciona
                          select p).First();
            muv.Mascotas.Remove(c);
            muv.SaveChanges();
            MessageBox.Show("Ha sido eliminado Satisfactoriamente por perro");
            mostrarLista();

        }
        

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idd = Convert.ToInt32(txtId.Text);
            Mascotas c = (from p in muv.Mascotas
                          where p.Id == idd
                          select p).First();

           c.Nombre_Mascota= txtNombre.Text;
             c.Color = txtColor.Text;
            c.Raza = txtRaza.Text;
            c.Edad = txtEdad.Text;
            c.Sexo = txtSexo.Text;
            c.Nombre_Dueño = txtDueño.Text;
            c.Telefono = txtCelular.Text;
            muv.SaveChanges();
            MessageBox.Show("Ha sido Modificado Satisfactoriamente ");
            mostrarLista();




        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            Mascotas nuevamascota = new Mascotas();
            nuevamascota.Nombre_Mascota = txtNombre.Text;
            nuevamascota.Color = txtColor.Text;
            nuevamascota.Raza = txtRaza.Text;
            nuevamascota.Edad = txtEdad.Text;
            nuevamascota.Sexo = txtSexo.Text;
            nuevamascota.Nombre_Dueño = txtDueño.Text;
            nuevamascota.Telefono = txtCelular.Text;
            muv.Mascotas.Add(nuevamascota);
            if(muv.SaveChanges()==1)
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
        private void limpiar()
        {
            txtNombre.Text = "";
            txtColor.Text = "";
            txtRaza.Text = "";
            txtEdad.Text = "";
            txtSexo.Text = "";
            txtDueño.Text = "";
            txtCelular.Text = "";

        }
        private void mostrarLista()
        {
            dataGridView1.DataSource = muv.Mascotas.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRaza_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LbBorrar_Click(object sender, EventArgs e)
        {

        }
    }
}
