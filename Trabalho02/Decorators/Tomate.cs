namespace Lanchonete.Decorators
{
    // Ingrediente Tomate (Concrete Decorator)
    public class Tomate : IngredienteDecorador
    {
        public Tomate(IHamburguer hamburguer) : base(hamburguer) { }

        public override string GetDescricao()
        {
            return hamburguer.GetDescricao() + ", Tomate";
        }

        public override double GetPreco()
        {
            return hamburguer.GetPreco() + 0.50;
        }
    }
}
