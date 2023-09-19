using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEF.Models
{
    [Table("Mehsul")]
    public class Product : BaseEntity
    {
        //[Column("Mehsulun adi", TypeName = "nvarchar(50)"), Required, MinLength(3)]
        public string Name { get; set; }


        //[Column("Mehsulun adi", TypeName = "decimal(15,2)")]
        public decimal? UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }



        // Relational Property
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}


// Convertion
// Data Annotation
// Fluent Api