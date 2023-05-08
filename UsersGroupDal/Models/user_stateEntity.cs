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
        public int code { get; set; }

        [Column(TypeName = "char(1000)")]
        public string description { get; set; }
    }
}
