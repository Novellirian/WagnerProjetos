using System;
using Lanchonete.Decorators;

namespace Lanchonete.Observers
{
    // Concrete Observer - Monitor de Montagem
    public class MonitorMontagem : IObserver
    {
        public void Atualizar(IHamburguer hamburguer, string status)
        {
            Console.WriteLine($"[Montagem] Pedido atualizado: {hamburguer.GetDescricao()} - Status: {status}");
        }
    }
}
