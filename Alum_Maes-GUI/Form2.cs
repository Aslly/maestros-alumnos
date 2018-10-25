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
    public partial class frmAlumnos : Form
    {
        UsaMaestro maes;
        public frmAlumnos(UsaMaestro usaM)
        {
            InitializeComponent();
            maes = usaM;
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            foreach(int clave in maes.dicMaestro.Keys)
            {
                cmbMaestro.Items.Add(clave);
            }
        }

        private void cmbMaestro_SelectedIndexChanged(object sender, EventArgs e)
        {
            int llave = Convert.ToInt32(cmbMaestro.SelectedItem.ToString());
            Maestro usaM=maes.dicMaestro[llave];
            lblNombreMaestro.Text = usaM.pNombre;
        }
    }
}
