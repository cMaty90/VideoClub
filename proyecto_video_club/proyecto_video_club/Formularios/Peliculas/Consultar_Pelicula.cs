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
    public partial class Consultar_Pelicula : Form
    {
        NE_Peliculas peliculas = new NE_Peliculas();

        public Consultar_Pelicula()
        {
            InitializeComponent();
        }

        private void Consultar_Pelicula_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = peliculas.traerNombresPeliculas();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                cmb_nombre_peli_consulta.Items.Add(tabla.Rows[i][0]);
            }
        }

        private void btn_buscar_x_nombre_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = peliculas.traerDatosPeliculas(cmb_nombre_peli_consulta.Text);
            DGV_consulta_peliculas.DataSource = tabla;
        }

        private void btn_consultar_todas_peliculas_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = peliculas.traerTodosLodDatosPeliculas();
            DGV_consulta_peliculas.DataSource = tabla;
        }
    }
}
