using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1
{
    internal class NodoGrafo
    {
        public int Info { get; set; }
        public NodoGrafo NodoIzq 
        {
            get;set; 
        }
        public NodoGrafo NodoDer { get; set;}

        public NodoGrafo(int info)
        {
            Info = info;
            NodoIzq = null;
            NodoDer = null;

        }

        public override string ToString()
        {
            return Info.ToString();
        }
    }
}
