using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsLogic.ORM
{
    interface IGetDbContent<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAllData();
        void Create(TEntity Items);
        void Update(TEntity Items);
        void Delete(int Id);
        void Save();
    }
}
