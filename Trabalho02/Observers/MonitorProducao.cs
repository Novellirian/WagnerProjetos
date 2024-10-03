using System;
using Lanchonete.Decorators;

namespace Lanchonete.Observers
{
    // Concrete Observer - Monitor de Produção
    public class MonitorProducao : IObserver
    {
        public void Atualizar(IHamburguer hamburguer, string status)
        {
            Console.WriteLine($"[Produção] Pedido atualizado: {hamburguer.GetDescricao()} - Status: {status}");
        }
    }
}
