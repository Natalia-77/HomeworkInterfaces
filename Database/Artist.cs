using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    [Table("tblArtist")]
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(100)]
        public string Surname { get; set; }

        [Required, StringLength(20)]
        public string Country { get; set; }

        public virtual ICollection<Albums> Albums { get; set; }
    }
}
