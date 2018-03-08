using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspdotnetLogging.Models
{
    public interface IUser
    {
        IEnumerable<User> Users { get; }
    }
}
