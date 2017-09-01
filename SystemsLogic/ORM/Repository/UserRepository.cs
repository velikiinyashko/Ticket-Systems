using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SystemsLogic.ORM
{

    public class UserRepository : IRepository<User>
    {
        private Context Db;

        public UserRepository(string ConnectionString)
        {
            this.Db = new Context(ConnectionString);
        }

        public IEnumerable<User> GetDataList()
        {
            return Db.Users;
        }

        public User GetData(int Id)
        {
            return Db.Users.Find(Id);
        }

        public void Create(User user)
        {
            Db.Users.Add(user);
        }

        public void Update(User user)
        {
            Db.Entry(user).State = EntityState.Modified;
        }

        public void Delete(int Id)
        {
            User user = Db.Users.Find(Id);
            if(user != null)
            {
                Db.Users.Remove(user);
            }
        } 

        public void Save()
        {
            Db.SaveChanges();
        }

        public void Dispose()
        {

        }
    }
}
