using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaVirtual
{
    class Fluxo
    {
        
        static double Valor;
        static Carrinho carrinho = new Carrinho();
        static ControleUsuario controleusuario = new ControleUsuario();
             
        public void PedirUsuario()
        {
            Console.WriteLine("Escolha o que fazer:");
            Console.WriteLine("1:FazerPedido");
            Console.WriteLine("2:Sair");
            string EscolhaUsuario = Console.ReadLine();
            if (EscolhaUsuario == "1")
            {
                Pedido();
            }
            else if (EscolhaUsuario == "2")
            {
                controleusuario.PedirUsuario();
            }
        }
        public void Pedido()
        {
            bool Loop = true;
            while (Loop == true)
            {
                Console.WriteLine("Escolha o número do tipo de produto");
                Console.WriteLine("1:Pão");
                Console.WriteLine("2:Leite");
                Console.WriteLine("3:Biscoito");
                Console.WriteLine("4:Bolo");
                Console.WriteLine("5:Bebidas");
                if (carrinho.CarrinhoCliente.Count != 0)
                {
                    Console.WriteLine("6:Verificar Carrinho");
                    Console.WriteLine("7:Realizar Pagamento");
                }                
                string EscolhaUsuario = Console.ReadLine();
                Dictionary<string, string> dicionario = new Dictionary<string, string>();
                dicionario.Add("1", "Pao"); dicionario.Add("2", "Leite"); dicionario.Add("3", "Biscoito");
                dicionario.Add("4", "Bolo"); dicionario.Add("5", "Bebida");
                if (dicionario.Keys.Contains(EscolhaUsuario))
                {
                    Catalogo(dicionario[EscolhaUsuario]);
                }
                else if (EscolhaUsuario == "6")
                {
                    VerificarCarrinho();                  
                }
                else if (EscolhaUsuario == "7")
                {                   
                    Pagamento();
                }
                else
                {
                    Console.WriteLine("Nenhuma opção escolhida");
                }
            }
        }
        public void Catalogo(string nomeProduto)
        {
            Console.WriteLine("Produtos dessa categoria");
            Produto.Produtos.FindAll(x => x.Categoria == nomeProduto)
            .ForEach(x => Console.WriteLine(x.ToString()));                   
            Console.WriteLine("Escolha o Codigo Do produto que deseja");
            int CodigoProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade");
            int QuantidadeDesejada = int.Parse(Console.ReadLine());          
            RealizarPedido(CodigoProduto, QuantidadeDesejada);
        }
        public void RealizarPedido(int CodigoProduto, int QuantidadeDesejada)
        {
            Produto ProdutoEscolhido = Produto.Produtos.Find(x => x.Codigo == CodigoProduto);
            if (QuantidadeDesejada < ProdutoEscolhido.Qtd)
            {
                ProdutoEscolhido.DiminuirEstoque(QuantidadeDesejada);
                carrinho.CarrinhoCliente
                .Add(new Carrinho(ProdutoEscolhido.Nome, QuantidadeDesejada, ProdutoEscolhido.Codigo, ProdutoEscolhido.Valor));
                Valor = carrinho.CarrinhoCliente.Sum(x => x.TotalValor());
                Pedido();
            }
            else
            {
                Console.WriteLine("Quantidade Maior que o estoque");
                Pedido();
            }
           
        }
        public void VerificarCarrinho()
        {
            bool Loop = true;
            while (Loop == true)
            {
                carrinho.CarrinhoCliente.ForEach(x => Console.WriteLine(x.ToString()));
                Console.WriteLine("1:Remover Produto");
                Console.WriteLine("2:Sair");
                string EscolhaUsuario = Console.ReadLine();
                if (EscolhaUsuario == "1")
                {
                    Console.WriteLine("Escolha o Codigo Do produto");
                    int ProdutoEscolhido = int.Parse(Console.ReadLine());
                    Carrinho produtoescolhido = carrinho.CarrinhoCliente.Find(x => x.Codigo == ProdutoEscolhido);
                    carrinho.CarrinhoCliente.Remove(produtoescolhido);
                }
                else if (EscolhaUsuario == "2")
                {
                    Loop = false;
                }
            }
            Pedido();
        }
        public void Pagamento()
        {
            Console.WriteLine("////PAGAMENTO////");
            Console.WriteLine("Digite seu nome");
            string NomeCliente = Console.ReadLine(); Console.WriteLine("Digite seu endereço");
            string Endereço = Console.ReadLine();
            Console.WriteLine("////COMPRA FINALIZADA////");
            Console.WriteLine($"Total da compra {Valor:C2}R$");
            Console.WriteLine("Nome:{0} Endereço:{1}", NomeCliente, Endereço);
            carrinho.CarrinhoCliente.ForEach(x => Console.WriteLine(x.ToString()));
            carrinho.CarrinhoCliente.Clear();
            Console.WriteLine("1:Continuar Comprando:");
            Console.WriteLine("2:Logout");
            string EscolhaUsuario = Console.ReadLine();
            if (EscolhaUsuario == "1")
            {
                Pedido();
            }
            else if (EscolhaUsuario == "2")
            {
                controleusuario.PedirUsuario();
            }
        }
    }
}
