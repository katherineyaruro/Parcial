using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial
{
    public class Empleado
    {
        private int cedula, telefono;
        private string nombre, email, direccion, ciudad;


        public Empleado(int cc,string nom,string email1,string dir, string ciudad1, int tel)
        {
            cedula = cc;
            telefono = tel;
            nombre = nom;
            email = email1;
            direccion = dir;
            ciudad = ciudad1;
        }

        public int Cedula
        {
            get{return cedula;}
            set {cedula=value;}
          
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }

        }
        public string Email
        {
            get { return email; }
            set { email = value; }

        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }

        }
        public string Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }

        }

    }
}