//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;

//namespace OperaHouseMidProject.Model
//{
//    [Table("Concert")]
//    public class Concert
//    {
//        [Key]
//        public int Id { get; set; }
//        [ForeignKey("InstanceType")]// remove fk put inner join instead
//        public int IDInstanceType { get; set; }
//        public string InstanceName  { get; set; }
//        public string ConductoreName { get; set; }
//        public double Duration { get; set; }
//        public DateTime Data { get; set; }
//        public string Time { get; set; }
//        [ForeignKey("Hall")]
//        public int IDHall { get; set; }
//        //public string Hall { get; set; }
//        public double Cost { get; set; }

//        //Relashionship
//        //One to many
//        public InstanceType InstanceType { get; set; }
//        public ICollection<Guests> Guests { get; set; } = new List<Guests>();

//        ////One to one
//        public Hall Hall { get; set; }



//    }
//}
