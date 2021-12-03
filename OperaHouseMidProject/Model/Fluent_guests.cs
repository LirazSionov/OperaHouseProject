using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseMidProject.Model
{
    public class Fluent_guests
    {
        [Key]
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string PhoneNumber { get; set; }
        public string ConcertName { get; set; }
        public string HallName { get; set; }
        public string DateConcert { get; set; }
        public string Hour { get; set; }

    }
}
