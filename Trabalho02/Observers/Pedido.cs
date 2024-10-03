using System.Collections.Generic;
using Lanchonete.Decorators;

namespace Lanchonete.Observers
{
    // Subject - Pedido
    public class Pedido
    {
        private List<IObserver> observadores = new List<IObserver>();
        private IHamburguer hamburguer;
        private string status;

        public Pedido(IHamburguer hamburguer)
        {
            this.hamburguer = hamburguer;
        }

        // Adiciona observador
        public void AdicionarObservador(IObserver observador)
        {
            observadores.Add(observador);
        }

        // Remove observador
        public void RemoverObservador(IObserver observador)
        {
            observadores.Remove(observador);
        }

        // Notifica todos os observadores
        public void Notificar()
        {
            foreach (var observador in observadores)
            {
                observador.Atualizar(hamburguer, status);
            }
        }

        // Finaliza o pedido e notifica os observadores
        public void FinalizarPedido(string novoStatus)
        {
            this.status = novoStatus;
            Notificar();
        }

        public string GetDescricaoPedido()
        {
            return hamburguer.GetDescricao() + " - Total: R$ " + hamburguer.GetPreco();
        }
    }
}
