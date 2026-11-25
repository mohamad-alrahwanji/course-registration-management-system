using CourseRegistration.Entities;
using CourseRegistration.DAL.DataProviders;

namespace CourseRegistration.DAL.Repositories
{
    public class UserRepository : RepositoryBase<User>
    {
        public List<User> GetAll() => UserDataProvider.GetAll();

        public bool Add(User user) => UserDataProvider.Add(user);

        public bool UsernameExists(string username) => UserDataProvider.UsernameExists(username);

        public bool Edit(User user, bool passwordChanged) => UserDataProvider.Edit(user, passwordChanged);

        public bool UsernameExists(string username, int excludedUserId) => UserDataProvider.UsernameExists(username, excludedUserId);

        public bool Delete(int userId) => UserDataProvider.Delete(userId);

        public List<User> Search(string searchText) => UserDataProvider.Search(searchText);

        public User? GetByUsername(string username) => UserDataProvider.GetByUsername(username);
    }
}