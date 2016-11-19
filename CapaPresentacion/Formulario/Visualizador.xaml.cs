using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CapaPresentacion.Formulario
{
    /// <summary>
    /// Interaction logic for Visualizador.xaml
    /// </summary>
    public partial class Visualizador : Window
    {
        public Visualizador()
        {
            InitializeComponent();
            Cargador();
        }

        private void Cargador()
        {
            ColumnBasic Ver =  new ColumnBasic();
            StkTest.Children.Add(Ver);
        }
    }
}
