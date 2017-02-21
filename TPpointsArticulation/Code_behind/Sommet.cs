using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPpointsArticulation.Code_behind
{
    public class Sommet
    {
        int num;
        List<int> voisin = new List<int>();

        public Sommet(int i)
        {
            num = i;
        }

        public Sommet(int numSommet, List<int> v)
        {
            this.num = numSommet;
            this.voisin = v;
        }

        public void AddVoisin(int sv)
        {
            this.voisin.Add(sv);
        }

        public void deleteVoisin(int sv)
        {
            this.voisin.Remove(sv);
        }

        public String printSommet()
        {
            String s="S" + num+": ";
            foreach(int v in voisin)
            {
                s += (v + ";");
            }
            return s;
        }
    }
}
