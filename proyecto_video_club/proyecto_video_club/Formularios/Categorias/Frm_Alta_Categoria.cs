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
    public partial class Frm_Alta_Categoria : Form
    {
        public Frm_Alta_Categoria()
        {
            InitializeComponent();
        }

        //GETS Y SET

        public string id_categoria
        {
            get { return txt_id_categoria.Text; }
            set { txt_id_categoria.Text = value; }
        }

        public string nombre_categoria
        {
            get { return txt_nombre_categoria.Text; }
            set { txt_nombre_categoria.Text = value; }
        }
        //-------------------------------------------------

        private void btn_guardar_categoria_Click(object sender, EventArgs e)
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
            //--------------------------------

            NE_Categoria ne_categoria = new NE_Categoria();
            ne_categoria.IdCategoria = txt_id_categoria.Text;
            ne_categoria.NombreCategoria = txt_nombre_categoria.Text;
            ne_categoria.RegistrarCategoria();

            MessageBox.Show("SE HA REGISTRADO UNA CATEGORIA");

        }

        private void btn_limpiar_categoria_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    ((TextBox)item).Text = "";
                }
            }
        }

        private void Frm_Alta_Categoria_Load(object sender, EventArgs e)
        {

        }
    }
}
