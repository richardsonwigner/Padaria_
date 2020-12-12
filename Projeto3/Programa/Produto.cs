using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadariaVirtual
{
    class Produto
    {
        int codigo;
        string nome;
        int qtd;
        double valor;
        string categoria;
        public static List<Produto> Produtos = new List<Produto>();
        public int Codigo
        {
            get { return codigo; }
            set {  codigo = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public Produto()
        {

        }
        public Produto(int codigo, string nome, int qtd, double valor, string categoria)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.qtd = qtd;
            this.valor = valor;
            this.categoria = categoria;
        }
        public void DiminuirEstoque(int qtd)
        {
            this.qtd -= qtd;
        }
        public override string ToString()
        {
            return $"Codigo:{Codigo} Produto:{Nome}\nPreço {Valor:C2}:{Qtd}";
        }
    }
}

