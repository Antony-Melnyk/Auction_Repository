using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Operations
    {
        public static bool Registration(string name, string password, string email, int age)
        {
            User user = new User();
            user.NickName = name;
            user.Password = password;
            user.Email = email;
            user.Age = age;
            user.Balance = 0;
            using (Model1 m1 = new Model1())
            {
                if (m1.Users.FirstOrDefault(x => x.NickName == user.NickName) == null)
                {
                    m1.Users.Add(user);
                    m1.SaveChanges();
                    return true;
                }
                else return false;
            }
        }

        public static bool SignIn(string nickname, string pass)
        {
            using (Model1 m1 = new Model1())
            {
                if (m1.Users.FirstOrDefault(x => x.NickName == nickname && x.Password == pass) != null)
                    return true;
                else
                    return false;
            }

            //User u = m1.Users.FirstOrDefault(x => x.NickName == nickname && x.Password == pass);
            //return u;
        }

        public static void AddBalance(User user, float money)
        {
            user.Balance += money;
        }

        public static void AddItem(string name, int price, string info, User user)
        {
            Item item = new Item();
            item.Price = price;
            item.Name = name;
            item.Info = info;
            item.User = user;
            using (Model1 m1 = new Model1())
            {
                m1.Items.Add(item);
                m1.SaveChanges();
            }
        }

        public void AddAuction(Item item, string name)
        {
            Auction a = new Auction();
            a.Name = name;
            a.DateOfStart = DateTime.Now;
            a.Item = item;

            using (Model1 m1 = new Model1())
            {
                m1.Auctions.Add(a);
                m1.SaveChanges();
            }
        }

        public void DelAuction(Auction a)
        {
            using (Model1 m1 = new Model1())
            {
                m1.Auctions.Remove(a);
                m1.SaveChanges();
            }
        }

        public void DeleteItem(Item item)
        {
            using (Model1 m1 = new Model1())
            {
                m1.Items.Remove(item);
                m1.SaveChanges();
            }
        }

        public List<Auction> ShowAllAuctions()
        {
            using (Model1 m1 = new Model1())
            {
                return m1.Auctions.ToList();
            }
        }
    }
}