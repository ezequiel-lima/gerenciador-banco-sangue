namespace GerenciadorBancoSangueApp.Client.Models
{
    public class EstoqueSangue
    {
        public Guid Id { get; private set; }
        public string TipoSanguineo { get; private set; }
        public string FatorRh { get; private set; }
        public int QuantidadeMl { get; private set; }
    }
}
