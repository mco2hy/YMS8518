namespace Competition.Services
{
    public class StudentRepository : Repository<Models.Student>, Interfaces.IStudentRepository
    {
        private readonly DataContext _dataContext;
        public StudentRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
