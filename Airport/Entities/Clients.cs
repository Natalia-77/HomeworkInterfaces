using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Entities
{
    [Table("tblClients")]
    public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }

        public int AccountsId { get; set; }
        public Accounts Accounts { get; set; }
        public int FlightsId { get; set; } 
        public Flights Flights { get; set; }
    }
}
