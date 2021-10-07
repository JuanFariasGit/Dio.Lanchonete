using System;

namespace Dio.Lanchonete
{
    class Program
    {
        private static int[] produtosQuantidade = new int[4] {0 , 0, 0, 0};
        private static double[] produtosPreco = new double[4] {1.45, 1.45, 25.00, 2.50};
        private static string[] produtoNome = new string[4] {"Caneta preta (Bic)", "Caneta azul (Bic)", "Resma de papel A4", "Lapiseira (Bic)"};

        public static void Main(string[] args) 
        {
            string opcao = "";

            while (opcao.ToUpper() != "X") {
            Menu();
            opcao = Console.ReadLine();
            switch (opcao) {
                case "1":
                AdicionarCarrinho();
                break;
                case "2":
                Console.Clear();
                VisualizarCarrinho();
                break;
                case "3":
                Console.Clear();
                FinalizarCompra();
                break;
            } 
            }
        }
        
            private static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("|              Papelaria DIO              |");
            Console.WriteLine("===========================================");
            Console.WriteLine("|Codigo   |  Produto            | Preco   |");
            Console.WriteLine("|001      | Caneta preta (Bic)  | R$ 1,45 |");
            Console.WriteLine("|002      | Caneta azul (Bic)   | R$ 1,45 |");
            Console.WriteLine("|003      | Resma de papel A4   | R$ 25,00|");
            Console.WriteLine("|004      | Lapiseira (Bic)     | R$ 2,50 |");
            Console.WriteLine("===========================================");
            Console.WriteLine("1 - Adicionar carrinho");
            Console.WriteLine("2 - Visualizar carrinho");
            Console.WriteLine("3 - Finalizar compra");
            Console.WriteLine("X - Sair");
        }

        private static void AdicionarCarrinho() 
        {
            string opcao = "1";

            while (opcao != "2") {
            if (opcao == "1") {
                Console.WriteLine("Insira o codigo do produto: ");
                string codigo = Console.ReadLine();
                Console.WriteLine("Insira a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                switch (codigo) {
                case "001":
                    produtosQuantidade[0] += quantidade;
                    break;
                case "002":
                    produtosQuantidade[1] += quantidade;
                    break;
                case "003":
                    produtosQuantidade[2] += quantidade;
                    break;
                case "004":
                    produtosQuantidade[3] += quantidade;
                    break;
                }
            }
            Console.WriteLine("Deseja continuar adicionando ?\n\n1 - Sim 2 - Nao");
            opcao = Console.ReadLine();
            }
        }

        private static void VisualizarCarrinho()
        {
            string opcao;

            for (int i = 0; i < 4; i++) {
            if (produtosQuantidade[i] != 0) {
                string produto = produtoNome[i];
                int quantidade = produtosQuantidade[i];
                double preco = produtosPreco[i];
                double subtotal = preco*quantidade;
                Console.WriteLine("Codigo: 00{0} | Produto: {1} | Quantidade: {2} | Preco: R$ {3} | Subtotal: R$ {4} ", i + 1, produto, quantidade, 
                preco.ToString("N2").Replace(".", ","), subtotal.ToString("N2").Replace(".", ","));
            }
            }

            while (true) {
            Console.WriteLine("\n\nPrecione qualquer tecla para voltar ao menu");
            opcao = Console.ReadLine();
            break;
            }
        }

        private static void FinalizarCompra() 
        {
            string opcao;

            double total = 0.00;
            for (int i = 0; i < 4; i++) {
                if (produtosQuantidade[i] != 0) {
                total += produtosQuantidade[i]*produtosPreco[i];
                produtosQuantidade[i] = 0;
                }
            }
            Console.WriteLine("Total a pagar: {0}", total.ToString("N2").Replace(".", ","));

            while (true) {
            Console.WriteLine("\n\nPrecione qualquer tecla para voltar ao menu");
            opcao = Console.ReadLine();
            break;
            }
        }
    }
}
