namespace UsersGroupApi.Models.Response
{
    public class user_ResponseDto
    {
        public int id { get; set; }

        public string login { get; set; }

        public DateTime created_date { get; set; }

        public int user_group_id { get; set; }

        public int user_state_id { get; set; }
    }
}
