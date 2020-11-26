using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteCapgeminiWebApi.Models
{
    public class Excel
    {
        public Excel(){}

        public Excel(int id, DateTime dtEntrega, string nomeProduto, int quantidade, decimal valorUnitario)
        {
            this.Id = id;
            this.DtEntrega = dtEntrega;
            this.NomeProduto = nomeProduto;
            this.Quantidade = quantidade;
            this.ValorUnitario = valorUnitario;
        }

        [Key]
        public int Id { get; set; }

        [Display(Name = "Data de Entrega")]
        [Required(ErrorMessage = "Data de entrega não pode ser menor que a data atual")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DtEntrega { get; set; }

        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(50,ErrorMessage = "Nome do produto não pode ter mais que 50 caracteres")]
        public string NomeProduto { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "int")]
        public int Quantidade { get; set; }

        [Display(Name = "Valor Unitário")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorUnitario { get; set; }
    }
}