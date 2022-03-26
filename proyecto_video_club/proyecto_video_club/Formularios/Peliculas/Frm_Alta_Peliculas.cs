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

namespace proyecto_video_club.Formularios.Peliculas
{
    public partial class Frm_Alta_Peliculas : Form
    {
        public Frm_Alta_Peliculas()
        {
            InitializeComponent();
        }

        // gets y sets

        public string codigo_pelicula
        {
            get { return txt_codigo_pelicula.Text; }
            set { txt_codigo_pelicula.Text = value; }
        }

        public string nombre_pelicula
        {
            get { return txt_nombre_pelicula.Text; }
            set { txt_nombre_pelicula.Text = value; }
        }

        public string precio_pelicula
        {
            get { return txt_precio_pelicula.Text; }
            set { txt_precio_pelicula.Text = value; }
        }

        //falta el combo

        //----------------------------------------

        NE_Peliculas ne_pelicula = new NE_Peliculas();

        private void Frm_Alta_Peliculas_Load(object sender, EventArgs e)
        {
            ne_pelicula.CargarCombo(ref cmb_categoria_pelicula);
        }

        private void btn_guardar_pelicula_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    if (((TextBox)item).Text == "")
                    {
                        MessageBox.Show("COMPLETAR TODOS LOS DATOS");
                    }
                }
            }

            //----------------------------

            ne_pelicula.CodPelicula = txt_codigo_pelicula.Text;
            ne_pelicula.NombrePelicula = txt_nombre_pelicula.Text;
            ne_pelicula.PrecioPelicula = txt_precio_pelicula.Text;
            ne_pelicula.CategoriaPelicula = cmb_categoria_pelicula.SelectedValue.ToString();

            ne_pelicula.RegistrarPelicula();
            MessageBox.Show("SE HA REGISTRADO UNA PELICULA");
        }

        private void btn_limpiar_pelicula_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    ((TextBox)item).Text = "";
                }

                if(item.GetType().Name == "ComboBox")
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
            }
        }
    }
}
