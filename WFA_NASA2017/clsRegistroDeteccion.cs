using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WFA_NASA2017
{
    public class clsRegistroDeteccion
    {
        public Image Captura { get; set; }

        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string Coordenadas { get; set; }

        public string SensorViento { get; set; }

        public string DireccionViento { get; set; }

        public string TemperaturaInformada { get; set; }

        public string Estado { get; set; }


        //public string PathImagen { get; set; }

    }
}
