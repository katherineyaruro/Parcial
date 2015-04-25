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
    public partial class AppRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int ce, tel;
            string nom, ema, dir, ciu;
            ce = int.Parse(txtCedula.Text);
            tel = int.Parse(txtTelefono.Text);
            nom = txtNombre.Text;
            ema = txtCorreo.Text;
            dir = txtDir.Text;
            ciu = txtCiudad.Text;
            string cadena = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=C:\Users\LAB104BPC7\Documents\Visual Studio 2012\Projects\Parcial\Parcial\App_Data\aspnet-Parcial-20150424191233.mdf;Initial Catalog=aspnet-Parcial-20150424191233;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);

            cn.Open();
            string sqlCommand = "INSERT INTO Empleado(cedula,nombre,email,direccion,ciudad,telefono) VALUES" + "('" + ce + "','" + nom + "','" + ema + "','" + dir + "','" + ciu + "','" + tel + "')";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, cn);
            SqlCommand comando = new SqlCommand(sqlCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

    
    }
}