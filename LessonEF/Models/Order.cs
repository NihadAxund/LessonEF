using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEF.Models
{
    public class Order : BaseEntity
    {

        //[ForeignKey("AppUser")]
        public int AppUserId { get; set; }

        // Relational Property

        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
