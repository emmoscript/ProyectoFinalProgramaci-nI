using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoLibretaDepositos.Models
{
    public interface ITransaction
{
    int TransactionId { get; set; }
    string AccountNumber { get; set; }
    string BeneficiaryName { get; set; }
    string BankName { get; set; }
    string SWIFTCode { get; set; }
    DateTime Date { get; set; }
}

public class Transaction : ITransaction
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int TransactionId { get; set; }

    [Column(TypeName = "nvarchar(12)")]
    [DisplayName("Número de Cuenta")]
    [Required(ErrorMessage = "Este campo es requerido.")]
    [MaxLength(12, ErrorMessage = "Máximo 12 caracteres solamente.")]
    public string AccountNumber { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [DisplayName("Nombre del beneficiario")]
    [Required(ErrorMessage = "Este campo es requerido.")]
    public string BeneficiaryName { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [DisplayName("Nombre del Banco")]
    [Required(ErrorMessage = "Este campo es requerido.")]
    public string BankName { get; set; }

    [Column(TypeName = "nvarchar(11)")]
    [DisplayName("Código SWIFT")]
    [Required(ErrorMessage = "Este campo es requerido.")]
    [MaxLength(11, ErrorMessage = "Máximo 11 caracteres solamente.")]
    public string SWIFTCode { get; set; }

    [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
    [DisplayName("Fecha")]
    public DateTime Date { get; set; }

    [Required(ErrorMessage = "Este campo es requerido.")]
    [DisplayName("Monto")]
    public int Amount { get; set; }
}

}
