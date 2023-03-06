using Plotter;
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

namespace PlotterFeladat
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

        private void btnPlotterInditas_Click(object sender, RoutedEventArgs e)
        {
            Plotter.Plotter rajzgep=new Plotter.Plotter(800,600,6);

            rajzgep.EszkozBetoltese(1, Colors.LightSeaGreen, 2);
            rajzgep.EszkozBetoltese(2, Colors.Blue, 1);
            rajzgep.EszkozBetoltese(6, Color.FromRgb(0,255,0),10);

            rajzgep.Show();

            rajzgep.FejMozgatas(100);
            rajzgep.FejLe();
            rajzgep.FejFel();
            rajzgep.FejForditas(-55.7);
            rajzgep.FejMozgatas(new Point(300,200));
            rajzgep.EszkozCsere(5);
            rajzgep.Close();

        }
            
    }
    
}
