using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ServerPlayer.Model
{
    public class User
    {
        [Column("id")] [Key] [Required] public int ID { get; set; }
        [Column("user_name")] [Required] public string Name { get; set; }
        [Column("user_password")] [Required] public string Password { get; set; }
    }
}
