using Exam1.Data.Context;
using Exam1.Data.Interfaces;
using Exam1.Data.Models;
using Exam1.Service.Repositories;
using System.Linq;

namespace Exam1.Service.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DataContext _dataContext;
        public UserRepository(DataContext dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }

        public bool FindByUser(string username)
        {
            bool result = false;
            var user = _dataContext.Users.Where(x=>x.Username.Equals(username));

            if (user!=null)
            {
                result = true; 
            }

            return result;
        }
    }
}
