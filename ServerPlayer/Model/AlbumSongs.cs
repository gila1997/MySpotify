using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Model
{
    public class AlbumSongs
    {
        [Column("id")] [Key] [Required] public int ID { get; set; }
        [Column("album_id")] [Required] public int AlbumId { get; set; }
        [Column("song_id")] [Required] public int SongId { get; set; }
    }
}
