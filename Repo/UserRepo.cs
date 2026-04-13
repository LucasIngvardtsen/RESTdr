using RESTdr.Models;

namespace RESTdr.Repo
{
    public class UserRepo
    {
        // private int nextId = 1; Redundant as using database
        private readonly RecordsDbContext _context;

        public UserRepo(RecordsDbContext context)
        {
            _context = context;
        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public void UpdateUser(User user)
        {

            var existingUser = _context.Users.Find(user.Id);
            if (existingUser != null)
            {
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                _context.SaveChanges();
            }
        }

        public void DeleteUser(User user)
        {
            var existingUser = _context.Users.Find(user.Id);
            if (existingUser != null)
            {
                _context.Users.Remove(existingUser);
                _context.SaveChanges();
            }
        }

        public User GetAllUsers()
        {
            return _context.Users.FirstOrDefault();
        }

        public User GetUserById(int id)
        {
            return _context.Users.Find(id);
        }


    }
}
