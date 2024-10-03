namespace Lanchonete.Decorators
{
    // Ingrediente Queijo (Concrete Decorator)
    public class Queijo : IngredienteDecorador
    {
        public Queijo(IHamburguer hamburguer) : base(hamburguer) { }

        public override string GetDescricao()
        {
            return hamburguer.GetDescricao() + ", Queijo";
        }

        public override double GetPreco()
        {
            return hamburguer.GetPreco() + 1.50;
        }
    }
}
