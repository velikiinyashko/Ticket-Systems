using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SystemsLogic
{
    public class Context : DbContext
    {

        public Context()
        {

        }

        public Context(string ConnectionBaseString) : base(ConnectionBaseString)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
