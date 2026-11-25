using CourseRegistration.Entities;
using CourseRegistration.BL.Managers;

namespace CourseRegistration.BL.Services
{
    public static class UserService
    {
        public static List<User> GetAll() => new UserManager().GetAll();

        public static bool Add(User user, string password) => new UserManager().Add(user, password);

        public static bool UsernameExists(string username) => new UserManager().UsernameExists(username);

        public static bool Edit(User user, string newPassword) => new UserManager().Edit(user, newPassword);

        public static bool Delete(User user) => new UserManager().Delete(user);

        public static List<User> Search(string searchText) => new UserManager().Search(searchText);

        public static User Login(string username, string password) => new UserManager().Login(username, password);
    }
}
