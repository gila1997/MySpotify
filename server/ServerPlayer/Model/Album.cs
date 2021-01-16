using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Model
{
    public class Album
    {
        [Column("id")] [Key] [Required] public int ID { get; set; }
        [Column("artist_name")] [Required] [StringLength(50)] public string ArtistName { get; set; }
        [Column("album_image")] [Required] public string Image { get; set; }
        [Column("title")] [Required] public string Title { get; set; }
        [Column("album_type")] [Required] public eType Type { get; set; }
        [Column("year_of_publication")] [Required] public DateTime YearOfPublication { get; set; }

    }
}
