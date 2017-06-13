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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TrabalhoLP4
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

        

        

        private void btnCadastrarRelatorio_Click(object sender, RoutedEventArgs e)
        {
            new Cadastrar().Show();
        }

        private void btnConsultarRelatorio_Click(object sender, RoutedEventArgs e)
        {
            new Consultar().Show();
        }

        private void btnExcluirRelatorio_Click(object sender, RoutedEventArgs e)
        {
            new Excluir().Show();
        }

        private void btnAtualizarRelatorio_Click(object sender, RoutedEventArgs e)
        {
            new Atualizar().Show();
        }

        
    }
}
