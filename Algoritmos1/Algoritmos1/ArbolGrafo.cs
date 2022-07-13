using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1
{
    internal class ArbolGrafo
    {
        public NodoGrafo Raiz { get; set; }
        public ArbolGrafo()
        {
            Raiz = null;
        }
        public void Agregar(NodoGrafo n)
        {
            NodoGrafo nodo = new NodoGrafo(n.Info);
            Raiz = AgregarW(nodo, Raiz);
        }

        public NodoGrafo AgregarW(NodoGrafo ng, NodoGrafo raiz)
        {
            if (raiz == null)
            {
                raiz = ng;
            }
            else if(ng.Info < raiz.Info)
            {
                raiz.NodoIzq = AgregarW(ng, raiz.NodoIzq);
            }
            else
            {
                raiz.NodoDer = AgregarW(ng, raiz.NodoDer);

            }
            return raiz;
        }

        
        public int Imprimir(NodoGrafo ng)
        {
            if (ng == null)
            {
                return 0;
            }

            //  [Izq | Info | Der ]
            string cad = string.Format("[{0}|{1}|{2}]", 
                    ng.NodoIzq == null ?"null": ng.NodoIzq.Info,
                    ng.Info,
                    ng.NodoDer == null ?"null": ng.NodoDer.Info);
            Console.WriteLine(cad);
            Imprimir(ng.NodoIzq);
            Imprimir(ng.NodoDer);
            return 0;
        }

        // Implementar un algoritmo de busqueda en arboles binarios
        public NodoGrafo Buscar(int buscar, NodoGrafo ng)
        {
            if (ng != null)
            {
                if (buscar < ng.Info)
                {
                    Buscar(buscar,ng.NodoIzq);
               
                }
                else if (buscar > ng.Info)
                {
                    Buscar(buscar, ng.NodoDer);
                
                }
                string cad = string.Format("[{0}|{1}|{2}]",
               ng.NodoIzq == null ? "null" : ng.NodoIzq.Info,
               ng.Info,
               ng.NodoDer == null ? "null" : ng.NodoDer.Info);
                Console.WriteLine(cad);

            }
            else
            {
                Console.WriteLine("El numero "+buscar+" no existe en el arbol ");
            }

            return ng;
        }
    }
}
