using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_video_club.Clases;


namespace proyecto_video_club.Negocios
{
    class NE_Peliculas
    {
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public string CodPelicula { get; set; }
        public string NombrePelicula { get; set; }
        public string PrecioPelicula { get; set; }
        public string CategoriaPelicula { get; set; }


        public void RegistrarPelicula()
        {
            string sql = "";

            sql += @"INSERT INTO Peliculas(cod_pelicula,nombre,precio,idCategoria) VALUES(";
            sql += CodPelicula;
            sql += ",'" + NombrePelicula + "'";
            sql += "," + PrecioPelicula;
            sql += ",'" + CategoriaPelicula + "')";

            _BD.Insertar(sql);
        }

        public void CargarCombo(ref ComboBox combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "id_categoria";
            combo.DataSource = _BD.EjecutarSelect("SELECT nombre, id_categoria FROM Categorias");
        }



    }
}
