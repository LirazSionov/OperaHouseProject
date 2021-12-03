//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Users")]
//    public class Users
//    {
//        [Key]
//        public int Id { get; set; }
//        [MaxLength(9)]
//        public string IDDocument { get; set; }
//        [Required,MaxLength(20),MinLength(5)]
//        public string NameUser { get; set; }
//        [Required]
//        public string TypeUser { get; set; }
//        //Relationship
//        public List< Artists> Artists { get; set; }
//        //One to one
//        public Guests Guests { get; set; }
//    }
//}