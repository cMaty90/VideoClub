using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto_video_club.Formularios;
using proyecto_video_club.Formularios.Socios;
using proyecto_video_club.Formularios.Categorias;
using proyecto_video_club.Formularios.Peliculas;
using proyecto_video_club.Formularios.Transaccion;



namespace proyecto_video_club
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Frm_Alta_Socios());
            //Application.Run(new Frm_Alta_Categoria());
            //Application.Run(new Frm_Alta_Peliculas());
            //Application.Run(new Frm_Alta_Factura());
            Application.Run(new Frm_Menu_Principal());
        }
    }
}
