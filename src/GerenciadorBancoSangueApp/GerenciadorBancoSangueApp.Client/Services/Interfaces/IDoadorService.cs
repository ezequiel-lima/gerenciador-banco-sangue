using GerenciadorBancoSangueApp.Client.InputModels;

namespace GerenciadorBancoSangueApp.Services.Interfaces
{
    public interface IDoadorService
    {
        Task<Doador?> ObterDoadorPorIdAsync(Guid id);
        Task<List<Doador>> ObterTodosDoadoresAsync();
    }
}
