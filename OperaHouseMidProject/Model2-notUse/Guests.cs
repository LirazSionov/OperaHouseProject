//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
//using System.Text;
//using System.Threading.Tasks;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Guests")]
//    public class Guests
//    {
//        [Key]
//        public int Id { get; set; }
//        [ForeignKey("Users"), Required]
//        public int UserId { get; set; }
//        [Required]
//        public string ChairNum { get; set; }
//        [ForeignKey("Hall"), Required]
//        public int IDHall { get; set; }
//        [ForeignKey("Concert"), Required]
//        public int IDConcert { get; set; }
//        [Required]
//        public DateTime Date { get; set; }
//        [Required]
//        public DateTime Hour { get; set; }


//        //Relationship
//        //One to one
//        public Users Users { get; set; }
//        //One to many
//        public Hall Halls { get; set; }
//        public Concert Concerts { get; set; }
//        public ICollection<Invites> Invites { get; set; } = new List<Invites>();

//    }
//}
