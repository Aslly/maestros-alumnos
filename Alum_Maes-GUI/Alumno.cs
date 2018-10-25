using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alum_Maes_GUI
{
    class Alumno
    {
        private string Nombre;
        private int Grado;
        private string Sexo;
        private string Maestro;

        public Alumno(string nombre, int grado, string sexo, string maestro)
        {
            Nombre = nombre;
            Grado = grado;
            Sexo = sexo;
            Maestro = maestro;
        }

        public string pNombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }

        public int pGrado
        {
            get
            {
                return Grado;
            }
            set
            {
                Grado = value;
            }
            
        }
        public string pSexo
        {
            get
            {
                return Sexo;
            }
            set
            {
                Sexo = value;
            }
        }

        public string pMaestro
        {
            get
            {
                return Maestro;
            }
            set
            {
                Maestro = value;
            }
        }
    }
}
