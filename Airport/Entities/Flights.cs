using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Entities
{
    [Table("tblFlights")]
    public class Flights
    {
        public int Number { get; set; }
        public DateTime DepartDate { get; set; }
        public DateTime ArrivDate { get; set; }
        public string DepartCity { get; set; }
        public string ArrivCity { get; set; }

        public ICollection<Clients> Clients { get; set; }
        public Airplanes Airplanes { get; set; }

    }
}
