using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SystemsLogic
{
    class User
    {
        [Key]
        public int IdUser { get; set; }
        [MinLength(4),MaxLength(20)]
        public string Login { get; set; }
        [MinLength(5),MaxLength(36)]
        public string Password { get; set; }

        public Client Client { get; set; }
    }

    class Client
    {
        [Key]
        public int IdClient { get; set; }
        [MinLength(2),MaxLength(36)]
        public string FirstName { get; set; }
        [MinLength(2),MaxLength(36)]
        public string SecondName { get; set; }
        [MinLength(2),MaxLength(36)]
        public string LastName { get; set; }
        [MinLength(2),MaxLength(64)]
        public string Company { get; set; }
        [MinLength(2),MaxLength(64)]
        public string City { get; set; }
        [MinLength(2), MaxLength(64)]
        public string Street { get; set; }
        
        public List<User> Users { get; set; }
    }

    class 
}
