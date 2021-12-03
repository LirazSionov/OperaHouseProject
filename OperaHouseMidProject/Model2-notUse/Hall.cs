//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Hall")]
//    public class Hall
//    {
//        [Key, Required]
//        public int Id { get; set; }
//        [Required]
//        public string HallName { get; set; }
//        [MaxLength(3)]
//        public int SeatsNum { get; set; }


//        //Relashionship
//        //One to one
//        public Concert Concert { get; set; }
//        //One to many
//        public ICollection<Guests> Guests { get; set; } = new List<Guests>();

//    }
//}
