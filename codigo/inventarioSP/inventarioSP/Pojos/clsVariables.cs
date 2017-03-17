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
        private string pmarca;
        private string pcategoria;
        private double pprecio;
        private double pcantiadad;
        private string pcolor_sabor;

        public string CODIGO
        {
            get { return pcodigo; }
            set { pcodigo = value; }
        }
        public string NOMBRE
        {
            get { return pnombre; }
            set { pnombre = value; }
        }
        
        public string MARCA
        {
            get { return pmarca; }
            set { pmarca = value; }
        }
        
        public string CATEGORIA
        {
            get { return pcategoria; }
            set { pcategoria = value; }
        }
        public double PRECIO
        {
            get { return pprecio; }
            set { pprecio = value; }
        }
        public double CANTIDAD
        {
            get { return pcantiadad; }
            set { pcantiadad = value; }
        }
        public string COLOR_SABOR
        {
            get { return pcolor_sabor; }
            set { pcolor_sabor = value; }
        }


    }
}