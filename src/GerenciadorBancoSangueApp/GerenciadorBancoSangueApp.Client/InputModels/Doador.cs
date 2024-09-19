using System.ComponentModel.DataAnnotations;

namespace GerenciadorBancoSangueApp.Client.InputModels
{
    public class Doador
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [EmailAddress (ErrorMessage = "{0} inválido")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O {0} é obrigatório.")]
        [Range(50, 400, ErrorMessage = "O {0} deve ser entre {1} e {2} quilos.")]
        public double Peso { get; set; }

        [Display(Name = "Tipo Sanguíneo")]
        public string TipoSanguineo { get; set; }

        [Display(Name = "Fator Rh")]
        public string FatorRh { get; set; }
    }
}
