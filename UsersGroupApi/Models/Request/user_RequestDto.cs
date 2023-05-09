namespace UsersGroupApi.Models
{
    public class user_RequestDto
    {
        public int id { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public int user_group_id { get; set; }

        public int user_state_id { get; set; }
    }
}
