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
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DepartDate { get; set; } = DateTime.Now;
        public DateTime ArrivDate { get; set; } = DateTime.Now;
        public string DepartCity { get; set; }
        public string ArrivCity { get; set; }

        //Один рейс обслуговує багато пасажирів та на одному рейсі можуть літати багато літаків.
        public ICollection<Clients> Clients { get; set; }
        public ICollection <Airplanes> Airplanes { get; set; }

    }
}
