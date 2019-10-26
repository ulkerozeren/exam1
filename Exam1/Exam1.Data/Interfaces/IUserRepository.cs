using Exam1.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam1.Data.Interfaces
{
    public interface IUserRepository:IRepository<User>
    {
        bool FindByUser(string username);
    }
}
