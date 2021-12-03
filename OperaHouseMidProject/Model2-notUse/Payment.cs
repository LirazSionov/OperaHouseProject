//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Payment")]
//    public class Payment
//    {
//        [Key]
//        public int PaymentID { get; set; }
//        [Required, MaxLength(16), MinLength(16)]
//        public string NumerCard { get; set; }
//        [Required,MaxLength(9)]
//        public string IDOwners { get; set; }
//        [MaxLength(3),Required,MinLength(3)]
//        public string Cvv { get; set; }
//        [Required]
//        public DateTime Validity { get; set; }
//        [Required]
//        public int PaymentsNum { get; set; }
//    }
//}
