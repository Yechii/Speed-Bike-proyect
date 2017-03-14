using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventarioSP.Pojos
{
    class clsVariables
    {

        private string pcodigo;
        private string pnombre;
        private string pdescripcion;
        private string pmarca;
        private string pmodelo;
        private string pcategoria;
        private double pprecio;
        private double pcantiadad;
        private string pcolor_sabor;

        public string codigo
        {
            get { return pcodigo; }
            set { pcodigo = value; }
        }
        public string nombre
        {
            get { return pnombre; }
            set { pnombre = value; }
        }
        public string descripcion
        {
            get { return pdescripcion; }
            set { pdescripcion = value; }
        }
        public string marca
        {
            get { return pmarca; }
            set { pmarca = value; }
        }
        public string modelo
        {
            get { return pmodelo; }
            set { pmodelo = value; }
        }
        public string categoria
        {
            get { return pcategoria; }
            set { pcategoria = value; }
        }
        public double precio
        {
            get { return pprecio; }
            set { pprecio = value; }
        }
        public double cantiadad
        {
            get { return pcantiadad; }
            set { pcantiadad = value; }
        }
        public string color_sabor
        {
            get { return pcolor_sabor; }
            set { pcolor_sabor = value; }
        }


    }
}