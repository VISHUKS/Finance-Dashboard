using Finance_Dashboard_System.Models;

namespace Finance_Dashboard_System.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        string Login(LoginRequest loginRequest);

        Role AddRole(Role role);
        bool AssignRoleToUser(AddUserRole obj);
    }
}
