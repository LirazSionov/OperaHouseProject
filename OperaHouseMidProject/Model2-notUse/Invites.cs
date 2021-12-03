//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Invites")]
//    public class Invites
//    {
//        [Key,Required]
//        public int InviteID { get; set; }
//        [Required]
//        public string FirstName { get; set; }
//        [Required]
//        public string LastName { get; set; }
//        [EmailAddress]
//        public string Email { get; set; }
//        [Required,Phone]
//        public string PhoneNumber { get; set; }
//        public string Gender { get; set; }

//        //Relationship
//        //One to many
//        public Guests Guests { get; set; }
//    }
//}
