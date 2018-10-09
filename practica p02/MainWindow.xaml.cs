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

namespace practica_p02
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

        private void cbTipo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelTipo.Children.Clear();

            switch (cbTipo.SelectedIndex)
            {
                case 0:
                    panelTipo.Children.Add(new ControlHombre());
                    break;
                case 1:
                    panelTipo.Children.Add(new ControlMujer());
                    break;
                case 2:
                    panelTipo.Children.Add(new CntrolOtros());
                    break;
            }

            txtRespuesta.Text = "Entre la información";
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            switch (cbTipo.SelectedIndex)
            {
                case 0:
                    var controlHombre = (ControlHombre)panelTipo.Children[0];

                    int divorcios = int.Parse(controlHombre.txtDivorcios.Text);

                    if(divorcios > 1)
                    {
                        txtRespuesta.Text = "Rechazado";
                    }
                    else
                    {
                        txtRespuesta.Text = "Aceptado";
                    }
                    break;
                case 1:
                    break;
                case 2:
                    break;
                            }
        }
    }
}
