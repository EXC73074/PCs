using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMproductosRicardo
{
    class ProductosRicardo
    {
        int codigo;
        public int Pcodigo { get => codigo; set => codigo = value; }
        string detalle;
        public string Pdetalle { get => detalle; set => detalle = value; }
        int tipo;
        public int Ptipo { get => tipo;set=>tipo = value; }
        int marca;
        public int Pmarca { get => marca; set => marca = value; }
        double precio;
        public double Pprecio { get => precio; set => precio = value; }
        DateTime fecha;
        public DateTime Pfecha { get => fecha; set => fecha = value; }

        public string ToStringProductosRicardo()
        {
            return detalle + " " + "$"+precio;
        }

    }
}
