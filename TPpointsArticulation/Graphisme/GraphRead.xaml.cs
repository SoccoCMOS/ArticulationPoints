using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Collections.Generic;
using TPpointsArticulation.Code_behind;

namespace TPpointsArticulation.Graphisme
{

    public partial class GraphRead : Window
    {
        Graphe gr;
        public GraphRead(int nb)
        {
            InitializeComponent();
            gr = new Graphe(nb);

            DataTable dt = new DataTable();
            dt.Columns.Add("Si", typeof(String));
            List<Object>[] temp=new List<object>[nb];

            for (int k=0; k< nb; k++)
            {
                // Labels
                dt.Columns.Add("S" + k, typeof(bool));
                temp[k] = new List<object>();
                temp[k].Add("S" + k);
            }

            for (int i=0; i< nb; i++)
            {
                // Ajout des checkbox
                for (int j=0; j< nb; j++)
                {
                   temp[i].Add(false);                    
                }
                // Ajout de la ligne complète
                dt.Rows.Add(temp[i].ToArray());
            }
            this.dataGrid.ItemsSource = dt.DefaultView;
            this.dataGrid.CanUserAddRows = false;
        }

        public Graphe getGraphe()
        {
            return gr;
        }

        private void validate(object sender, EventArgs e)
        {
            // Récupérer les données du datagrid
            DataView dv = (DataView)dataGrid.ItemsSource;

            // Parcourir les lignes 
            DataTable dt = dv.Table;
  
            for (int i=0;i<dt.Rows.Count;i++)
            {
                object[] a = dt.Rows[i].ItemArray;
                for (int j=1;j<a.Length;j++)
                {
                    if((Boolean)a[j]== true)
                    {
                        this.gr.getSommet(i).AddVoisin(j - 1);
                    }
                }                              
            }

            this.Close();
        }
    }
}
