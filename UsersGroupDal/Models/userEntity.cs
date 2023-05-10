using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersGroupDal.Models
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        [ForeignKey(nameof(UserGroupId))]
        public UserGroupEntity UserGroup { get; set; }

        public int UserGroupId { get; set; }

        [Required]
        [ForeignKey(nameof(UserStateId))]
        public UserStateEntity UserState { get; set; }

        public int UserStateId { get; set; }
    }
}
