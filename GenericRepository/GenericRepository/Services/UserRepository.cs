namespace GenericRepository.Services
{
    public class UserRepository : Repository<Models.User>, Interfaces.IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
