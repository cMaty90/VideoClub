using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_video_club.Clases;

namespace proyecto_video_club.Negocios
{
    class NE_Socios
    {
        public string NroSocio { get; set; }
        public string NombreSocio { get; set; }
        public string ApellidoSocio { get; set; }
        public string DniSocio { get; set; }
        public string CalleSocio { get; set; }
        public string NroCalleSocio { get; set; }


        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void RegistrarSocio()
        {
            string sql = "";
            sql = @"INSERT INTO Socios (nro_socio,nombre,apellido,dni,calle,nro_calle) VALUES(";
            sql += NroSocio;
            sql += ",'" + NombreSocio + "'";
            sql += ",'" + ApellidoSocio + "'";
            sql += "," + DniSocio;
            sql += ",'" + CalleSocio + "'";
            sql += ","  + NroCalleSocio + ")";

            _BD.Insertar(sql);
        }

        //metodos para el formulario de consulta

        public DataTable traerDatosSocios(string nombre)
        {
            string sql = "SELECT * FROM Socios s WHERE s.nombre = '" + nombre + "'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable traerNombresSocios()
        {
            string sql = "SELECT nombre FROM Socios";
            return _BD.EjecutarSelect(sql);
        }


        public DataTable traerTodosLodDatosSocios()
        {
            string sql = "SELECT * FROM Socios";
            return _BD.EjecutarSelect(sql);
        }



    }
}
