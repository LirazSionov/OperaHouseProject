//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Artists")]
//    public class Artists
//    {
//        [Key]
//        public int Id { get; set; }
//        [ForeignKey("Users")]
//        public int IDUsers { get; set; }
//        [MaxLength(20)]
//        public string FirstName { get; set; }
//        [MaxLength(20)]
//        public string LastName { get; set; }
//        [NotMapped]
//        public string FullName
//        { get { return FirstName + " " + LastName; } }
//        public DateTime BirthDate { get; set; }
//        [ForeignKey("Cities")]
//        public int CityId { get; set; }
//        [MaxLength(30)]
//        public string Address { get; set; }
//        [EmailAddress]
//        public string Email { get; set; }
//        [Phone]
//        public string Phonenumber { get; set; }
//        public string Gender { get; set; }

//        //Relationship
//        //One to many
//        public Cities Cities { get; set; }
//        //One to one
//        public Users Users { get; set; }
//    }
//}
