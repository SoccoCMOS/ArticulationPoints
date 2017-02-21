using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpointsArticulation.Code_behind
{
  public class Graphe
  {
       int nb=0;
       Sommet[] G;

       public Graphe(int n)
          {
            this.G = new Sommet[n];
            for (int i=0; i< n; i++)
            {
                addSommet(new Sommet(i));
            }
          }
      
        public int getNb()
        {
            return this.nb;
        }

        public Sommet getSommet(int i)
        {
            return G[i];
        }
         
       public void addSommet(Sommet s)
        {
            this.G[nb] = s;
            this.nb++;
        }
  }
}
