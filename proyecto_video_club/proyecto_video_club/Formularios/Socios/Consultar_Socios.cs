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

    public partial class Consultar_Socios : Form
    {
        NE_Socios socios = new NE_Socios();


        public Consultar_Socios()
        {
            InitializeComponent();
        }

        private void Consultar_Socios_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = socios.traerNombresSocios();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                cmb_consulta_socio.Items.Add(tabla.Rows[i][0]);
            }
        }

        private void btn_bucar_socio_x_nombre_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = socios.traerDatosSocios(cmb_consulta_socio.Text);
            DGV_consulta_socios.DataSource = tabla;

        }

        private void btn_consultar_todos_socios_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = socios.traerTodosLodDatosSocios();
            DGV_consulta_socios.DataSource = tabla;
        }
    }
}
