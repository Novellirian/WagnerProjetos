namespace Lanchonete.Extras
{
    // Classe para Sobremesa (Item adicional)
    public class Sobremesa : ItemAdicional
    {
        public string GetDescricao()
        {
            return "Sobremesa";
        }

        public double GetPreco()
        {
            return 5.00;
        }
    }
}
