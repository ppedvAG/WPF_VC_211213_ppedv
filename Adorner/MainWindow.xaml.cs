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

namespace AdornerBsp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Tbx_Show.Loaded += (s, e) =>
            {
                //Diese Methode durchläuft den VisualTree ausgehend von dem eingebenen UIElement nach oben und gibt das
                //erste AdornerLayer zurück, welches es findet. Die Elemente müssen dafür schon vorhanden sein. Hier
                //bekommen wir das Layer von der Textbox zurück.
                AdornerLayer adLayer = AdornerLayer.GetAdornerLayer(Tbx_Show);

                //Hinzufgen des Adorners zum Layer
                adLayer.Add(new SimpleCircleAdorner(Tbx_Show));

            };
        }
    }
}
