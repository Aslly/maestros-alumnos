using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Alum_Maes_GUI
{
    public partial class frmCapturaMaestros : Form
    {
        UsaMaestro usaM = new UsaMaestro();

     

        public frmCapturaMaestros()
        {
            InitializeComponent();
            cbmCarrera.SelectedIndex = -1;
        }

        private void frmCapturaMaestros_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //1.- Validar que todos los datos en los componentes sean correctos

            //Validacion para que el nombre no este vacio
            string nombre = txtNombres.Text;
            string apellido = txtApellidoPaterno.Text;
            string apellidos = txtApellidoPaterno.Text + " " + txtApellidoMaterno.Text;
            DialogResult result = MessageBox.Show("Esta seguro que desea guardar", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (ValidaNombre(nombre) == true)
            {
                //Signifia nombre vacio, marcar error
                MessageBox.Show("Nombre vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombres.Focus();
            }
            //Validar el apellido paterno
            else if(ValidaApellidoPaterno(apellido)==true)
            {
                //Significa apellido vacio,marca error
                MessageBox.Show("Apellido Paterno vacio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellidoPaterno.Focus();

            }

            //Valiación para que el componente comboBox(Carrera) no este vacío
            else if(Valida()==false)
            {
                MessageBox.Show("Elemento no seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbmCarrera.Focus();
            }
            else if (result == DialogResult.OK)
            {
                //Significa que se presiono el boton de Ok(Aceptar)
                //Metodo para invovar el dictionary
                usaM.AgregaMaestro(txtNombres.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, cbmCarrera.Text, txtDomicilio.Text);
                this.dgvMaestros.Rows.Add(nombre, apellidos);
                Limpia();

            }

        }

        public bool Valida()
        {
            bool variable = true;
            if (cbmCarrera.SelectedIndex == -1)
                variable=false;
            return variable;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpia();
        }
        public void Limpia()
        {
            txtNombres.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            cbmCarrera.Text = "";
            txtDomicilio.Text = "";

            //Desactivar el boton guardar
            //btnGuardar.Enabled = false;
        }

        private bool ValidaNombre(String nombre)
        {
            bool retorno = false;
            if (nombre == "")
                retorno = true;

            return retorno;

        }

        private bool ValidaApellidoPaterno(string apellido)
        {
            bool retorno = false;
            if (apellido == "")
                retorno = true;
            return retorno;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //No borrar esto
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Validar que solo acepten letras
        private void txtLetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumnos alumnos = new frmAlumnos(usaM);
            alumnos.Show();
        }
    }
}
