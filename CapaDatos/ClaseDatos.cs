using CapaEntidad;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ClaseDatos
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public DataTable D_Lista_Articulos()
        {
            SqlCommand cmd = new SqlCommand("sp_Lista_Articulos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable D_Busqueda_Articulos(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_Busqueda_Articulos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public String D_Mantenimiento_Articulos(ClaseEntidad obje)
        {
            SqlCommand cmd = new SqlCommand("sp_Mantenimiento_Articulos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            cmd.Parameters.AddWithValue("@descripcion", obje.descripcion);
            cmd.Parameters.AddWithValue("@precio", obje.precio);
            cmd.Parameters.AddWithValue("@cantidad", obje.cantidad);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            string accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
    }
}
