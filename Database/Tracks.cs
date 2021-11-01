using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    [Table("tblTracks")]
    public class Tracks
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }
        
        public int Duration { get; set; }

        [ForeignKey("Albums")]
        public int AlbumId { get; set; }

        public virtual Albums Albums { get; set; }

        [ForeignKey("Playlists")]
        public int PlaylistId { get; set; }

        public virtual Playlists Playlists{ get; set; }



    }
}
