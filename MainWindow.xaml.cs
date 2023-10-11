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

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textoEscribir.Foreground = Brushes.Blue;
        }

        private void textoLeer_KeyUp(object sender, KeyEventArgs e)
        {
            textoEscribir.Text = textoLeer.Text;
        }
        private void textoLeer_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            textoEscribir.Text = textoLeer.Text;
        }

        private void negrita_Click(object sender, RoutedEventArgs e)
        {
            if (textoEscribir.FontWeight == FontWeights.Bold)
                textoEscribir.FontWeight = FontWeights.Normal;
            else
                textoEscribir.FontWeight = FontWeights.Bold;
            
        }

        private void cursiva_Click(object sender, RoutedEventArgs e)
        {
            if (textoEscribir.FontStyle == FontStyles.Italic)            
                textoEscribir.FontStyle = FontStyles.Normal;            
            else 
                textoEscribir.FontStyle = FontStyles.Italic;
            
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            
            RadioButton colorTipo =(RadioButton)sender;
            if (colorTipo.Tag.ToString() == "colorAzul")
                textoEscribir.Foreground = Brushes.Blue;
            else if(colorTipo.Tag.ToString() == "colorRojo")
                textoEscribir.Foreground = Brushes.Red;
            else
                textoEscribir.Foreground = Brushes.Green;

        }
    }
}
