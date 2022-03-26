using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_video_club.Negocios;

namespace proyecto_video_club.Formularios.Socios
{
    public partial class Frm_Alta_Socios : Form
    {
       

        public Frm_Alta_Socios()
        {
            InitializeComponent();
        }

        //GETS Y SET PARA USARLOS EN EL FRM PRINCIPAL

        public string nro_socio
        {
            get { return txt_nro_socio.Text; }
            set { txt_nro_socio.Text = value; }
        }

        public string nombre_socio
        {
            get { return txt_nombre_socio.Text; }
            set { txt_nombre_socio.Text = value; }
        }

        public string apellido_socio
        {
            get { return txt_apellido_socio.Text; }
            set { txt_apellido_socio.Text = value; }
        }

        public string dni_socio
        {
            get { return txt_cuit_socio.Text; }
            set { txt_cuit_socio.Text = value; }
        }

        public string calle_socio
        {
            get { return txt_calle_socio.Text; }
            set { txt_calle_socio.Text = value; }
        }

        public string nro_calle
        {
            get { return txt_nro_calle_socio.Text; }
            set { txt_nro_calle_socio.Text = value; }
        }

        //--------------------------------


        private void btn_alta_socio_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item.GetType().Name == "TextBox")
                {
                    if( ((TextBox)item).Text == "")
                    {
                        MessageBox.Show("COMPLETAR TODOS LOS DATOS");
                    }
                }

            }

            //--------------------------------------

            NE_Socios ne_socio = new NE_Socios();
            ne_socio.NroSocio = txt_nro_socio.Text;
            ne_socio.NombreSocio = txt_nombre_socio.Text;
            ne_socio.ApellidoSocio = txt_apellido_socio.Text;
            ne_socio.DniSocio = txt_cuit_socio.Text;
            ne_socio.CalleSocio = txt_calle_socio.Text;
            ne_socio.NroCalleSocio = txt_nro_calle_socio.Text;

            ne_socio.RegistrarSocio();
            MessageBox.Show("SE HA REGISTRADO CON EXITO AL SOCIO");


        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item.GetType().Name == "TextBox")
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        private void Frm_Alta_Socios_Load(object sender, EventArgs e)
        {

        }
    }
}
