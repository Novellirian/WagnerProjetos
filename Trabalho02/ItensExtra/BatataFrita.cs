namespace Lanchonete.Extras
{
    // Classe para Batata Frita (Item adicional)
    public class BatataFrita : ItemAdicional
    {
        public string GetDescricao()
        {
            return "Batata Frita";
        }

        public double GetPreco()
        {
            return 3.50;
        }
    }
}
