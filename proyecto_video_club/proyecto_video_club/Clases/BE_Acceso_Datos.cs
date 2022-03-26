using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proyecto_video_club.Clases
{
    class BE_Acceso_Datos
    {
        public enum EstadoTransaccion{correcto, incorrecto };
        public enum TipoConexion { transaccion, simple};

        public EstadoTransaccion ControlTransaccion { get; set; } = EstadoTransaccion.correcto; //el valor de entrada es correcto
        public TipoConexion ControlConexion { get; set; } = TipoConexion.simple;//la conexion por defecto es simple


        SqlConnection conexion = new SqlConnection();
        SqlCommand mensajero = new SqlCommand();
        SqlTransaction Transaccion;

        string cadena_conexion = "Data Source=DESKTOP-RUU1MVE\\SQLEXPRESS;Initial Catalog=VIDEO_CLUB_PELICULAS;Integrated Security=True";

        public void IniciarTransaccion()
        {
            ControlConexion = TipoConexion.transaccion;
        }

        public EstadoTransaccion CerrarTransaccion()
        {
            if(ControlTransaccion == EstadoTransaccion.correcto)
            {
                Transaccion.Commit();
            }

            else { Transaccion.Rollback(); }

            ControlConexion = TipoConexion.simple; //para cerrar la transacion paso el tipo de conexion a simple
            Cerrar();

            return ControlTransaccion;
        }


        private void conectar()
        {
            if (conexion.State == ConnectionState.Closed)  //si la conexion esta cerrada abro una nueva conexion
            {
                conexion.ConnectionString = cadena_conexion;

                try
                {
                    conexion.Open();
                    mensajero.Connection = conexion;
                    mensajero.CommandType = System.Data.CommandType.Text;

                    if (ControlConexion == TipoConexion.transaccion)
                    {
                        Transaccion = conexion.BeginTransaction(IsolationLevel.ReadCommitted); //el "IsolationLevel.ReadCommited" es para cuando quiero consultar una tabla me muestre el registro
                        mensajero.Transaction = Transaccion;
                    }
                }
                catch (Exception exep)
                {
                    MessageBox.Show("Error en la apertura de conexion \n"
                                 + "Mensaje de error:" + "\n" + exep.Message);
                    ControlTransaccion = EstadoTransaccion.incorrecto;
                }
            }
            

        }

        private void Cerrar()
        {
            if(ControlConexion == TipoConexion.simple)
            {
                conexion.Close();
            }

        }

        public DataTable EjecutarSelect(string sql)
        {
            conectar();
            mensajero.CommandText = sql;
            DataTable tabla = new DataTable();

            try
            {
                tabla.Load(mensajero.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la ejecucion del SELECT \n\n"
                                 +sql
                                 + "\n Mensaje de error:" + "\n" + ex.Message);
                ControlTransaccion = EstadoTransaccion.incorrecto;

            }

            Cerrar();
            return tabla;
        }

        public void EjecutarNoSelect(string sql) //es para insertar
        {
            conectar();
            mensajero.CommandText = sql;


            try
            {
                 mensajero.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la ejecucion de un comando NO SELECT \n\n"
                                 + sql
                                 + "\n Mensaje de error:" + "\n" + e.Message);
                ControlTransaccion = EstadoTransaccion.incorrecto;

            }
           
            Cerrar();
        }

        public void Modificar(string sql)
        {
            EjecutarNoSelect(sql);
        }


        public void Insertar(string sql)
        {
            EjecutarNoSelect(sql);
        }

        public void Consultar(string sql)
        {
            EjecutarNoSelect(sql);
        }





    }
}
