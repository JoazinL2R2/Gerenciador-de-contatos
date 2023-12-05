using System.ComponentModel.DataAnnotations;

namespace Contatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "*Digite o nome do contato*")]

        public string nome { get; set; }
        [Required(ErrorMessage = "*Digite o E-mail do contato*")]
        [EmailAddress(ErrorMessage = "*O e-mail informado é invalido*")]
        public string email { get; set;}
        [Required(ErrorMessage = "*Digite o celular do contato*")]
        [Phone(ErrorMessage = "*O celular informado não é valido*")]
        public string celular { get; set;}
    }
}
