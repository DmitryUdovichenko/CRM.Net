using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.DA.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Profession { get; set; }

        public int AvatarId { get; set; }
        public Avatar Avatar { get; set; }

        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public ICollection<PersonStage> PersonStages { get; set; }
    }
}
