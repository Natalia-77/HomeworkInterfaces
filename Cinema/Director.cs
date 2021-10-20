using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Director:ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Director(string firstname,string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }

        public override string ToString()
        {
            return $"Director of movie:{FirstName}{LastName}";
        }

        public object Clone()
        {

            return (Director)MemberwiseClone();
        }
    }
}
