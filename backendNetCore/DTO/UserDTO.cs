namespace backendNetCore.Api.DTO
{
    public class UserDTO
    {
    }
    public class CreateUserDTO
    {
        public string EmployeeCode { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
