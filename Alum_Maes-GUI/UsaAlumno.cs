using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alum_Maes_GUI
{
    class UsaAlumno
    {
        List<Alumno> list = new List<Alumno>();

        public void AgregaAlumno(string nomAlumno, int grado, string sexo, string maestro)
        {
            //Validar que el nombre no exita
            if(BuscaNombreAlumno(nomAlumno) == false)
            {
                //Crear el objeto y agregarlo a la coleccion
                Alumno listAlumno = new Alumno(nomAlumno, grado, sexo, maestro);
                //list.Add();
                //MessageBox.Show("Alumno(a) agregado exitosamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //MessageBox.Show("Nombre ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool BuscaNombreAlumno(string nombre)
        {
            bool encontro = false;

            foreach (Alumno listAlumno in list)
            {
                if (nombre == listAlumno.pNombre)
                {
                    encontro = true;
                    break;
                }
            }
            return encontro;
        }

        public bool BuscaNombreAlumnoGrado(string nombre, int grado)
        {
            bool encontro = false;

            foreach(Alumno listAlumno in list)
            {
                if(nombre ==listAlumno.pNombre && grado ==listAlumno.pGrado)
                {
                    encontro = true;
                    break;
                }
            }

            return encontro;
        }
    }
}
