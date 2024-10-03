namespace Lanchonete.Decorators
{
    // Ingrediente Ovo (Concrete Decorator)
    public class Ovo : IngredienteDecorador
    {
        public Ovo(IHamburguer hamburguer) : base(hamburguer) { }

        public override string GetDescricao()
        {
            return hamburguer.GetDescricao() + ", Ovo";
        }

        public override double GetPreco()
        {
            return hamburguer.GetPreco() + 1.75;
        }
    }
}
