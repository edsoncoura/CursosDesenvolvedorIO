using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAspNet.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [StringLength(60,MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 a 60 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Data é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$", ErrorMessage = "Genero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres"), Required(ErrorMessage = "O campo Genero é Requerido")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Preencha o campo Valor")]
        [Range(1,1000, ErrorMessage = "Valor de 1 a 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Preencha o campo Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente Números")]
        [Display(Name = "Avaliação")]
        public int Avaliacao { get; set; }
    }
}
