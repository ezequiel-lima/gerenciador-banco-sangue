namespace GerenciadorBancoSangueApp.Client.InputModels
{
    public class Doacao
    {
        public Guid Id { get; private set; }      
        public DateTime DataDoacao { get; private set; }
        public int QuantidadeMl { get; private set; }
        public Doador Doador { get; private set; }
    }
}
