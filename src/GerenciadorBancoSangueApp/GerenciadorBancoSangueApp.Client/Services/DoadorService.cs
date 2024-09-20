using GerenciadorBancoSangueApp.Client.InputModels;
using GerenciadorBancoSangueApp.Services.Interfaces;

namespace GerenciadorBancoSangueApp.Services
{
    public class DoadorService : IDoadorService
    {
        private List<Doador> doadores = new List<Doador>
        {
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "João Antonio", Email = "joao@teste.com", DataNascimento = DateTime.Now.AddYears(-25), Genero = "Masculino", Peso = 79.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Maria Silva", Email = "maria@teste.com", DataNascimento = DateTime.Now.AddYears(-30), Genero = "Feminino", Peso = 65.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Carlos Souza", Email = "carlos@teste.com", DataNascimento = DateTime.Now.AddYears(-45), Genero = "Masculino", Peso = 85.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O-" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Ana Oliveira", Email = "ana@teste.com", DataNascimento = DateTime.Now.AddYears(-32), Genero = "Feminino", Peso = 58.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A-" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Pedro Henrique", Email = "pedro@teste.com", DataNascimento = DateTime.Now.AddYears(-28), Genero = "Masculino", Peso = 90.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B-" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Fernanda Lima", Email = "fernanda@teste.com", DataNascimento = DateTime.Now.AddYears(-35), Genero = "Feminino", Peso = 68.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Gabriel Martins", Email = "gabriel@teste.com", DataNascimento = DateTime.Now.AddYears(-29), Genero = "Masculino", Peso = 78.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Juliana Costa", Email = "juliana@teste.com", DataNascimento = DateTime.Now.AddYears(-41), Genero = "Feminino", Peso = 72.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Rafael Dias", Email = "rafael@teste.com", DataNascimento = DateTime.Now.AddYears(-37), Genero = "Masculino", Peso = 80.0, FatorRh = "FatorRH de teste", TipoSanguineo = "AB+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Beatriz Freitas", Email = "beatriz@teste.com", DataNascimento = DateTime.Now.AddYears(-34), Genero = "Feminino", Peso = 63.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Lucas Alves", Email = "lucas@teste.com", DataNascimento = DateTime.Now.AddYears(-38), Genero = "Masculino", Peso = 92.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A-" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Patricia Mendes", Email = "patricia@teste.com", DataNascimento = DateTime.Now.AddYears(-33), Genero = "Feminino", Peso = 70.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Marcos Teixeira", Email = "marcos@teste.com", DataNascimento = DateTime.Now.AddYears(-40), Genero = "Masculino", Peso = 88.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Larissa Rodrigues", Email = "larissa@teste.com", DataNascimento = DateTime.Now.AddYears(-27), Genero = "Feminino", Peso = 67.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Felipe Souza", Email = "felipe@teste.com", DataNascimento = DateTime.Now.AddYears(-39), Genero = "Masculino", Peso = 81.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B-" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Renata Santos", Email = "renata@teste.com", DataNascimento = DateTime.Now.AddYears(-36), Genero = "Feminino", Peso = 62.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O-" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Thiago Ferreira", Email = "thiago@teste.com", DataNascimento = DateTime.Now.AddYears(-31), Genero = "Masculino", Peso = 75.0, FatorRh = "FatorRH de teste", TipoSanguineo = "AB+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Isabela Nunes", Email = "isabela@teste.com", DataNascimento = DateTime.Now.AddYears(-29), Genero = "Feminino", Peso = 60.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Bruno Lima", Email = "bruno@teste.com", DataNascimento = DateTime.Now.AddYears(-28), Genero = "Masculino", Peso = 84.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Camila Alves", Email = "camila@teste.com", DataNascimento = DateTime.Now.AddYears(-33), Genero = "Feminino", Peso = 68.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Vitor Oliveira", Email = "vitor@teste.com", DataNascimento = DateTime.Now.AddYears(-35), Genero = "Masculino", Peso = 87.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Paula Castro", Email = "paula@teste.com", DataNascimento = DateTime.Now.AddYears(-30), Genero = "Feminino", Peso = 64.0, FatorRh = "FatorRH de teste", TipoSanguineo = "B+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Gustavo Torres", Email = "gustavo@teste.com", DataNascimento = DateTime.Now.AddYears(-38), Genero = "Masculino", Peso = 79.0, FatorRh = "FatorRH de teste", TipoSanguineo = "O+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Sandra Pereira", Email = "sandra@teste.com", DataNascimento = DateTime.Now.AddYears(-42), Genero = "Feminino", Peso = 70.0, FatorRh = "FatorRH de teste", TipoSanguineo = "AB+" },
            new Doador { Id = Guid.NewGuid(), NomeCompleto = "Leonardo Azevedo", Email = "leonardo@teste.com", DataNascimento = DateTime.Now.AddYears(-37), Genero = "Masculino", Peso = 83.0, FatorRh = "FatorRH de teste", TipoSanguineo = "A-" }
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
