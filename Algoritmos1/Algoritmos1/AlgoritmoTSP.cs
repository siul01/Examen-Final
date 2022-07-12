using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos1
{
    public class AlgoritmoTSP
    {
        private List<Nodo> _graph { get; set; }
        private int _n = 0;
        private Nodo _origen { get; set; }
        private List<Ruta> _soluciones { get; set; }


        public AlgoritmoTSP( List<Nodo> graph, int n, Nodo origen)
        {
            _graph = graph;
            _n = n;
            _origen = origen; 
        }

        public void Caminar()
        {
            _soluciones = new List<Ruta>();
            for (int i = 0; i < _n; i++)
            {
                _soluciones.Add(GenerarRuta());
            }
        }

        private Ruta GenerarRuta()
        {
            Ruta solucion = new Ruta();
            solucion.Nodos.Add(_origen);
            Nodo actual = _origen;
            int soldados=1000;
            for (int i = 0; i < _graph.Count - 1; i++)
            {
                Nodo siguiente = null;
                do
                {
                    siguiente = SiguienteNodo(actual);

                } while (solucion.Nodos.Contains(siguiente));
                solucion.Nodos.Add(siguiente);
                solucion.GastoOroTotal += actual.Caminos.Where(d => d.Nodo.Nombre == siguiente.Nombre).First().CostoOro;
                solucion.MuertesTotal +=soldados * actual.Caminos.Where(d =>d.Nodo.Nombre == siguiente.Nombre).First().PorsentajeMuertes;
                actual = siguiente;
            }
            solucion.Nodos.Add(_origen);
            solucion.GastoOroTotal += actual.Caminos.Where(d => d.Nodo.Nombre == _origen.Nombre).First().CostoOro;
            solucion.MuertesTotal +=actual.Caminos.Where(d => d.Nodo.Nombre == _origen.Nombre).First().PorsentajeMuertes;
            return solucion;

        }
        
        private Nodo? SiguienteNodo(Nodo actual)
        {
            int siguienteNodo = new Random().Next(0, +_graph.Count - 1);
            return actual.Caminos[siguienteNodo].Nodo;
        }

        public string GetTodasRutas
        {

            get
            {
                int i = 1;
                int oro = 20000;  //oro inicial de la expedicion
                int OroFinal; //variable para almacenar el oro sobrante
                int soldados = 1000;
                double soldadossobrantes;
                string result = string.Empty;
                foreach (var ruta in _soluciones)
                {
                    foreach (var nodo in ruta.Nodos)
                    {
                        result += nodo.Nombre + "-";
                    }
                    OroFinal = oro - ruta.GastoOroTotal; //resta para saber cuanto le sobra
                    soldadossobrantes = soldados - ruta.MuertesTotal;
                    result += "Invacion N° "+i+".-  Costo de la invación  "+ ruta.GastoOroTotal + "\n" + 
                        "  - El oro sobrante es de :" +OroFinal+ "\n" +
                        "  -La cantidad de muertes es : "+ruta.MuertesTotal + "\n"+
                        "  -Los soldados sobrantes son : " +soldadossobrantes+"\n \n" ;
                    i++;
                }
              
                return result;
            }
        }
        public int MenorGasatoOro     //funcion para sacar la menor costo de cruzada
        {
            get
            {
                int menor = 10000;
                foreach (var ruta in _soluciones)
                {
                    foreach (var nodo in ruta.Nodos)
                    {
                        if (ruta.GastoOroTotal < menor)
                        {
                            menor = ruta.GastoOroTotal;
                        }
                    }
                   
                }
                return menor;

            }

        }
        public double MenorMuertesSoldados     //funcion para sacar la menor baja de muestes
        {
            get
            {
                double menorMuerte = 10000;
                foreach (var ruta in _soluciones)
                {
                    foreach (var nodo in ruta.Nodos)
                    {
                        if (ruta.MuertesTotal < menorMuerte)
                        {
                            menorMuerte = ruta.MuertesTotal;
                        }
                    }

                }
                return menorMuerte;

            }

        }

    }
}
