using CourseRegistration.Entities;
using CourseRegistration.BL.Managers;

namespace CourseRegistration.BL.Services
{
    public static class UserService
    {
        private readonly static UserManager _manager = new UserManager();

        public static List<User> GetAll() => _manager.GetAll();

        public static bool Add(User user, string password) => _manager.Add(user, password);

        public static bool UsernameExists(string username) => _manager.UsernameExists(username);

        public static bool Edit(User user, string newPassword) => _manager.Edit(user, newPassword);

        public static bool Delete(User user) => _manager.Delete(user);

        public static List<User> Search(string searchText) => _manager.Search(searchText);

        public static User Login(string username, string password) => _manager.Login(username, password);
    }
}
