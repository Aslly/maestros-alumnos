using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alum_Maes_GUI
{
    public class Maestro
    {
        private string Nombre;
        private string ApellidoPaterno;
        private string ApellidoMaterno;
        private string Carrera;
        private string Domicilio;
        
        public Maestro(string nombre, string apellidoPat, string apellidoMat, string carrera, string domicilio)
        {
            Nombre = nombre;
            ApellidoPaterno = apellidoPat;
            ApellidoMaterno = apellidoMat;
            Carrera = carrera;
            Domicilio = domicilio;
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

        public string pApellidoPaterno
        {
            get
            {
                return ApellidoPaterno;
            }
            set
            {
                ApellidoPaterno = value;
            }
        }

        public string pApellidoMaterno
        {
            get
            {
                return ApellidoMaterno;
            }
            set
            {
                ApellidoMaterno = value;

            }  
        }

        public string pCarrera
        {
            get
            {
                return Carrera;
            }
            set
            {
                Carrera = value;
            }
        }

        public string pDomicilio
        {
            get
            {
                return Domicilio;
            }
            set
            {
                Domicilio = value;
            }
        }
    }
}
