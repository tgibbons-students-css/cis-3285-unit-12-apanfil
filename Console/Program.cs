
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubtypeCovariance;

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {

            IEntityRepository<Entity> entityRepository = new EntityRepository();
            Entity myEntity = entityRepository.GetById(Guid.NewGuid());

            myEntity.Name = "Tom";
            Console.WriteLine("New entity ID: " + myEntity.ID.ToString());
            Console.WriteLine("New entity Name: " + myEntity.Name);

//user repository
            IEntityRepository<User> userRepository = new UserRepository();
            User myUser = userRepository.GetById(Guid.NewGuid());

            myUser.Name = "Tom";
            myUser.EmailAddress = "apanfil@css.edu";
            Console.WriteLine("New entity ID: " + myEntity.ID.ToString());
            Console.WriteLine("New entity Name: " + myEntity.Name);
            Console.WriteLine("New entity email: " + myUser.EmailAddress;


        }
    }
}
