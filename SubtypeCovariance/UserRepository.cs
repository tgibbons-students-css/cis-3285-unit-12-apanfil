using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtypeCovariance
{
    public class UserRepository : IEntityRepository<User>
    {
        public User GetById(Guid id)
        {
            return new User(id);
        }

        //public override Entity GetByID(Guid id)

    }
}
