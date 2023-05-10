using UsersGroupBll.Models;

namespace UsersGroupApi.Models.Response
{
    public class UserResponseDto
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public DateTime CreatedDate { get; set; }

        public UserGroup UserGroup { get; set; }

        public UserState UserState { get; set; }
    }
}
