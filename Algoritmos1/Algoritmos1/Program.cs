using Algoritmos1;
using System.Data;
using System.Diagnostics;



Nodo DesemRey = new Nodo() { Nombre = "DesemRey" };
Nodo Braavos = new Nodo() { Nombre = "Braavos" };
Nodo Qarth = new Nodo() { Nombre = "Qarth" };
Nodo Asshai = new Nodo() { Nombre = "Asshai" };
Nodo Meereen = new Nodo() { Nombre = "Meereen" };
Nodo Pentos = new Nodo() { Nombre = "Pentos" };
Nodo Volantis = new Nodo() { Nombre = "Volantis" };


DesemRey.Caminos.Add( new Camino() { Nodo = Braavos, CostoOro = 1200 ,PorsentajeMuertes=0.07 });
DesemRey.Caminos.Add( new Camino() { Nodo = Qarth, CostoOro = 1900 , PorsentajeMuertes = 0.09  });
DesemRey.Caminos.Add( new Camino() { Nodo = Asshai, CostoOro = 1050, PorsentajeMuertes = 0.01 });
DesemRey.Caminos.Add(new Camino() { Nodo = Meereen, CostoOro = 900, PorsentajeMuertes = 0.03 });
DesemRey.Caminos.Add(new Camino() { Nodo = Pentos, CostoOro = 950, PorsentajeMuertes = 0.04 });
DesemRey.Caminos.Add(new Camino() { Nodo = Volantis, CostoOro = 1600, PorsentajeMuertes = 0.06 });

Braavos.Caminos.Add(new Camino() { Nodo = DesemRey, CostoOro = 1200, PorsentajeMuertes = 0.00 });
Braavos.Caminos.Add(new Camino() { Nodo = Qarth, CostoOro = 1900, PorsentajeMuertes = 0.11 });
Braavos.Caminos.Add(new Camino() { Nodo = Asshai, CostoOro = 1000, PorsentajeMuertes = 0.12 });
Braavos.Caminos.Add(new Camino() { Nodo = Meereen, CostoOro = 1800, PorsentajeMuertes = 0.02 });
Braavos.Caminos.Add(new Camino() { Nodo = Pentos, CostoOro = 1300, PorsentajeMuertes = 0.04 });
Braavos.Caminos.Add(new Camino() { Nodo = Volantis, CostoOro = 1000, PorsentajeMuertes = 0.02 });

Qarth.Caminos.Add(new Camino() { Nodo = DesemRey, CostoOro = 1900, PorsentajeMuertes = 0.00 });
Qarth.Caminos.Add(new Camino() { Nodo = Braavos, CostoOro = 1900, PorsentajeMuertes = 0.11 });
Qarth.Caminos.Add(new Camino() { Nodo = Asshai, CostoOro = 500, PorsentajeMuertes = 0.07 });
Qarth.Caminos.Add(new Camino() { Nodo = Meereen, CostoOro = 700, PorsentajeMuertes = 0.06 });
Qarth.Caminos.Add(new Camino() { Nodo = Pentos, CostoOro = 1200, PorsentajeMuertes = 0.03 });
Qarth.Caminos.Add(new Camino() { Nodo = Volantis, CostoOro = 1050, PorsentajeMuertes = 0.03 });

Asshai.Caminos.Add(new Camino() { Nodo = DesemRey, CostoOro = 1050, PorsentajeMuertes = 0.00 });
Asshai.Caminos.Add(new Camino() { Nodo = Braavos, CostoOro = 1000, PorsentajeMuertes = 0.12 });
Asshai.Caminos.Add(new Camino() { Nodo = Qarth, CostoOro = 500, PorsentajeMuertes = 0.07 });
Asshai.Caminos.Add(new Camino() { Nodo = Meereen, CostoOro = 300, PorsentajeMuertes = 0.05 });
Asshai.Caminos.Add(new Camino() { Nodo = Pentos, CostoOro = 1100, PorsentajeMuertes = 0.02 });
Asshai.Caminos.Add(new Camino() { Nodo = Volantis, CostoOro = 1100, PorsentajeMuertes = 0.08 });


Meereen.Caminos.Add(new Camino() { Nodo = DesemRey, CostoOro = 900, PorsentajeMuertes = 0.00 });
Meereen.Caminos.Add(new Camino() { Nodo = Braavos, CostoOro = 1800, PorsentajeMuertes = 0.02 });
Meereen.Caminos.Add(new Camino() { Nodo = Qarth, CostoOro = 700, PorsentajeMuertes = 0.06 });
Meereen.Caminos.Add(new Camino() { Nodo = Asshai, CostoOro = 300, PorsentajeMuertes = 0.05 });
Meereen.Caminos.Add(new Camino() { Nodo = Pentos, CostoOro = 200, PorsentajeMuertes = 0.15 });
Meereen.Caminos.Add(new Camino() { Nodo = Volantis, CostoOro = 1600, PorsentajeMuertes = 0.01 });


Pentos.Caminos.Add(new Camino() { Nodo = DesemRey, CostoOro = 950, PorsentajeMuertes = 0.00 });
Pentos.Caminos.Add(new Camino() { Nodo = Braavos, CostoOro = 1300, PorsentajeMuertes = 0.04 });
Pentos.Caminos.Add(new Camino() { Nodo = Qarth, CostoOro = 1200, PorsentajeMuertes = 0.03 });
Pentos.Caminos.Add(new Camino() { Nodo = Asshai, CostoOro = 1100, PorsentajeMuertes = 0.02 });
Pentos.Caminos.Add(new Camino() { Nodo = Meereen, CostoOro = 200, PorsentajeMuertes = 0.15 });
Pentos.Caminos.Add(new Camino() { Nodo = Volantis, CostoOro = 800, PorsentajeMuertes = 0.03 });


Volantis.Caminos.Add(new Camino() { Nodo = DesemRey, CostoOro = 1600, PorsentajeMuertes = 0.00 });
Volantis.Caminos.Add(new Camino() { Nodo = Braavos, CostoOro = 1000, PorsentajeMuertes = 0.02 });
Volantis.Caminos.Add(new Camino() { Nodo = Qarth, CostoOro = 1050, PorsentajeMuertes = 0.03 });
Volantis.Caminos.Add(new Camino() { Nodo = Asshai, CostoOro = 1100, PorsentajeMuertes = 0.08 });
Volantis.Caminos.Add(new Camino() { Nodo = Meereen, CostoOro = 1600, PorsentajeMuertes = 0.01 });
Volantis.Caminos.Add(new Camino() { Nodo = Pentos, CostoOro = 800, PorsentajeMuertes = 0.03 });


List<Nodo> graph = new List<Nodo>() { DesemRey, Braavos, Qarth, Asshai, Meereen, Pentos, Volantis };

AlgoritmoTSP tsp = new AlgoritmoTSP(graph, 20, DesemRey);
tsp.Caminar();
Console.WriteLine(tsp.GetTodasRutas);
Console.WriteLine("El menor costo en oro es "+tsp.MenorGasatoOro +"  y la menor taza de muerte de soldados es de "+tsp.MenorMuertesSoldados); 
