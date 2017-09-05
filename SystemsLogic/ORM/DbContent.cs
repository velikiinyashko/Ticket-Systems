using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SystemsLogic.Logs;

namespace SystemsLogic.ORM
{
    class GetDbContent<TEntity> : IGetDbContent<TEntity> where TEntity : class
    {
        private DbContext _context;
        private DbSet<TEntity> _dbSet;
        private EventLogs Logs = new EventLogs("DataBase");

        public GetDbContent(DbContext context)
        {
            try
            {
                _context = context;
                _dbSet = _context.Set<TEntity>();
            } catch(Exception ex)
            {
                Logs.LogText = ex.Message;
                Logs.WrineEventLogError();
            }
        }

        public IEnumerable<TEntity> GetAllData()
        {
            try
            {
                return _dbSet.ToList();
            }catch(Exception ex)
            {
                return null;
            }
        }

        public void Create(TEntity Items)
        {
            _dbSet.Add(Items);
            Save();
        }

        public void Update(TEntity Items)
        {
            _context.Entry(Items).State = EntityState.Modified;
            Save();
        }

        public void Delete(int Id)
        {
            TEntity entity = _dbSet.Find(Id);
            if(entity != null)
            {
                _dbSet.Remove(entity);
                Save();
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
