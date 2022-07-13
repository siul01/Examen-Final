using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1
{
    public class Nodo
    {
        public string Nombre { get; set; }

        public List<Camino> Caminos { get; set; }

        public Nodo()
        {
            Caminos = new List<Camino>();
        }

    }

    public struct Camino
    {
        public Nodo Nodo { get; set; }
        public int CostoOro { get; set; }
        public double PorsentajeMuertes { get; set; }
    }

    public class Ruta
    {
        public List<Nodo> Nodos { get; set; }
        public int GastoOroTotal { get; set; }
        public double MuertesTotal  { get; set; }

        public Ruta()
        {
            Nodos = new List<Nodo>();
            GastoOroTotal = 0;
            MuertesTotal = 0;
        }
    }
}
