//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("InstanceType")]
//    public class InstanceType
//    {
//        [Key]
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Composer { get; set; }
//        public string Writer { get; set; }
//        public DateTime DateWriting { get; set; }

//        //Relashionship
//        //One to many
//        public ICollection<Concert> Concerts { get; set; } = new List<Concert>();
//    }
//}
