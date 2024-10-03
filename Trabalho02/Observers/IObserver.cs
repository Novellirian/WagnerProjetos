namespace Lanchonete.Observers
{
    // Interface Observer
    public interface IObserver
    {
        void Atualizar(Decorators.IHamburguer hamburguer, string status);
    }
}
