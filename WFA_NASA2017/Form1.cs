
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace WFA_NASA2017
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarEjemplos();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CargarResgistros(ArrayList oArray1, string Tipo, DateTime fecha, string Coordenadas, string SensorViento,
            string DireccionViento, string TemperaturaInformada, string Estado, Image Captura)
        {
            clsRegistroDeteccion oRegistroEjemploUsuario = new clsRegistroDeteccion();
            oRegistroEjemploUsuario.Tipo = Tipo;
            oRegistroEjemploUsuario.Fecha = fecha;
            oRegistroEjemploUsuario.Coordenadas = Coordenadas;
            oRegistroEjemploUsuario.SensorViento = SensorViento;
            oRegistroEjemploUsuario.DireccionViento = DireccionViento;
            oRegistroEjemploUsuario.TemperaturaInformada = TemperaturaInformada;
            oRegistroEjemploUsuario.Estado = Estado;
            oRegistroEjemploUsuario.Captura = Captura;

            oArray1.Add(oRegistroEjemploUsuario);

        }

        private void CargarResgistros(ArrayList oArray1, string Tipo, DateTime fecha, string Coordenadas, string Estado, Image Captura)
        {
            clsRegistroDeteccion oRegistroEjemploUsuario = new clsRegistroDeteccion();
            oRegistroEjemploUsuario.Tipo = Tipo;
            oRegistroEjemploUsuario.Fecha = fecha;
            oRegistroEjemploUsuario.Coordenadas = Coordenadas;
            oRegistroEjemploUsuario.SensorViento = "N.I.";
            oRegistroEjemploUsuario.DireccionViento = "N.I.";
            oRegistroEjemploUsuario.TemperaturaInformada = "N.I.";
            oRegistroEjemploUsuario.Estado = Estado;
            oRegistroEjemploUsuario.Captura = Captura;

            oArray1.Add(oRegistroEjemploUsuario);

        }


        private void CargarEjemplos()
        {
            ArrayList oArray = new ArrayList();

            CargarResgistros(oArray, "GOES 13", new DateTime(2017, 04, 29, 17, 30, 00),
            "S 32 59 44.999 - O 60 38 22.236", "Normal", WFA_NASA2017.Properties.Resources.Verde);

            CargarResgistros(oArray, "GOES 13", new DateTime(2017, 04, 29, 18, 00, 00),
            "S 32 59 44.999 - O 60 38 22.236", "Normal", WFA_NASA2017.Properties.Resources.Verde);

            CargarResgistros(oArray, "GOES 13", new DateTime(2017, 04, 29, 18, 30, 00),
            "S 32 59 44.999 - O 60 38 22.236", "Normal", WFA_NASA2017.Properties.Resources.Verde);

            CargarResgistros(oArray, "GOES 13", new DateTime(2017, 04, 29, 18, 30, 00),
            "S 32 59 44.999 - O 60 38 22.236", "Normal", WFA_NASA2017.Properties.Resources.Verde);

            CargarResgistros(oArray, "GOES 13", new DateTime(2017, 04, 29, 19, 00, 00),
            "S 32 59 44.999 - O 60 38 22.236", "Normal", WFA_NASA2017.Properties.Resources.Verde);

            CargarResgistros(oArray, "Celular 3415038273", new DateTime(2017, 04, 29, 19, 15, 00),
            "S 32 59 44.999 - O 60 38 22.236", "Analizado", WFA_NASA2017.Properties.Resources.Amarillo);

            CargarResgistros(oArray, "Celular 3415038272", new DateTime(2017, 04, 29, 19, 23, 00),
            "S 32 59 44.999 - O 60 38 22.236", "Analizado", WFA_NASA2017.Properties.Resources.Naranja);

            CargarResgistros(oArray, "V.A.N.T.D.I.", new DateTime(2017, 04, 28, 19, 20, 00),
            "S 32°59'44.999\" - O 60°38'22.236\"", "19 km/h", "Norte", "240.1 C", "Derivado a Cuartel Bomberos", WFA_NASA2017.Properties.Resources.Rojo);

            CargarResgistros(oArray, "GOES 13", new DateTime(2017, 04, 29, 19, 30, 00),
            "S 32 59 44.999 - O 60 38 22.236", "Derivado a Cuartel Bomberos", WFA_NASA2017.Properties.Resources.Rojo);

            CargarResgistros(oArray, "GOES 13", new DateTime(2017, 04, 29, 20, 00, 00),
            "S 32 59 44.999 - O 60 38 22.236", "En proceso", WFA_NASA2017.Properties.Resources.Amarillo);

            CargarResgistros(oArray, "GOES 13", new DateTime(2017, 04, 29, 20, 30, 00),
                "S 32 59 44.999 - O 60 38 22.236", "Normal", WFA_NASA2017.Properties.Resources.Verde);

            ArrayList oArrayRecorridos = new ArrayList();

            clsRegistroRecorridos oRegistro1 = new clsRegistroRecorridos();
            oRegistro1.Estado = "Sin anomalías";
            oRegistro1.Fecha = new DateTime(2017, 04, 28, 17, 54, 00);

            oArrayRecorridos.Add(oRegistro1);

            clsRegistroRecorridos oRegistro2 = new clsRegistroRecorridos();
            oRegistro2.Estado = "Incendio detectado";
            oRegistro2.Fecha = new DateTime(2017, 04, 29, 18, 54, 00);

            oArrayRecorridos.Add(oRegistro2);

            dgvDetecciones.DataSource = oArray;

            dgvRecorridos.DataSource = oArrayRecorridos;

            dgvDetecciones.Columns[5].HeaderText = "Veloc. Viento";
            dgvDetecciones.Columns[6].HeaderText = "Direcc. Viento";
            dgvDetecciones.Columns[7].HeaderText = "Temperatura";
            dgvDetecciones.Columns[1].HeaderText = "";
            dgvDetecciones.Columns[0].Width = 70;
            dgvDetecciones.Columns[1].Width = 40;
            dgvDetecciones.Columns[2].Width = 120;
            dgvDetecciones.Columns[4].Width = 200;
            dgvDetecciones.Columns[5].Width = 65;
            dgvDetecciones.Columns[6].Width = 65;
            dgvDetecciones.Columns[7].Width = 80;
            dgvDetecciones.Columns[8].Width = 150;
            splitContainerDetecciones.SplitterDistance = 800;
            splitContainerDetecciones.IsSplitterFixed =true;

            clsRegistroRecorridos oRegistro3 = new clsRegistroRecorridos();
            oRegistro3.Estado = "En progreso";
            oRegistro3.Fecha = new DateTime(2017, 04, 30, 18, 54, 00);

            oArrayRecorridos.Add(oRegistro2);

            dgvDetecciones.DataSource = oArray;

            dgvRecorridos.DataSource = oArrayRecorridos;


        }

        private void dgvDetecciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex == 0)
                    this.picDetecciones.ImageLocation = @"c:\nasa\^DFABBC7054F4B20344CC94B4A171471379B68E304BFAAB74A4^pimgpsh_thumbnail_win_distr.jpg";
                if (e.RowIndex == 1)
                    this.picDetecciones.ImageLocation = @"c:\nasa\CapturaGoes13_Infrarojo_Argentina.png";
                if (e.RowIndex == 2)
                    this.picDetecciones.ImageLocation = @"c:\nasa\WP_20170429_17_48_47_Pro.jpg";
                if (e.RowIndex == 7)
                    this.picDetecciones.ImageLocation = @"c:\nasa\VantConFuego.png";

            }

        }

        private void dgvRecorridos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.RowIndex == 0)
                    this.picRecorridos.ImageLocation = @"c:\nasa\SecuenciaLipan.jpg";
                if (e.RowIndex == 1)
                    this.picRecorridos.ImageLocation = @"c:\nasa\SecuenciaLipan2.jpg";
            }

        }

    }
}
