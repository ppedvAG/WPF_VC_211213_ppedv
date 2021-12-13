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

namespace Controls
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

        private void Btn_KlickMich_Click(object sender, RoutedEventArgs e)
        {
            Lbl_Output.Content = (Cbb_Auswahl.SelectedItem as ComboBoxItem)?.Content;

            Tbl_String.Text = Sdr_Wert.Value.ToString();
        }

        private void Beenden_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Möchtest du wirklich beenden?", "Beenden", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                this.Close();

            //Application.Current.Shutdown();
        }

        private void Neu_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private void Dialog_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().ShowDialog();
        }
    }
}
