using aspdotnetLogging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspdotnetLogging.Data
{
    public class UserRepository : IUser
    {
        public IEnumerable<User> Users => new List<User>()
        {
           new User(){Name = "Smith", Id=1},
           new User(){Name = "John", Id=2},

        };



    }
}
