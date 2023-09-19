using LessonEF.Context;
using LessonEF.Enums;
using LessonEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LessonEF
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var context = new MyDbContext())
            //{
            //    context.Users.Add(new AppUser { });
            //    context.SaveChanges();
            //}


            //using (var context = new MyDbContext())
            //{
            //    var users = context.Users.ToList().Where(u=>u.Status != DataStatus.Deleted);
            //}


            //using (var context = new MyDbContext())
            //{
            //    var user = context.Users.ToList().Find(u=>u.Id == 2);

            //    user.Status = DataStatus.Deleted;
            //    //context.Users.Remove(user);
            //    context.SaveChanges();
            //}


            using (var context = new MyDbContext())
            {
                //var product = context.Products.Find(2);

                //if (product != null)
                //{
                //    product.Name = "samsung22";
                //    context.Products.Update(product);
                //    context.SaveChanges();
                //}
                //else
                //{
                //    Console.WriteLine("Tapilmadi");
                //}




                //var entity = new Product { Id = 2 };
                //context.Attach(entity);
                //entity.Name = "Test";
                //context.SaveChanges();



                //var entity = new Product { Id = 2 };
                //context.Entry(entity).State = EntityState.Deleted;
                //context.SaveChanges();



                //var result = context.Products.AsNoTracking().ToList();

            }




        }
    }
}



// Classes

// AppUser
// AppUserDetail
// Category
// Product
// Order
// OrderDetail



// One to One
// AppUser
// AppUserDetail


// One to Many
// Category Product
// AppUser Order



// Many to Many
// Product Order
// OrderDetail