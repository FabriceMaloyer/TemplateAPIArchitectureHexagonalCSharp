using Application.InterfaceQuery;

namespace Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Domain.Model.User> GetAllUser()
        {
            List<Model.User> dbresponse = _context.Users.ToList();
            List<Domain.Model.User> requestresponse = new List<Domain.Model.User>();

            foreach (var user in dbresponse)
            {
                requestresponse.Add(Model.User.ToModel(user));
            }
            return requestresponse;
        }

        public Domain.Model.User GetUserById(Guid id)
        {
            return Model.User.ToModel(_context.Users.FirstOrDefault(a => a.Id == id) ?? new Model.User());
        }
    }
}
