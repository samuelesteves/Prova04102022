using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Prova04102022SistemasWeb.Models
{
    public class Cliente
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereco { get; set; }
    }
}
