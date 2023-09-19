using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEF.Models
{
    public class AppUserDetail : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        // Foreign Key
        public int AppUserId { get; set; }


        // Relational Property
        public virtual AppUser AppUser { get; set; }
    }
}
