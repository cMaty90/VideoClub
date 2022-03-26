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

namespace proyecto_video_club.Formularios.Transaccion
{
    public partial class Frm_Alta_Factura : Form

       //LA FECHA REAL DE DEVOLUCION ES LA FECHA QUE EL CLIENTE AVISA QUE QUIERE DEVOLVER LA PELICULA
       //LA FECHA PREVISTA DE DEVOLUCION ES LA FECHA QUE EN TEORIA DEBERIA DEVOLVER LA PELICULA
    {
        //getter y setter
        public string tipoFactura
        {
            get { return txt_tipo_factura.Text; }
            set { txt_tipo_factura.Text = value; }
        }

        public string nroFactura
        {
            get { return txt_nro_factura.Text; }
            set { txt_nro_factura.Text = value; }
        }

        public string fechaFactura
        {
            get { return txt_fecha_actual.Text; }
            set { txt_fecha_actual.Text = value; }
        }

        public string nroSocio
        {
            get { return txt_nroSocio_factura.Text; }
            set { txt_nroSocio_factura.Text = value; }
        }

        public string precioPeliFactura
        {
            get { return txt_precioPeli_factura.Text; }
            set { txt_precioPeli_factura.Text = value; }

        }

        public string fechaRealDev
        {
            get { return txt_fecha_real_dev.Text; }
            set { txt_fecha_real_dev.Text = value; }
        }

        public string fechaPrevDev
        {
            get { return txt_fecha_prevista_dev.Text; }
            set { txt_fecha_prevista_dev.Text = value; }
        }

        public string totalFacturacion
        {
            get { return txt_total_facturacion.Text; }
            set { txt_total_facturacion.Text = value; }
        }


        public enum resultadoDeBusqueda { encontre, no_encontre }


        public Frm_Alta_Factura()
        {
            InitializeComponent();
        }

        NE_Facturas ne_factura = new NE_Facturas();

        private void Frm_Alta_Factura_Load(object sender, EventArgs e)
        {
            ne_factura.CargarComboPeliculasFactura(ref cmb_codPeli_factura);
        }


        //voy a hacer que aparezca el precio cuando selecione una peli del combo
        private void cmb_codPeli_factura_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_precioPeli_factura.Text = ne_factura.RecuperarPrecioPelicula(cmb_codPeli_factura.SelectedValue.ToString());
        }

        private void btn_traer_fecha_Click(object sender, EventArgs e)
        {
            txt_fecha_actual.Text = ne_factura.TraerFecha();
        }

        private void btn_limpiar_datos_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    ((TextBox)item).Text = "";
                }

                if (item.GetType().Name == "ComboBox")
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
            }
        }

        private void agregarFilaAGrilla()
        {
            if (ValidarFactura(txt_tipo_factura.Text, txt_nro_factura.Text, cmb_codPeli_factura.SelectedValue.ToString()) == resultadoDeBusqueda.encontre)
            {
                MessageBox.Show("ya se ha egistrado un numero de factura o un codigo de pelicula");

            }

            else
            {
                grid_detalle_pelicula.Rows.Add( txt_tipo_factura.Text
                                               , txt_nro_factura.Text
                                               , cmb_codPeli_factura.SelectedValue.ToString()
                                               , txt_precioPeli_factura.Text
                                               , txt_fecha_real_dev.Text);
            }
            
            
        }

        //valido que no se ingresen datos repetidos a la grilla
        //valido solo nro factura y codigo de peli ya que tipo podra cambiar y no afectara ni a la facctura ni al detalle
        private resultadoDeBusqueda ValidarFactura(string tipofac, string nro_fac, string cod_peli )
        {
            for(int i = 0; i< (grid_detalle_pelicula.Rows.Count)-1; i++)
            {
                if(grid_detalle_pelicula.Rows[i].Cells[0].ToString() == tipofac &&
                    grid_detalle_pelicula.Rows[i].Cells[1].ToString() == nro_fac && 
                    grid_detalle_pelicula.Rows[i].Cells[2].ToString() == cod_peli)
                {
                    return resultadoDeBusqueda.encontre;
                }
            }
            return resultadoDeBusqueda.no_encontre;
            
        }

        private void btn_agregar_pelicula_Click(object sender, EventArgs e)
        {
            agregarFilaAGrilla();
            calcularTotalFacturacion();
        }

        private void txt_total_facturacion_TextChanged(object sender, EventArgs e)
        {
            //lo puse en el boton agregar pelicula para calclar a maedida que se agregan items
        }


        private void calcularTotalFacturacion()
        {
            int suma = 0;

            for(int i = 0; i< (grid_detalle_pelicula.Rows.Count)-1; i++)
            {
                suma += int.Parse(grid_detalle_pelicula.Rows[i].Cells[3].Value.ToString());
            }

            txt_total_facturacion.Text = suma.ToString();
        }

        private void btn_reg_alquiler_Click(object sender, EventArgs e)
        {
            NE_Facturas transaccion = new NE_Facturas();
            transaccion.RegistrarDatosFacturacion(txt_tipo_factura.Text, txt_nro_factura.Text, txt_fecha_actual.Text
                                                  , txt_nroSocio_factura.Text, txt_total_facturacion.Text, grid_detalle_pelicula, txt_fecha_prevista_dev.Text
                                                  , txt_fecha_real_dev.Text);
        }
    }
}
