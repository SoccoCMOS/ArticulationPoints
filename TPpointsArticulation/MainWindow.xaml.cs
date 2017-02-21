using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TPpointsArticulation.Code_behind;

namespace TPpointsArticulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void exit_button(object sender,EventArgs e)
        {
            this.Close();
        }

        private void read_graphe(object sender, EventArgs e)
        {
            // Lecture nombre de sommets
            decimal nbs;
            Decimal.TryParse(this.textBox.Text,out nbs);
            // Lecture du graphe
            //Graphisme.GraphRead winG = new Graphisme.GraphRead((int)Decimal.Truncate(nbs));
            Graphisme.GraphRead winG = new Graphisme.GraphRead(10);
            winG.Owner = this;
            winG.ShowDialog();
            showGraphe(winG.getGraphe());
        }

        private void showGraphe(Graphe g)
        {
            for (int i=0; i<g.getNb(); i++)
            {
                MessageBox.Show(g.getSommet(i).printSommet());
            }
        }
    }
}
