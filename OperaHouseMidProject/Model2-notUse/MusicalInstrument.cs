//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("MusicalInstrument")]
//    public class MusicalInstrument
//    {
//        [Key]
//        public int Id { get; set; }
//        [Required]
//        public string Name { get; set; }
//        [MaxLength(15)]
//        public string Company { get; set; }

//        //Relationship
//        //One to many
//        public ICollection<MusicalInstrument> MusicalInstruments { get; set; } = new List<MusicalInstrument>();
//    }
//}
