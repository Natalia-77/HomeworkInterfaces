using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport.Entities
{
    [Table("tblAccounts")]
    public class Accounts
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
       // public int ClientsId { get; set; }
        public Clients  Clients{ get; set; }
    }
}
