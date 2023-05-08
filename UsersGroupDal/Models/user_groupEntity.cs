using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersGroupDal.Models
{
    public class user_groupEntity
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int code { get; set; }

        [Column(TypeName = "nvarchar(10000)")]
        public string description { get; set; }
    }
}
