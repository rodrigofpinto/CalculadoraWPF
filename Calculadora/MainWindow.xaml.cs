using System.Diagnostics;
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

namespace Calculadora
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

        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double numero1 = double.Parse(num1.Text);
                double numero2 = double.Parse(num2.Text);

                double resultado = numero1 + numero2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.", "Erro de Formato", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSubtrair_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double numero1 = double.Parse(num1.Text);
                double numero2 = double.Parse(num2.Text);

                double resultado = numero1 - numero2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.", "Erro de Formato", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double numero1 = double.Parse(num1.Text);
                double numero2 = double.Parse(num2.Text);

                double resultado = numero1 * numero2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.", "Erro de Formato", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDividir_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double numero1 = double.Parse(num1.Text);
                double numero2 = double.Parse(num2.Text);

                double resultado = numero1 / numero2;

                txtResultado.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.", "Erro de Formato", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            num1.Clear();
            num2.Clear();
            txtResultado.Clear();
        }
        //Calculadora
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("calc.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a calculadora: " + ex.Message);
            }
        }

        private void btnOpenExplorador_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("explorer.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a calculadora: " + ex.Message);
            }
        }

        private void btnOpenPaint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("mspaint.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a calculadora: " + ex.Message);
            }
        }

        private void btnOpenGestorDispositivos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("devmgmt.msc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a calculadora: " + ex.Message);
            }
        }

        private void btnOpenServicos_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("services.msc");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a calculadora: " + ex.Message);
            }
        }

        private void btnOpenPainelControlo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start("control.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a calculadora: " + ex.Message);
            }
        }

        private void btnOpenChrome_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a calculadora: " + ex.Message);
            }
        }

        private void btnProgressUp_Click(object sender, RoutedEventArgs e)
        {
            PB.Value += 10;
            if (PB.Value == 100)
            { PB.Value = 0; }
        }

        private void btnProgressDrown_Click(object sender, RoutedEventArgs e)
        {
            PB.Value -= 10;
            if (PB.Value == 100)
            { PB.Value = 0; }
        }
    }
}