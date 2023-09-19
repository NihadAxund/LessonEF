using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEF.Models
{
    public class OrderDetail : BaseEntity
    {

        //[Column(Order = 3)]
        public short Quantity { get; set; }
        public decimal? TotalPrice { get; set; }

        //[Key, Column(Order = 1)]
        public int OrderId { get; set; }

        //[Key, Column(Order = 2)]
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
