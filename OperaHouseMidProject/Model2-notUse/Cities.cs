//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Cities")]
//    public class Cities
//    {
//        [Key]
//        public int Id { get; set; }
//        [Required]
//        public string NameCity { get; set; }

//        //Relationship
//        //One to many
//        public ICollection<Artists> Artists { get; set; } = new List<Artists>();
//    }
//}
