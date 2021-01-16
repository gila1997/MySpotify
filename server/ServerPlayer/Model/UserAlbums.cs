using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Model
{
    public class UserAlbums
    {
        [Column("id")] [Key] [Required] public int ID { get; set; }
        [Column("user_id")] [Required] public int UserId { get; set; }
        [Column("album_id")] [Required] public int AlbumId { get; set; }

    }
}
