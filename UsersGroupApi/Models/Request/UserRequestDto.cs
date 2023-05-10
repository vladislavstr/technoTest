namespace UsersGroupApi.Models.Request
{
    public class UserRequestDto
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public int UserGroupId { get; set; }

    }
}
