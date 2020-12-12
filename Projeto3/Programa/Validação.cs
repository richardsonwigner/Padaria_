using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaVirtual
{
    class Validação
    {
        public string mensagem = "";      
        Conexão con = new Conexão();
        SqlDataReader DataReader;
        public bool EncontrarUsuario(string Login)
        {
            bool UsuarioEncontrado = false;
            SqlCommand cmd = new SqlCommand("select * from Usuarios where LoginCadastro = @Login");          
            cmd.Parameters.AddWithValue("@Login", Login);
            try
            {
                cmd.Connection = con.conectar();
                DataReader = cmd.ExecuteReader();
                if (DataReader.HasRows)
                {
                    UsuarioEncontrado = true;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Ocorreu um Erro com o Banco de Dados");
                Console.WriteLine(ex.Message);              
            }
            return UsuarioEncontrado;            
        }
        public bool EncontrarSenha(string Senha)
        {
            bool UsuarioEncontrado = false;
            SqlCommand cmd = new SqlCommand("select * from Usuarios where SenhaCadastro = @Senha");
            cmd.Parameters.AddWithValue("@Senha", Senha);
            try
            {
                cmd.Connection = con.conectar();
                DataReader = cmd.ExecuteReader();
                if (DataReader.HasRows)
                {
                    UsuarioEncontrado = true;
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("Ocorreu um Erro com o Banco de Dados");
            }
            return UsuarioEncontrado;
        }

    }
}
