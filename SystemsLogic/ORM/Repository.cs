using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SystemsLogic.ORM
{

    class Repository
    {
        private Context Db;

        public Repository(string ConnectionString)
        {
            this.Db = new Context(ConnectionString);
        }

        public IEnumerable<User> GetUsers()
        {
            return Db.Users;
        }

        public User GetUser(int Id)
        {
            return Db.Users.Find(Id);
        }

        public void Create(User user)
        {
            Db.Users.Add(user);
        }

        public void Update(User user)
        {
            Db.Entry(user).State = System.Data.Entity.EntityState.Modified;
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }

}
