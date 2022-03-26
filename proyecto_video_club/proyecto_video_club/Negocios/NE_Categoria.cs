using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyecto_video_club.Clases;

namespace proyecto_video_club.Negocios
{
    class NE_Categoria
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public string IdCategoria { get; set; }

        public string NombreCategoria { get; set; }

        public void RegistrarCategoria()
        {
            string sql = "";

            sql = @"INSERT INTO Categorias(id_categoria,nombre) VALUES(";
            sql += IdCategoria;
            sql += ",'" + NombreCategoria + "')";

            _BD.Insertar(sql);
        }


    }
}
