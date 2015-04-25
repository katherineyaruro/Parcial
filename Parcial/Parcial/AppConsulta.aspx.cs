using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace Parcial
{
    public partial class AppConsulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //conexion base de datos
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=C:\Users\LAB104BPC7\Documents\Visual Studio 2012\Projects\Parcial\Parcial\App_Data\aspnet-Parcial-20150424191233.mdf;Initial Catalog=aspnet-Parcial-20150424191233;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadena);

            string sqlCommand = "select * from Empleado";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            //  SqlCommand comando = new SqlCommand(sqlCommand, cn);
            //comando.ExecuteNonQuery();
            DataTable data = new DataTable();
            cn.Open();
            int record = da.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
            cn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}