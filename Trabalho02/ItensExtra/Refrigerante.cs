namespace Lanchonete.Extras
{
    // Classe para Refrigerante (Item adicional)
    public class Refrigerante : ItemAdicional
    {
        public string GetDescricao()
        {
            return "Refrigerante";
        }

        public double GetPreco()
        {
            return 2.50;
        }
    }
}
