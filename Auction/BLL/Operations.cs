using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Reflection.Emit;

namespace BLL
{
    public class Operations
    {
        public static bool Registration(string name, float balance, string password, string email, int age)
        {
            User user = new User
            {
                NickName = name,
                Password = password,
                Email = email,
                Age = age,
                Balance = balance
            };
            //asd
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
        }

        public static void AddBalance(User user, float money)
        {
            user.Balance += money;
        }

        public static void AddItem(string name, int price, string info, string path, User user)
        {
            Item item = new Item
            {
                Price = price,
                Name = name,
                Info = info,
                ImgPath = path,
                User = user
            };
            using (Model1 m1 = new Model1())
            {
                m1.Items.Add(item);
                m1.SaveChanges();
            }
        }

        public static void AddAuction(Item item, string name)
        {
            Auction a = new Auction
            {
                Name = name,
                DateOfStart = DateTime.Now,
                Item = item
            };

            using (Model1 m1 = new Model1())
            {
                m1.Auctions.Add(a);
                m1.SaveChanges();
            }
        }

        public static void DelAuction(Auction a)
        {
            using (Model1 m1 = new Model1())
            {
                m1.Auctions.Remove(a);
                m1.SaveChanges();
            }
        }

        public static void DeleteItem(Item item)
        {
            using (Model1 m1 = new Model1())
            {
                m1.Items.Remove(item);
                m1.SaveChanges();
            }
        }

        public static List<Auction> ShowAllAuctions()
        {
            using (Model1 m1 = new Model1())
            {
                return m1.Auctions.ToList();
            }
        }

        public static float GetBalance(string name)
        {
            using (Model1 m1 = new Model1())
            {
                return m1.Users.FirstOrDefault(x => x.NickName == name).Balance;
            }
        }

        public static List<Item> ShowAllItems(string name)
        {
            using (Model1 m1 = new Model1())
            {
                return m1.Items.Where
                    (
                    x => x.User.Id == m1.Users.FirstOrDefault(y => y.NickName == name).Id
                    ).ToList();
            }
        }
    }
}