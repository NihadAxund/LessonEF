using LessonEF.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEF.Models
{
    // Data Annotations
    public class AppUser : BaseEntity
    {
        //[Key]
        public string UserName { get; set; }
        public string Password { get; set; }

        [NotMapped]
        public string RePassword { get; set; }
        public Role Role { get; set; }


        // Relational Property or Navigation Property
        public virtual AppUserDetail AppUserDetails { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
