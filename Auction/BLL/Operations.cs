using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Operations
    {
        public void Registration(string name, string password, string email)
        {
            User user = new Users
            {
                Name = name,
                PassWord = password,
                Email = email,
                Balance = 0
            };
            using (Model1 m1 = new Model1())
            {
                if (m1.Userss.FirstOrDefault(x => x.Name == user.Name) == null)
                {
                    m1.Userss.Add(user);
                }
            }
        }

        public void AddBalance(Users user, double money)
        {
            user.Balance += money;
        }

        public void AddProduct(string name, int count, string type, int price)
        {
            Products pro = new Products();
            pro.Name = name;
            pro.Count = count;
            pro.Type = type;
            pro.Price = price;
            using (Model1 m1 = new Model1())
            {
                m1.Productss.Add(pro);
            }

        }

        public void BuyProduct(Users u, Products pro, int count)
        {
            using (Model1 m1 = new Model1())
            {
                if (pro.Count >= count && u.Balance >= pro.Price * count)
                {
                    u.Balance -= pro.Price * count;
                    pro.Count = -count;

                    Orders or = new Orders() { productsId = pro.ID, usersId = u.ID, DataOfOrder = DateTime.Now };
                    m1.Orderss.Add(or);
                    m1.SaveChanges();
                }
            }
        }

        public void DeleteProduct(string name, int count)
        {
            Products pro = new Products();
            pro.Count = count;
            using (Model1 m1 = new Model1())
            {
                m1.Productss.Remove(pro);
            }
        }

        public List<Products> ShowAllProducts()
        {
            using (Model1 m1 = new Model1())
            {
                return m1.Productss.ToList();
            }
        }
    }
}
