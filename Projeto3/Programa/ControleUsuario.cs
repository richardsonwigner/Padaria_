using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaVirtual
{
    class ControleUsuario
    {
        static Fluxo fluxo = new Fluxo();
        static Usuario cadastro = new Usuario();
        public void PedirUsuario()
        {
            bool Loop = true;
            while (Loop == true)
            {
                Console.WriteLine("Fazer Login Ou Cadastro?");
                Console.WriteLine("1:Login");
                Console.WriteLine("2:Cadastro");
                string PedidoUsuario = Console.ReadLine();
                if (PedidoUsuario == "1")
                {
                    PedirLogin();
                }
                else if (PedidoUsuario == "2")
                {
                    PedirCadastro();
                }
            }
        }
        public void PedirCadastro()
        {
            Console.WriteLine("/////////CADASTRO/////////");
            Console.WriteLine("Login");
            string Login = Console.ReadLine();
            Console.WriteLine("Senha");
            string Senha = Console.ReadLine();
            bool UsuarioEncontrado = VerificarLogin(Login);
            if (UsuarioEncontrado == false)
            {
                RealizarCadastro(Login, Senha);
                PedirLogin();

            }
            else if(UsuarioEncontrado == true)
            {
                Console.WriteLine("Login Já Registrado");
            }         
        }
        public void PedirLogin()
        {
            bool Loop = true;           
            Console.WriteLine("/////////Login/////////");
            Console.WriteLine("Login");
            string Login = Console.ReadLine();
            Console.WriteLine("Senha");
            string Senha = Console.ReadLine();
            bool UsuarioEncontrado = VerificarLogin(Login);
            bool SenhaEncontrada = VerificarSenha(Senha);
            if (UsuarioEncontrado == true && SenhaEncontrada == true)
            {
                Console.WriteLine("LoginRealizado");
                fluxo.PedirUsuario();
                
            }
            else if (UsuarioEncontrado == false || SenhaEncontrada == false)
            {
                Console.WriteLine("Usuario ou Senha incorreta");
            }

        }
        public virtual void RealizarCadastro(string Login, string Senha)
        {
            cadastro.UsuariosRegistrados.Add(new Usuario(Login, Senha,0));
            cadastro.Salvar(Login,Senha);
        }
        public bool VerificarLogin(string Login)
        {
            Validação validação = new Validação();
            bool Validar = validação.EncontrarUsuario(Login);          
            return Validar;
        }
        public bool VerificarSenha(string Senha)
        {
            Validação validação = new Validação();
            bool Validar = validação.EncontrarSenha(Senha);
            return Validar;
        }
    }
}
