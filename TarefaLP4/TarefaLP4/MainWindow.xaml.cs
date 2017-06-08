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

namespace TarefaLP4
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEviar_Click(object sender, RoutedEventArgs e)
        {
            /*
           // Criação do objeto Connection, que é quem, de fato, estabelece a conexão com o Banco
           MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;Database=Relatorio;Uid=root;Pwd=");
           // Criação do objeto MySqlCommand, que controla a interação com o Banco de dados.
           MySqlCommand cmd1 = new MySqlCommand();
           cmd1.Connection = conn;
           cmd1.CommandText = "INSERT INTO Relatorio (Id, NomeAluno, Relatorio) VALUES (@Id, @NomeAluno, @Relatorio);";*/

            // Forma suscinta de criar e configurar o objeto MySqlCommand
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=127.0.0.1; Database=ControleAlunos; Uid=root; Pwd ="),
                CommandText = "INSERT INTO Diario (Id, NomeAluno, Relatorio) VALUES (@Id, @NomeAluno, @Relatorio);"
            };

            // Insere no lugar dos marcadores de posição (@xxxx) do CommandText os valores que estão nas textboxes
            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@Relatorio", txtRelatorio.Text);

            //Executa o comando no banco.
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            if (result == 1)
                MessageBox.Show("Enviado");
            else
                MessageBox.Show("Algo inesperado aconteceu. Tente novamente");
        }
        private void btnConsultaRelatorios_Click(object sender, RoutedEventArgs e)
        {
            new Consultar().Show();
        }

        
    }
}
