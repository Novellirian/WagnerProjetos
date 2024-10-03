namespace Lanchonete.Decorators
{
    // Decorator abstrato para ingredientes adicionais
    public abstract class IngredienteDecorador : IHamburguer
    {
        protected IHamburguer hamburguer;

        public IngredienteDecorador(IHamburguer hamburguer)
        {
            this.hamburguer = hamburguer;
        }

        public virtual string GetDescricao()
        {
            return hamburguer.GetDescricao();
        }

        public virtual double GetPreco()
        {
            return hamburguer.GetPreco();
        }
    }
}
