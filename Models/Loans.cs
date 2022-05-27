using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bank.Models
{
    public class Loans
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        [DisplayName("Loan#")]
        public int LoansId { get; set; }
        [Required]
        [DisplayName("Loan Name")]
        public string LoansName { get; set; }
        [Required]
        [DisplayName("Amount")]
        public int Amount { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yyyy}")]
        public DateTime? LoansDate { get; set; }

        


    }
}
