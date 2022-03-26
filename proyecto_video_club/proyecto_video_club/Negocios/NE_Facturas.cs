using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_video_club.Clases;
using System.Windows.Forms;

namespace proyecto_video_club.Negocios
{
    class NE_Facturas
    {
        public string totalFacturacion { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();
        private int grid_detalle_pelicula;

        public string TraerFecha()
        {
            string sql = "SELECT convert(char(11), GETDATE(), 103)";
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString();
        }

        public void CargarComboPeliculasFactura(ref ComboBox combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "cod_pelicula";
            combo.DataSource = _BD.EjecutarSelect("SELECT nombre , cod_pelicula FROM Peliculas");
        }


        //va para selectedchangeCommited
        public string RecuperarPrecioPelicula(string codigo_pelicula)
        {
            string sql = "SELECT precio FROM Peliculas WHERE cod_pelicula = " + codigo_pelicula;
            return _BD.EjecutarSelect(sql).Rows[0][0].ToString().Trim(); 
        }


        //registro datos de la factura y detalle

        public void RegistrarDatosFacturacion(string tipoFactura, string nroFactura, string fecha, string nro_Socio,
                                              string total, DataGridView grillaFactura,
                                              string fechaprevista, string fechareal)
        {
            string sqlInsert = @"INSERT INTO Facturas(tipo_factura, numero_factura, fecha, nroSocio, total) VALUES( ";

            sqlInsert += "'" + tipoFactura + "'";
            sqlInsert += ", " + nroFactura;
            sqlInsert += ", '" + fecha + "'";
            sqlInsert += ", " + nro_Socio;
            sqlInsert += ", " + total;
            sqlInsert += ")";

            _BD.IniciarTransaccion();
            _BD.Insertar(sqlInsert);

            //registro el detalle

            for(int i = 0; i< (grillaFactura.Rows.Count)-1; i++)
            {
                string sqlInsertDetalle = @"INSERT INTO DetalleFactura(tipoFactura, nroFactura, CodPelicula" 
                                            + ", fecha_prevista_devolucion, fecha_real_devolucion) VALUES(";

                sqlInsertDetalle += "'" + grillaFactura.Rows[i].Cells[0].Value.ToString() + "'";
                sqlInsertDetalle += ", " + grillaFactura.Rows[i].Cells[1].Value.ToString();
                sqlInsertDetalle += ", " + grillaFactura.Rows[i].Cells[2].Value.ToString();
                sqlInsertDetalle += ", '" + fechaprevista + "'";
                sqlInsertDetalle += ", '" + fechareal + "'";
                sqlInsertDetalle += ")";

                _BD.Insertar(sqlInsertDetalle);

            }

            if (_BD.CerrarTransaccion() == BE_Acceso_Datos.EstadoTransaccion.correcto)
            {
                MessageBox.Show("Se grabó correctamente la facturacion");
            }
            else
            {
                MessageBox.Show("No se grabó la facturacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }




        }




    }
}
