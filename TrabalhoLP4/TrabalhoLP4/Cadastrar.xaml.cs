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
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TrabalhoLP4
{
    /// <summary>
    /// Interaction logic for Cadastrar.xaml
    /// </summary>
    public partial class Cadastrar : Window
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btnEviar_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=127.0.0.1; Database=controlealuno; Uid=root; Pwd =root"),
                CommandText = "INSERT INTO diario (Id, Data, NomeAluno, Relatorio) VALUES (@Id,@Data, @NomeAluno, @Relatorio);"
            };

            // Insere no lugar dos marcadores de posição (@xxxx) do CommandText os valores que estão nas textboxes
            cmd.Parameters.AddWithValue("@Id", txtID.Text);
            cmd.Parameters.AddWithValue("@Data", txtData.Text);
            cmd.Parameters.AddWithValue("@NomeAluno", txtNome.Text);
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

        private void txtID_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        }
    }

