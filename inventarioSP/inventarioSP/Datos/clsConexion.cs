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
            sql = "SELECT p.codigo, p.nombre, p.descripcion, p.marca, p.modelo, c.nombre as categoria , p.precio, p.cantidad, p.color_sabor from productos p join categorias c on p.categoria = c.id where "
                + "p.codigo like '%" + bus + "%' or p.nombre like '%" + bus +
                "%' or p.descripcion  like '%" + bus + "%' or p.marca  like '%"
                + bus + "%' or p.modelo  like '%" +
                bus + "%' or c.nombre  like '%" + bus + "%' or p.precio like '%" + bus +
                "%' or p.cantidad like '%" + bus + "%' or p.color_sabor like '%" + bus + "%'";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsVariables objValores = new Pojos.clsVariables();
                objValores.codigo = dr.GetString("codigo");
                objValores.nombre = dr.GetString("Nombre");
                objValores.descripcion = dr.GetString("descripcion");
                objValores.marca = dr.GetString("marca");
                objValores.modelo = dr.GetString("modelo");
                objValores.categoria = dr.GetString("categoria");
                objValores.precio = dr.GetDouble("precio");
                objValores.cantiadad = dr.GetInt32("cantidad");
                objValores.color_sabor = dr.GetString("color_sabor");
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
            sql = "select p.codigo, p.nombre, p.descripcion,"+
            "p.marca, p.modelo, c.nombre as categoria , p.precio,"+
            "p.cantidad, p.color_sabor from productos p join categorias c on p.categoria = c.id;";
            cm.CommandText = sql;
            cm.CommandType = CommandType.Text;
            cm.Connection = cnConexion;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Pojos.clsVariables objValores = new Pojos.clsVariables();
                objValores.codigo = dr.GetString("codigo");
                objValores.nombre = dr.GetString("Nombre");
                objValores.descripcion = dr.GetString("descripcion");
                objValores.marca = dr.GetString("marca");
                objValores.modelo = dr.GetString("modelo");
                objValores.categoria = dr.GetString("categoria");
                objValores.precio = dr.GetDouble("precio");
                objValores.cantiadad = dr.GetInt32("cantidad");
                objValores.color_sabor = dr.GetString("color_sabor");
                lstProd.Add(objValores);
            }
            Cerrar();
            return lstProd;
        }

        public void Cerrar()
        {
            cnConexion.Close();
        }
        #endregion
    }

}