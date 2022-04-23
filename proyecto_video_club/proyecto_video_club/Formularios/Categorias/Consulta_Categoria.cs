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

namespace proyecto_video_club.Formularios.Categorias
{
    public partial class Consulta_Categoria : Form
    {
        NE_Categoria categoria = new NE_Categoria();

        public Consulta_Categoria()
        {
            InitializeComponent();
        }

        private void Consulta_Categoria_Load(object sender, EventArgs e)
        {
            //otra forma de cargar el ComboBox
            DataTable tabla = new DataTable();
            tabla = categoria.traerNombreCategoria();

            for(int i = 0; i<tabla.Rows.Count; i++)
            {
                cmb_consultar_categoria.Items.Add(tabla.Rows[i][0]);
            }
        }

        

        private void btn_consultar_categoria_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = categoria.traerDatosCategoria(cmb_consultar_categoria.Text);
            DGV_consultar_categoria.DataSource = tabla;


        }

        private void btn_buscar_todas_las_categorias_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = categoria.traerTodasLasCategorias();
            DGV_consultar_categoria.DataSource = tabla;
        }
    }
}
