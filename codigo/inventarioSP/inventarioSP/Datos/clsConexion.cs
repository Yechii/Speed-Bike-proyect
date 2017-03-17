using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace inventarioSP.Datos
{
    class clsConexion
    {
        #region Conexion
        private MySqlConnection cnConexion = new MySqlConnection();

        public void Conectar()
        {
            string strCadenaConexion;
            strCadenaConexion = "SERVER=" + "127.0.0.1" + ";PORT=3306" + ";DATABASE=" + "speekbike" + ";UID=" + "root" + ";PWD=" + "root";
            cnConexion.ConnectionString = strCadenaConexion;
            cnConexion.Open();
        }

        public List<Pojos.clsVariables> Buscar(string bus)
        {
            List<Pojos.clsVariables> lstProd = new List<Pojos.clsVariables>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "SELECT p.codigo as CLAVE, p.nombre AS PRODUCTO, p.marca AS MARCA, c.nombre as CATEGORIA , p.precio AS PRECIO, p.cantidad AS CANTIDAD, p.color_sabor AS COLOR_SABOR from "
                +"productos p join categorias c on p.categoria = c.id where "
                + " p.codigo like '%" + bus + "%' or p.nombre like '%" + bus + "%' or p.marca  like '%"
                 +bus + "%' or c.nombre  like '%" + bus + "%' or p.precio like '%" + bus +
                "%' or p.cantidad like '%" + bus + "%' or p.color_sabor like '%" + bus + "%'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsVariables objValores = new Pojos.clsVariables();
                objValores.CODIGO = dr.GetString("CLAVE");
                objValores.NOMBRE = dr.GetString("PRODUCTO");
                objValores.MARCA = dr.GetString("MARCA");
                objValores.CATEGORIA = dr.GetString("CATEGORIA");
                objValores.PRECIO = dr.GetDouble("PRECIO");
                objValores.CANTIDAD = dr.GetInt32("CANTIDAD");
                objValores.COLOR_SABOR = dr.GetString("COLOR_SABOR");
                lstProd.Add(objValores);
            }
            Cerrar();
            return lstProd;
        }


        public List<Pojos.clsVariables> llenar()
        {
            List<Pojos.clsVariables> lstProd = new List<Pojos.clsVariables>();
            string sql;
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            Conectar();
            sql = "select p.codigo as CLAVE, p.nombre AS PRODUCTO, p.marca AS MARCA, c.nombre as CATEGORIA , p.precio AS PRECIO, p.cantidad AS CANTIDAD, p.color_sabor AS COLOR_SABOR from productos p join categorias c on p.categoria = c.id;";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsVariables objValores = new Pojos.clsVariables();
                objValores.CODIGO = dr.GetString("CLAVE");
                objValores.NOMBRE = dr.GetString("PRODUCTO");
                objValores.MARCA = dr.GetString("MARCA");
                objValores.CATEGORIA = dr.GetString("CATEGORIA");
                objValores.PRECIO = dr.GetDouble("PRECIO");
                objValores.CANTIDAD = dr.GetInt32("CANTIDAD");
                objValores.COLOR_SABOR = dr.GetString("COLOR_SABOR");
                lstProd.Add(objValores);
            }
            Cerrar();
            return lstProd;
        }

        public string autenticar(string nom) {
            string a ="" ;
            Conectar();
            string sql = "select nombre, pass from usuarios where nombre like '" + nom + "';";
            MySqlCommand cm = new MySqlCommand();
            MySqlDataReader dr;
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                a = dr.GetString("pass");
            }
                Cerrar();
            return a;
                } 

        public void Cerrar()
        {
            cnConexion.Close();
        }
        #endregion
    }

}