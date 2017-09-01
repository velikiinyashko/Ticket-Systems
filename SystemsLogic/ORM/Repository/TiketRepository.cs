using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsLogic.ORM
{
    class TicketRepository : IRepository<Ticket>
    {
        private Context Db;

        public TicketRepository()
        {
            Db = new Context();
        }

        public IEnumerable<Ticket> GetDataList()
        {
            return Db.Tickets;
        }

        public Ticket GetData(int Id)
        {
            return Db.Tickets.Find(Id);
        }

        public void Create(Ticket ticket)
        {
            Db.Tickets.Add(ticket);
        }

        public void Update(Ticket ticket)
        {
            Db.Entry(ticket).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int Id)
        {

        }

        public void Save()
        {

        }

        public void Dispose()
        {

        }
    }
}
