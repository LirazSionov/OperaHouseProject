//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Player")]
//    public class Player : Artists
//    {
//        [ForeignKey("Artists")]
//        public int ArtistId { get; set; }
//        [Required]
//        [ForeignKey("MusicalInstrument")]
//        public int MusicalInstrumentId { get; set; }

//        //Relationship
//        //One to many
//        public Artists Artists { get; set; }
//        public MusicalInstrument MusicalInstrument { get; set; }
//    }
//}
