namespace Lanchonete.Decorators
{
    // Ingrediente Bacon (Concrete Decorator)
    public class Bacon : IngredienteDecorador
    {
        public Bacon(IHamburguer hamburguer) : base(hamburguer) { }

        public override string GetDescricao()
        {
            return hamburguer.GetDescricao() + ", Bacon";
        }

        public override double GetPreco()
        {
            return hamburguer.GetPreco() + 2.00;
        }
    }
}
