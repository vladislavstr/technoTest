using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersGroupDal.Models
{
    public class user_stateEntity
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "char(100)")]
        public string code { get; set; }

        [Column(TypeName = "char(1000)")]
        public string? description { get; set; }
    }
}
