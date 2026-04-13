using RESTdr.Models;

namespace RESTdr.Repo
{
    public interface IUserRepo
    {
        User AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        User GetAllUsers();
        User GetUserById(int id);
    }
}
