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

namespace ControlDeEventos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            BotonIzquierdoTextBox.IsReadOnly = true;
            BotonDerechoTextBox.IsReadOnly = true;
            FocusTexBox.IsReadOnly = true;
            RatonSobreTexBox.IsReadOnly = true;
            
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string mensaje = "";
            if (TextBox1 != null)
            {
                mensaje = TextBox1.Text.ToUpper();
                TextBox1.Select(mensaje.Length, 0);
                TextBox1.Text = mensaje;
            }
        }              

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBox2.Text = "Ayuda";
            }

        }

        private void TextBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            FocusTexBox.Text = "TextBox1";
        }

        private void TextBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            FocusTexBox.Text = "TextBox2";
        }

        private void TextBox3_GotFocus(object sender, RoutedEventArgs e)
        {
            FocusTexBox.Text = "TextBox3";
        }

        private void TextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            string mensaje = "";
            for (int i = 0; i < TextBox3.Text.Length; i++)
            {
                if (TextBox3.Text[i] != 'a' &&
                    TextBox3.Text[i] != 'A' &&
                    TextBox3.Text[i] != 'e' &&
                    TextBox3.Text[i] != 'E' &&
                    TextBox3.Text[i] != 'i' &&
                    TextBox3.Text[i] != 'I' &&
                    TextBox3.Text[i] != 'o' &&
                    TextBox3.Text[i] != 'O' &&
                    TextBox3.Text[i] != 'u' &&
                    TextBox3.Text[i] != 'U')
                {
                    mensaje += TextBox3.Text[i].ToString();
                }
            }

            //El primer dígito es para saber si escribre antes del cursor = 0 o si escribe después del cursor mensaje.length (como se escribre normalmente)
            //El segundo dígito es para la anchura del cursor, es decir, 0, cursor normal, >0 entonces se solapa el ancho del cursor con el texto, sale el cursor de "sobreescribir"
            TextBox3.Select(mensaje.Length, 0);
            TextBox3.Text = mensaje;
        }

        private void TextBox1_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobreTexBox.Text = "TextBox1";
        }

        private void TextBox1_MouseLeave(object sender, MouseEventArgs e)
        {
           RatonSobreTexBox.Text = "";
        }

        private void TextBox2_MouseEnter(object sender, MouseEventArgs e)
        {
           RatonSobreTexBox.Text = "TextBox2";
        }

        private void TextBox2_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobreTexBox.Text = "";
        }

        private void TextBox3_MouseEnter(object sender, MouseEventArgs e)
        {
           RatonSobreTexBox.Text = "TextBox3";
        }

        private void TextBox3_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobreTexBox.Text = "";
        }

        private void InterfazMainWindow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            BotonIzquierdoTextBox.Background = Brushes.DarkGreen;
        }

        private void InterfazMainWindow_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            BotonDerechoTextBox.Background = Brushes.DarkGreen;
            
        }

        private void InterfazMainWindow_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            BotonIzquierdoTextBox.Background = Brushes.White;

        }

        private void InterfazMainWindow_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {

            BotonDerechoTextBox.Background = Brushes.White;
        }

        private void BotonIzquierdoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            BotonIzquierdoTextBox.IsReadOnly = true;
        }

        private void BotonDerechoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            BotonDerechoTextBox.IsReadOnly = true;
        }

        private void FocusTexBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FocusTexBox.Text = "";
        }

        private void RatonSobreTexBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FocusTexBox.Text = "";
        }

        private void BotonIzquierdoTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FocusTexBox.Text = "";
        }

        private void BotonDerechoTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            FocusTexBox.Text = "";
        }
    }
}
