namespace UsersGroupApi.Models.Response
{
    public class UserResponseDto
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UserGroupId { get; set; }

        public int UserStateId { get; set; }
    }
}
