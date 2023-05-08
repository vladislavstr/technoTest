using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersGroupDal.Models
{
    public class userEntity
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string login { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public DateTime created_date { get; set; }

        [Required]
        [ForeignKey(nameof(user_group_id))]
        public int user_group { get; set; }

        public int user_group_id { get; set; }

        [Required]
        [ForeignKey(nameof(user_state_id))]
        public int user_state { get; set; }

        public int user_state_id { get; set; }
    }
}
