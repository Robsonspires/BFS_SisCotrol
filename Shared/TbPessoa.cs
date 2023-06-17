using System.ComponentModel.DataAnnotations;

namespace BFS_SisControl.Shared
{
    public class TbPessoa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome completo.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Entre com a data de nascimetno.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Fone { get; set; } = string.Empty;

        public string CEP { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;

        [Required]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        [Required]
        public DateTime DataAtualizacao { get; set; } = DateTime.Now;
    }
}