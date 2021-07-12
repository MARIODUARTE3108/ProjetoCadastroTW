using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O nome é requerido.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O valor é requerido.")]
        public decimal Value { get; set; }

        [Display(Name = "Ativo")]
        public bool Active { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O código do cliente é requerido.")]
        public decimal IdClient { get; set; }
    }
}
