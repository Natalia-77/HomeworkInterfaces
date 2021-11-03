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
        public string Login { get; set; }
        public string Password { get; set; }
        public Clients  Clients{ get; set; }
    }
}
