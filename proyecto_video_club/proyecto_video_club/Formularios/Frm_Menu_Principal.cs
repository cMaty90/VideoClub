using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_video_club.Formularios.Peliculas;
using proyecto_video_club.Formularios.Socios;
using proyecto_video_club.Formularios.Categorias;
using proyecto_video_club.Formularios.Transaccion;

namespace proyecto_video_club.Formularios
{
    public partial class Frm_Menu_Principal : Form
    {
        //atributos pelicula
        private string codigoPelicula;
        private string nombrePelicula;
        private string precioPelicula;
        private string categoriaPelicula;

        //atributos socios
        private string nroSocio;
        private string nombreSocio;
        private string apellidoSocio;
        private string dniSocio;
        private string calleSocio;
        private string nroCalleSocio;

        //categoria
        private string idCategoria;
        private string nombreCategoria;

        //factura
        private string tipoFactura;
        private string numeroFactura;
        private string fechaFactura;
        private string numeroSocioFactura;
        private string precioPeliculaFactura;
        private string fechaReal;
        private string fechaPrevista;
        private string totalFactura;


        public Frm_Menu_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Principal_Load(object sender, EventArgs e)
        {

        }

        private void nuevaPeliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Peliculas peli = new Frm_Alta_Peliculas();
            peli.ShowDialog();
            this.codigoPelicula = peli.codigo_pelicula;
            this.nombrePelicula = peli.nombre_pelicula;
            this.precioPelicula = peli.precio_pelicula;

            peli.Dispose();

        }

        private void nuevoSocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Socios socio = new Frm_Alta_Socios();
            socio.ShowDialog();
            this.nroSocio = socio.nro_socio;
            this.nroSocio = socio.nombre_socio;
            this.nroSocio = socio.apellido_socio;
            this.nroSocio = socio.dni_socio;
            this.nroSocio = socio.calle_socio;
            this.nroSocio = socio.nro_calle;

            socio.Dispose();

        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Categoria categoria = new Frm_Alta_Categoria();
            categoria.ShowDialog();

            this.idCategoria = categoria.id_categoria;
            this.nombreCategoria = categoria.nombre_categoria;

            categoria.Dispose();

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Alta_Factura factura = new Frm_Alta_Factura();
            factura.ShowDialog();

            this.tipoFactura = factura.tipoFactura;
            this.numeroFactura = factura.nroFactura;
            this.fechaFactura = factura.fechaFactura;
            this.numeroSocioFactura = factura.nroSocio;
            this.precioPelicula = factura.precioPeliFactura;
            this.fechaReal = factura.fechaRealDev;
            this.fechaPrevista = factura.fechaPrevDev;
            this.totalFactura = factura.totalFacturacion;


    }
    }
}
