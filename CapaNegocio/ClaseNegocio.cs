using CapaDatos;
using CapaEntidad;
using System;
using System.Data;

namespace CapaNegocio
{
    public class ClaseNegocio
    {
        ClaseDatos objd = new ClaseDatos();

        public DataTable N_Lista_Articulos()
        {
            return objd.D_Lista_Articulos();
        }

        public DataTable N_Busqueda_Articulos(ClaseEntidad obje)
        {
            return objd.D_Busqueda_Articulos(obje);
        }

        public String N_Mantenimiento_Articulos(ClaseEntidad obje)
        {
            return objd.D_Mantenimiento_Articulos(obje);

        }
    }
}
