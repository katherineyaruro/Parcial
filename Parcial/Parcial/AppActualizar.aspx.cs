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
    public partial class AppActualizar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //conexion base de datos
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=C:\Users\LAB104BPC7\Documents\Visual Studio 2012\Projects\Parcial\Parcial\App_Data\aspnet-Parcial-20150424191233.mdf;Initial Catalog=aspnet-Parcial-20150424191233;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadena);
            int cc=int.Parse(txtCedula.Text);
            string sqlCommand = "select * from Empleado where cedula ="+" '"+cc+"'";
            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Label5.Visible = true;
            txtCiudad.Visible = true;
            txtDireccion.Visible = true;
            txtEmail.Visible = true;
            txtTelefono.Visible = true;
            DataTable data = new DataTable();
            cn.Open();
            int record = da.Fill(data);
            GridView1.DataSource = data;
            GridView1.DataBind();
            cn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc6\documents\visual studio 2012\Projects\Parcial\Parcial\App_Data\aspnet-Parcial-20150424191233.mdf;Initial Catalog=aspnet-Parcial-20150424191233;Integrated Security=True";

            SqlConnection cn = new SqlConnection(cadena);
            string correo = txtEmail.Text;
            string dir = txtDireccion.Text;
            string ciu = txtCiudad.Text;
            int tel = int.Parse(txtTelefono.Text);
            cn.Open();
            string sqlCommand = "UPDATE Empleado set email="+"'"+correo+"'"+",direccion="+"'"+dir+"'"+",ciudad="+"'"+ciu+"'"+",telefono="+"'"+tel+"'";
     // string sqlComman2d = "INSERT INTO Empleado(cedula,nombre,email,direccion,ciudad,telefono) VALUES" + "('" + ce + "','" + nom + "','" + ema + "','" + dir + "','" + ciu + "','" + tel + "')";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();

        }
    }
}