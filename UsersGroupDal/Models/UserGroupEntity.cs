using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersGroupDal.Models
{
    public class UserGroupEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Code { get; set; }

        [Column(TypeName = "varchar(1000)")]
        public string? Description { get; set; }
    }
}
