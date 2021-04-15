using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaProva.Models
{ 
    
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Titulo Obrigatorio")]
        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatorio")]
        [Display(Name = "Autor: ")]
        public string autor { get; set; }

        [Required(ErrorMessage = "Preço Obrigatorio")]
        [Display(Name = "Preço: ")]
        public int preco { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatorio")]
        [Display(Name = "Descrição: ")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Quantidade De Pagina Obrigatorio")]
        [Display(Name = "Quantidade De Pagina: ")]
        public int quantPag { get; set; }

        [Required(ErrorMessage = "Editora Obrigatorio")]
        [Display(Name = "Editora: ")]
        public string editora { get; set; }


        [Required(ErrorMessage = "Data Obrigatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Lançamento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime datalancamento { get; set; }

    }
}
