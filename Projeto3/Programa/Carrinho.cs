using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaVirtual
{
    class Carrinho
    {
        string clienteproduto;
        int qtd;
        int codigo;
        double valor;
        static Produto produto = new Produto();
        List<Carrinho> carrinho = new List<Carrinho>();
        public Carrinho() { }
        public Carrinho(string clienteproduto, int qtd,int codigo,double valor)
        {
            this.clienteproduto = clienteproduto;
            this.qtd = qtd;
            this.codigo = codigo;
            this.valor = valor;
        }
        public List<Carrinho> CarrinhoCliente
        {
            get { return carrinho; }
            set{ carrinho = value; }
        }             
        public double TotalValor()
        {
            return qtd * valor ;
        }
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
        public string ClienteProduto
        {
            get { return clienteproduto; }
            set { clienteproduto = value; }
        }
        public int Codigo 
        { get { return codigo; }}
        public override string ToString()
        {
            return $"Produto:{Codigo}:{ClienteProduto}\nQuantidade:{Qtd}";
        }
    }
}
