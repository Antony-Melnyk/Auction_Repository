namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Auction> Auctions { get; set; }
    }

    public class User
    {
        public User()
        {
            Items = new List<Item>();
        }

        public int Id { get; set; }
        [Required]
        public string NickName { get; set; }
        [Required]
        public string Password { get; set; }
        
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        public float Balance { get; set; }

        public virtual ICollection<Item> Items { get; set; }
    }

    public class Item
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Price { get; set; }
        [Required]
        public string Info { get; set; }
        [Required]
        public User User { get; set; }
    }

    public class Auction
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public Item Item { get; set; }
        [Required]
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfBuy { get; set; }
    }
}