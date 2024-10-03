namespace Lanchonete.Decorators
{
    // Ingrediente Alface (Concrete Decorator)
    public class Alface : IngredienteDecorador
    {
        public Alface(IHamburguer hamburguer) : base(hamburguer) { }

        public override string GetDescricao()
        {
            return hamburguer.GetDescricao() + ", Alface";
        }

        public override double GetPreco()
        {
            return hamburguer.GetPreco() + 0.75;
        }
    }
}
