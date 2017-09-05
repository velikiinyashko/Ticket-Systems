using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

/*В данном файле строится модель таблиц базы данных используемые приложением
в текущем коде имена таблиц базы данных имеют тоже название что и класс
описывающий таблицу, в случае необходимости привязки модели к конкретной таблицы
к классу добавляеться аттрибут [Table("TableNameToBase")], пример:
    
    [Table("TableNameToBase")]
    class ClassName {
    //foo
    }

необходимо добавить имена полей базы данных имеют имя 
 */

namespace SystemsLogic.ORM
{
    //класс описывающий поля таблицы пользователя системы
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MinLength(4), MaxLength(20)]
        public string Login { get; set; }
        [MinLength(5), MaxLength(36)]
        public string Password { get; set; }
        public string Role { get; set; }

        //привязываем данного пользователя к конкретному клиенту
        public Client Client { get; set; }
        //привязываем к данному пользователю созданные им тикеты
        public ICollection<Ticket> Tickets { get; set; }

        public ICollection<Note> Notes { get; set; }
    }

    //класс описывающий поля таблицы компании клиента использующего систему
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [MinLength(2), MaxLength(36)]
        public string FirstName { get; set; }
        [MinLength(2), MaxLength(36)]
        public string SecondName { get; set; }
        [MinLength(2), MaxLength(36)]
        public string LastName { get; set; }
        [MinLength(2), MaxLength(64)]
        public string Company { get; set; }
        [MinLength(2), MaxLength(64)]
        public string City { get; set; }
        [MinLength(2), MaxLength(64)]
        public string Street { get; set; }

        //привязываем к конкретному клиенту список пользователей системы
        public ICollection<User> Users { get; set; }
    }

    //класс описывающий поля таблицы тикита
    public class Ticket
    {
        [Key]
        public int TiketId { get; set; }
        [MinLength(1), MaxLength(64)]
        public string Subject { get; set; }
        [MinLength(1), MaxLength(512)]
        public string TextTicket { get; set; }

        public byte[] ScreenShot { get; set; }
        public byte[] Attachet { get; set; }

        public User User { get; set; }
    }

    public class Note
    {
        [Key]
        public int NoteId { get; set; }
        public DateTime GetDateTimeNotes { get; set; }
        public string Subject { get; set; }
        public string TextNotes { get; set; }

        public User User { get; set; }
    }

    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        //public string
    }
}