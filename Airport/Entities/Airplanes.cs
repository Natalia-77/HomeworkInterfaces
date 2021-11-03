using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Entities
{
    [Table("tblAirplanes")]
    public class Airplanes
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public int NumberPass { get; set; }
        public string Country { get; set; }

        public Flights Flights { get; set; }
    }
}
