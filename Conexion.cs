using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5
{
    class Conexion
    {
        public SqlConnection con;
        public SqlCommand cmd;

        //Crea y abre la conexión
        public SqlConnection Conectar()
        {
            con = new SqlConnection("Server=.; Database=Todo; Trusted_Connection=True");
            con.Open();
            return con;
        }
        public DataTable Tareas()
        {
            DataTable datos = new DataTable();
            try
            {
                SqlDataAdapter adp = new SqlDataAdapter("Select * From tbTareas Where Estado='Activa'", Conectar());
                adp.Fill(datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return datos;
        }
        public void insertTarea(string tarea, DateTime fecha)
        {
            try
            {
                cmd = new SqlCommand("insertTarea", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Tarea", tarea);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro ingresado");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
       
        public void marcarTarea(int idTarea)
        {
            try
            {
                 cmd = new SqlCommand("marcarTarea", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTarea", idTarea);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void borrarTarea(int idTarea)
        {
            try
            {
                 cmd = new SqlCommand("deleteTarea", Conectar());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idTarea", idTarea);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro cancelado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
