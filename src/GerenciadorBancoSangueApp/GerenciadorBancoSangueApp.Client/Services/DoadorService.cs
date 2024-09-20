using GerenciadorBancoSangueApp.Client.InputModels;
using GerenciadorBancoSangueApp.Services.Interfaces;

namespace GerenciadorBancoSangueApp.Services
{
    public class DoadorService : IDoadorService
    {
        private List<Doador> doadores = new List<Doador>
        {
            new Doador { Id = Guid.Parse("2b95ef65-c951-47da-82a2-ff1a1a4d6d3a"), NomeCompleto = "João Antonio", Email = "joao@teste.com", DataNascimento = DateTime.Now.AddYears(-25), Genero = "Masculino", Peso = 79.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.Parse("37a51c7e-6c99-46d3-b52a-42b6a256aebb"), NomeCompleto = "Maria Silva", Email = "maria@teste.com", DataNascimento = DateTime.Now.AddYears(-30), Genero = "Feminino", Peso = 65.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" },
            new Doador { Id = Guid.Parse("5be6b2b3-4114-4d3f-95bb-1beed7bede2f"), NomeCompleto = "Carlos Souza", Email = "carlos@teste.com", DataNascimento = DateTime.Now.AddYears(-45), Genero = "Masculino", Peso = 85.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O-" },
            new Doador { Id = Guid.Parse("e2f9cbf6-9c88-45f3-8c1f-27502f94af87"), NomeCompleto = "Ana Oliveira", Email = "ana@teste.com", DataNascimento = DateTime.Now.AddYears(-32), Genero = "Feminino", Peso = 58.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A-" },
            new Doador { Id = Guid.Parse("8ae41319-4741-4eac-88bb-f8a3fdc88256"), NomeCompleto = "Pedro Henrique", Email = "pedro@teste.com", DataNascimento = DateTime.Now.AddYears(-28), Genero = "Masculino", Peso = 90.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B-" },
            new Doador { Id = Guid.Parse("6041ba24-86ab-4d51-843f-60534422c842"), NomeCompleto = "Fernanda Lima", Email = "fernanda@teste.com", DataNascimento = DateTime.Now.AddYears(-35), Genero = "Feminino", Peso = 68.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O+" },
            new Doador { Id = Guid.Parse("ac7cf4f1-5c5f-4372-8a49-b3a24af5e2a5"), NomeCompleto = "Gabriel Martins", Email = "gabriel@teste.com", DataNascimento = DateTime.Now.AddYears(-29), Genero = "Masculino", Peso = 78.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.Parse("f230d979-46cb-4a29-b6e1-23687e843b08"), NomeCompleto = "Juliana Costa", Email = "juliana@teste.com", DataNascimento = DateTime.Now.AddYears(-41), Genero = "Feminino", Peso = 72.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" },
            new Doador { Id = Guid.Parse("857fd607-e2b5-4cb7-94ad-dae9b65040ef"), NomeCompleto = "Rafael Dias", Email = "rafael@teste.com", DataNascimento = DateTime.Now.AddYears(-37), Genero = "Masculino", Peso = 80.0, FatorRh = "FatorRH de teste", TipoSanguineo = "AB+" },
            new Doador { Id = Guid.Parse("d5c2dd82-31e0-4b6c-bf27-7195c31cf6c1"), NomeCompleto = "Beatriz Freitas", Email = "beatriz@teste.com", DataNascimento = DateTime.Now.AddYears(-34), Genero = "Feminino", Peso = 63.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O+" },
            new Doador { Id = Guid.Parse("09b80fd1-0c22-490e-82f5-27e7eae71d47"), NomeCompleto = "Lucas Alves", Email = "lucas@teste.com", DataNascimento = DateTime.Now.AddYears(-38), Genero = "Masculino", Peso = 92.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A-" },
            new Doador { Id = Guid.Parse("a30b9fd6-83b0-41eb-98d4-935e2be9f1c1"), NomeCompleto = "Patricia Mendes", Email = "patricia@teste.com", DataNascimento = DateTime.Now.AddYears(-33), Genero = "Feminino", Peso = 70.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" },
            new Doador { Id = Guid.Parse("b32cfa5e-1a61-43e1-b6d1-9b67fcbbfd42"), NomeCompleto = "Marcos Teixeira", Email = "marcos@teste.com", DataNascimento = DateTime.Now.AddYears(-40), Genero = "Masculino", Peso = 88.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O+" },
            new Doador { Id = Guid.Parse("df2f88d9-5d85-4dcb-bb9b-524b964d7f7c"), NomeCompleto = "Larissa Rodrigues", Email = "larissa@teste.com", DataNascimento = DateTime.Now.AddYears(-27), Genero = "Feminino", Peso = 67.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.Parse("dc2f3c84-519f-48c9-a3c4-5053d1d95ff6"), NomeCompleto = "Felipe Souza", Email = "felipe@teste.com", DataNascimento = DateTime.Now.AddYears(-39), Genero = "Masculino", Peso = 81.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B-" },
            new Doador { Id = Guid.Parse("b9ac5793-eae2-468b-81b7-41085c22ef01"), NomeCompleto = "Renata Santos", Email = "renata@teste.com", DataNascimento = DateTime.Now.AddYears(-36), Genero = "Feminino", Peso = 62.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O-" },
            new Doador { Id = Guid.Parse("8d66220e-d0e4-4d6a-b85e-1f5fe9e4bb36"), NomeCompleto = "Thiago Ferreira", Email = "thiago@teste.com", DataNascimento = DateTime.Now.AddYears(-31), Genero = "Masculino", Peso = 75.0, FatorRh = "FatorRH de teste", TipoSanguineo = "AB+" },
            new Doador { Id = Guid.Parse("f7167a68-b774-44db-9e0c-79f19a2e179b"), NomeCompleto = "Isabela Nunes", Email = "isabela@teste.com", DataNascimento = DateTime.Now.AddYears(-29), Genero = "Feminino", Peso = 60.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.Parse("bb4f5f11-d3fa-43b0-b46e-c55420f99e29"), NomeCompleto = "Bruno Lima", Email = "bruno@teste.com", DataNascimento = DateTime.Now.AddYears(-28), Genero = "Masculino", Peso = 84.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" }
        };

        public async Task<Doador?> ObterDoadorPorIdAsync(Guid id)
        {
            // Simulando uma chamada assíncrona
            return await Task.FromResult(doadores.FirstOrDefault(x => x.Id == id));
        }

        public async Task<List<Doador>> ObterTodosDoadoresAsync()
        {
            return await Task.FromResult(doadores);
        }
    }
}
