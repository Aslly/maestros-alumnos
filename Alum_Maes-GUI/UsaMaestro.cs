using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alum_Maes_GUI
{
    public class UsaMaestro
    {
        public Dictionary<int, Maestro> dicMaestro = new Dictionary<int, Maestro>();
        int ClaveMaestro = 100;

        public void AgregaMaestro(string nom, string apePat, string apeMat, string carrera, string domicilio)
        {
            //Validar que el nombre no exita
            if(BuscaNombre(nom) == false)
            {
                //Crear el objeto y agregarlo a la coleccion
                Maestro m = new Maestro(nom, apePat, apeMat, carrera, domicilio);
                dicMaestro.Add(ClaveMaestro, m);
                ClaveMaestro += 10;
                MessageBox.Show("Maestro(A) agregado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nombre ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public bool BuscaNombre(string nombre)
        {
            bool encontro = false;
            
            foreach(Maestro m in dicMaestro.Values)
            {
                if(nombre == m.pNombre)
                {
                    encontro = true;
                    break;
                }
            }

            return encontro;
        }

        
    }
}
