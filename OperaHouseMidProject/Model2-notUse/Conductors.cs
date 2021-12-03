//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Conductors")]
//    public class Conductors : Artists
//    {
//        [Required]
//        [ForeignKey("Artists")]
//        public int ArtistId { get; set; }
//        public string SpecializationType { get; set; }


//        //RelationShip
//        //One to many
//        public Artists Artists { get; set; }
//    }
//}
