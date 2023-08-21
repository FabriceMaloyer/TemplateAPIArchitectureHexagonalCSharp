using Application.InterfaceQuery;
using User = Infrastructure.Model.User;
using UserModel = Domain.Model.User;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public bool CreateUser(UserModel user)
        {
            user.Id = Guid.NewGuid();
            _context.Add(User.ToRepos(user));
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteUser(Guid id)
        {
            _context.Users.Remove(_context.Users.First(a => a.Id == id));

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<UserModel> GetAllUser()
        {
            List<User> dbresponse = _context.Users.ToList();
            List<UserModel> requestresponse = new List<UserModel>();

            foreach (var user in dbresponse)
            {
                requestresponse.Add(User.ToModel(user));
            }
            return requestresponse;
        }

        public UserModel GetUserById(Guid id)
        {
            return Model.User.ToModel(_context.Users.FirstOrDefault(a => a.Id == id) ?? new Model.User());
        }

        public bool UpdateUser(UserModel user)
        {
            var newUser = _context.Users.First(a => a.Id == user.Id);
            newUser.Name = user.Name;
            newUser.Email = user.Email;
            newUser.Password = user.Password;

            _context.Update(newUser);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
