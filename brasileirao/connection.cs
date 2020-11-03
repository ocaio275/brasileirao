using System;
using MySql.Data.MySqlClient;

namespace brasileirao
{
    class connection
    {
        //String para passar os dados do Banco de Dados 
        public string conec = "server=localhost; port=3306; database=brasileirao; uid=root; pwd=";

        //Construtor da String de conexão
        public MySqlConnection con = null;
        

        //Método para Abrir conexão com o BD
        public void OpenConn()
        {
            //tratamento de erro ao tentar se conectar 
            try
            {
                //passando os parametros do BD
                con = new MySqlConnection(conec);

                //Comando para abrir conexão
                con.Open();
            }
            catch (Exception ex)
            {
                //Mostrar erro ao estabelecer no BD(se caso ocorra)
                Console.WriteLine("ERROR: " + ex);
                throw;
            }
        }

        //Método para finalizar conexão 
        public void CloseConn()
        {
            //tratamento de erro ao tentar se encerrar conexão
            try
            {
                //passando os parametros do BD
                con = new MySqlConnection(conec);

                //Comando para finalizar conexão
                con.Close();
            }
            catch (Exception ex)
            {
                //Mostrar erro ao estabelecer no BD(se caso ocorra)
                Console.WriteLine("ERROR: " + ex);
                throw;
            }
        }

    }
}
