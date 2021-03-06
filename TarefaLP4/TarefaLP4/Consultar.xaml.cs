﻿using System;
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

namespace TarefaLP4
{
    /// <summary>
    /// Lógica interna para Consultar.xaml
    /// </summary>
    public partial class Consultar : Window
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand
            {
                Connection = new MySqlConnection("Server=127.0.0.1;Database=ControleAluno;Uid=root;Pwd="),
                CommandText = "SELECT * FROM DIARIO WHERE NomeAluno = @nome;"
            };

            cmd.Parameters.AddWithValue("@nome", txtAlunoBuscado.Text);

            //Executa o comando no banco.
            cmd.Connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            cmd.Connection.Close();


            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nome = reader.GetString(1);
                    string relatorio = reader.GetString(2);

                    txtMostrarRelatorio.Text = relatorio;

                }
            }
        }
    }
}
