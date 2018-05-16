using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Logger
    {
        private static string LogPath = @"C:\Users\Admin\Desktop\NW\log.txt";
        public static void Log(string message)
        {
            using (StreamWriter sw = new StreamWriter(LogPath, true))
            {
                sw.WriteLine(DateTime.Now.ToString() + ": " + message);
            }
        }
    }

    //namespace DALL
    //{
    //    using System;
    //    using System.Collections.Generic;
    //    using System.ComponentModel.DataAnnotations;
    //    using System.Data.Entity;
    //    using System.Linq;

    //    public class Model1 : DbContext
    //    {
    //        public Model1()
    //            : base("name=Model1")
    //        {

    //        }
    //        public virtual DbSet<Users> Userss { get; set; }
    //        public virtual DbSet<Products> Productss { get; set; }
    //        public virtual DbSet<Orders> Orderss { get; set; }

    //    }

    //    public class Users
    //    {
    //        //public Users()
    //        //{
    //        //    Productss = new List<Products>();
    //        //    Orderss = new List<Orders>();
    //        //}
    //        [Required]
    //        public int ID { get; set; }
    //        [Required]
    //        public string Name { get; set; }
    //        [Required]
    //        public string PassWord { get; set; }

    //        public double Balance { get; set; }
    //        [Required]
    //        public string Email { get; set; }

    //        //public virtual ICollection<Products> Productss { get; set; }
    //        //public virtual ICollection<Orders> Orderss { get; set; }
    //    }

    //    public class Products
    //    {
    //        //public Products()
    //        //{
    //        //    Userss = new List<Users>();
    //        //}
    //        [Required]
    //        public int ID { get; set; }
    //        [Required]
    //        public string Name { get; set; }

    //        public string Type { get; set; }
    //        [Required]
    //        public double Price { get; set; }
    //        [Required]
    //        public int Count { get; set; }

    //        //public virtual ICollection<Users> Userss { get; set; }
    //    }

    //    public class Orders
    //    {
    //        //public Orders()
    //        //{
    //        //    Userss = new List<Users>();
    //        //}
    //        [Required]
    //        public int ID { get; set; }
    //        [Required]
    //        public int usersId { get; set; }
    //        [Required]
    //        public int productsId { get; set; }
    //        [Required]
    //        public DateTime DataOfOrder { get; set; }
    //        //public virtual ICollection<Users> Userss { get; set; }
    //    }

    //}
}
