namespace GerenciadorBancoSangueApp.Client.InputModels
{
    public class Endereco
    {
        public Guid Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
        public Doador Doador { get; private set; }
    }
}
