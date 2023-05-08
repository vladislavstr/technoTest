namespace UsersGroupApi.Models
{
    public class userDto
    {
        public int id { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public DateTime created_date { get; set; }

        public int user_group_id { get; set; }

        public int user_state_id { get; set; }
    }
}
