namespace Lanchonete.Decorators
{
    // Hambúrguer simples (Concrete Component)
    public class HamburguerSimples : IHamburguer
    {
        public string GetDescricao()
        {
            return "Hambúrguer Simples";
        }

        public double GetPreco()
        {
            return 5.00;
        }
    }
}
