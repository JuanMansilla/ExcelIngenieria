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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace CapaPresentacion
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

        private Boolean FIniActivate = false;
        private string FInicial;

        public string FInicial1
        {
            get
            {
                return FInicial;
            }

            set
            {
                FInicial = value;
            }
        }

        public string FFinal1
        {
            get
            {
                return FFinal;
            }

            set
            {
                FFinal = value;
            }
        }

        private string FFinal;

        private void FIni_Select(object sender, DependencyPropertyChangedEventArgs e)
        {
           
        }

        private void FFin_Selec(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (FIniActivate)
            {
                
            }

        }

        private void Btn_Cancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Aceptar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChBx_Fecha_Checked(object sender, RoutedEventArgs e)
        {
            if (ChBx_Fecha.IsChecked == true)
            {
                GB_FechaFinal.IsEnabled = true;
            }
            else
            {
                GB_FechaFinal.IsEnabled = false;
            }
        }

        private void FechaIncio_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            FechaFin.IsEnabled = true;
            // ... Get DatePicker reference.
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                FInicial1 = date.Value.ToShortDateString();
                if(RB_FID.IsChecked==true)
                {
                    FInicial1 += "-D";
                }
                else FInicial1 += "-N";
                MessageBox.Show(FInicial1); // Example 18/12/16
            }

        }

        private void FechaFin_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;

            // ... Get nullable DateTime from SelectedDate.
            DateTime? date = picker.SelectedDate;
            if (date == null)
            {
                // ... A null object.
                this.Title = "No date";
            }
            else
            {
                // ... No need to display the time.
                FFinal1 = date.Value.ToShortDateString();
                if (RB_FFD.IsChecked == true)
                {
                    FFinal1 += "-D";
                }
                else FFinal1 += "-N";
                MessageBox.Show(FFinal1); // Example 18/12/16
            }

        }
    }
}
