using System;
using Lanchonete.Decorators;
using Lanchonete.Observers;
using Lanchonete.Extras;

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um pedido de hambúrguer simples
            IHamburguer meuHamburguer = new HamburguerSimples();
            
            // Adicionando ingredientes ao hambúrguer utilizando o padrão Decorator
            meuHamburguer = new Queijo(meuHamburguer);
            meuHamburguer = new Bacon(meuHamburguer);
            meuHamburguer = new Ovo(meuHamburguer);
            meuHamburguer = new Alface(meuHamburguer);
            meuHamburguer = new Tomate(meuHamburguer);

            // Criando o pedido
            Pedido pedido = new Pedido(meuHamburguer);

            // Criando os observadores: produção e montagem
            MonitorProducao producao = new MonitorProducao();
            MonitorMontagem montagem = new MonitorMontagem();

            // Adicionando observadores ao pedido
            pedido.AdicionarObservador(producao);
            pedido.AdicionarObservador(montagem);

            // Exibindo detalhes do pedido
            Console.WriteLine("Pedido criado: " + pedido.GetDescricaoPedido());

            // Finalizando o pedido e notificando os observadores (em produção)
            pedido.FinalizarPedido("Em Produção");

            // Simulando a inclusão de outros itens (batata frita, refrigerante, sobremesa)
            ItemAdicional batata = new BatataFrita();
            ItemAdicional refrigerante = new Refrigerante();
            ItemAdicional sobremesa = new Sobremesa();

            Console.WriteLine("\nItens adicionais:");
            Console.WriteLine($"{batata.GetDescricao()} - R$ {batata.GetPreco()}");
            Console.WriteLine($"{refrigerante.GetDescricao()} - R$ {refrigerante.GetPreco()}");
            Console.WriteLine($"{sobremesa.GetDescricao()} - R$ {sobremesa.GetPreco()}");

            // Simulando a finalização do pedido e notificando que está pronto para entrega
            pedido.FinalizarPedido("Pronto para Entrega");

            // Exibindo total do pedido (hambúrguer + itens adicionais)
            double totalPedido = meuHamburguer.GetPreco() + batata.GetPreco() + refrigerante.GetPreco() + sobremesa.GetPreco();
            Console.WriteLine($"\nTotal do Pedido: R$ {totalPedido}");
        }
    }
}
