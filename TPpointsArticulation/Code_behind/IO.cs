using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpointsArticulation.Code_behind
{
    class IO
    {
       // Méthodes de récupération
        public Graphe lire_graphe(int nbsmax)
        {
            Graphe g = new Graphe(nbsmax);
            return g;
        }
    }
}
