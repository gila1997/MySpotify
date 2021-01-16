using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Model
{
    public class Song
    {
        [Column("id")] [Key] [Required] public Guid ID { get; set; }
        [Column("song_name")] [Required] public string Name { get; set; }
        [Column("album_id")] [Required] public string AlbumId { get; set; }
        [Column("song_url")] [Required] public string Url { get; set; }
        [Column("length")] [Required] [StringLength(40)] public string Length { get; set; }
    }
}
