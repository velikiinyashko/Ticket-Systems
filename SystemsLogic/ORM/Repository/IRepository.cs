using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemsLogic.ORM
{
    interface IRepository<T> : IDisposable
        where T : class
    {
        IEnumerable<T> GetDataList(); // Получение всех пользователей
        T GetData(int Id); // Получение пользователя по ID
        void Create(T Item); // Создание пользователя
        void Update(T Item); // Обнавление 
        void Delete(int Id); // Удаление пользователя по ID
        void Save(); // Запись даных в базу
    }
}
