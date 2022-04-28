using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MySqlConnector;

namespace MySql01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnConectar_Clicked(object sender, EventArgs e)
        {
            try
            {
                string strConexao =
                    "server = " + edtServidor.Text +
                    ";port = " + edtPorta.Text +
                    ";uid = " + edtUsuario.Text +
                    ";pwd = " + edtSenha.Text +
                    ";database = " + edtBanco.Text;

                MySqlConnection conexao = new MySqlConnection(strConexao);
                conexao.Open();
                DisplayAlert("Conexão", "Conexão realizada com sucesso!", "OK");
                conexao.Close();
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", ex.Message, "OK");
            }
        }
    }
}
