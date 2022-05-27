using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        [Required]

        [DisplayName("Bank Name")]
        public string BankName { get; set; }
        [Required]
        [DisplayName("Account Number")]
        [MaxLength(12)]
        public string AccountNumber { get; set; }
        [Required]
        [DisplayName("Beneficiary Name")]
        public string BeneficiaryName { get; set; }
        [Required]
        [MaxLength(3)]
        [DisplayName("CVV Code")]
        public string CVV { get; set; }
        [Required]
        [DisplayName("Amount")]
        public int Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yyyy}")]
        public DateTime Date { get; set; }
    }
}
