using System;

namespace PadariaVirtual
{
    class Program
    {
        static Produto produto = new Produto();
        static void Main(string[] args)
        {
          
            ControleUsuario Cadastrar_Usuario = new ControleUsuario();
            IniciarCatalogo();
            Cadastrar_Usuario.PedirUsuario();
        }
        public static void IniciarCatalogo()
        {
           Produto.Produtos.Add(new Produto(0, "Pão Francês", 20, 0.5f, "Pao"));
           Produto.Produtos.Add(new Produto(1, "Pão Doce", 20, 0.5f, "Pao"));
           Produto.Produtos.Add(new Produto(2, "Pão Especial", 20, 0.7f, "Pao"));
           Produto.Produtos.Add(new Produto(3, "Pão de Queijo", 20, 2.5f, "Pao"));
           Produto.Produtos.Add(new Produto(4, "Pão Integral", 20, 1.00f, "Pao"));
           Produto.Produtos.Add(new Produto(5, "Leite Integral", 20, 3.5f, "Leite"));
           Produto.Produtos.Add(new Produto(6, "Leite Desnatado", 20, 3.00f, "Leite"));
           Produto.Produtos.Add(new Produto(7, "Leite Semi-Desnatado", 20, 3.25f, "Leite"));
           Produto.Produtos.Add(new Produto(8, "Biscoito Recheado", 20, 2.5f, "Biscoito"));
           Produto.Produtos.Add(new Produto(9, "Biscoito Polvilho", 20, 2.99f, "Biscoito"));
           Produto.Produtos.Add(new Produto(10, "Biscoito Água e Sal", 20, 2.00f, "Biscoito"));
           Produto.Produtos.Add(new Produto(11, "Biscoito (Wafer)", 20, 2.99f, "Biscoito"));
           Produto.Produtos.Add(new Produto(12, "Biscoito (Cookie)", 20, 3.5f, "Biscoito"));
           Produto.Produtos.Add(new Produto(13, "Bolo de Fubá ", 20, 5.99f, "Bolo"));
           Produto.Produtos.Add(new Produto(14, "Bolo de Chocolate", 20, 5.99f, "Bolo"));
           Produto.Produtos.Add(new Produto(15, "Bolo de Laranja", 20, 5.99f, "Bolo"));
           Produto.Produtos.Add(new Produto(16, "Bolo de Cenoura", 20, 6.5f, "Bolo"));
           Produto.Produtos.Add(new Produto(17, "Bolo de Festa", 20, 25.99f, "Bolo"));
           Produto.Produtos.Add(new Produto(18, "Refrigerante 2L", 20, 7.50f, "Bebida"));
           Produto.Produtos.Add(new Produto(19, "Refrigerante 600mL", 20, 5.00f, "Bebida"));
           Produto.Produtos.Add(new Produto(20, "Refrigerante Lata", 20, 3.5f, "Bebida"));
           Produto.Produtos.Add(new Produto(21, "Água mineral", 20, 2.5f, "Bebida"));
           Produto.Produtos.Add(new Produto(22, "Café", 20, 1.00f, "Bebida"));
           Produto.Produtos.Add(new Produto(23, "Suco", 20, 3.50f, "Bebida"));
           Produto.Produtos.Add(new Produto(24, "Energético", 20, 8.99f, "Bebida"));
           Produto.Produtos.Add(new Produto(25, "Café com Leite", 20, 2.5f, "Bebida"));
        }
    }


}
