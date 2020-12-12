using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PadariaVirtual 
{
    class Usuario
    {
        string login;
        string senha;
        int id;
        List<Usuario> usuariosregistrados = new List<Usuario>();
        Conexão con = new Conexão();
        public Usuario()
        {
            this.login = null;
            this.senha = null;
            this.id = 0;
        }
        public Usuario(string login, string senha, int id)
        {
            this.login = login;
            this.senha = senha;
            this.id = id;

        }          
        public string LoginCadastro
        {
            get { return login; }
            set { login = value; }
        }
        
        public string SenhaCadastro
        {
            get { return senha; }
            set { senha = value; }
        }      
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public List<Usuario> UsuariosRegistrados
        {
            get { return usuariosregistrados; }
            set { usuariosregistrados = value;}
        }
        public void Salvar(string Login,string Senha)
        {
                
                SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (LoginCadastro,SenhaCadastro) VALUES (@Login, @Senha)");
                cmd.Parameters.AddWithValue("@Login", Login);
                cmd.Parameters.AddWithValue("@Senha", Senha);
                cmd.Connection = con.conectar();                
                cmd.ExecuteNonQuery();
                Console.WriteLine("SALVO");
         
        }
    }      
}

