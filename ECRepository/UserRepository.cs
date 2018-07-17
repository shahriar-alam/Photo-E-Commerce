using ECEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRepository
{
    public class UserRepository
    {
        private ECDBContext context = new ECDBContext();

        public List<User> GetAll()
        {
            return this.context.users.ToList();
        }

        public User GetUser(int id)
        {
            return this.context.users.SingleOrDefault(p => p.UserId == id);
        }

        public User Get(int id)
        {
            return this.context.users.SingleOrDefault(p => p.UserId == id);
        }

        public User GetByName(string name)
        {
            return this.context.users.SingleOrDefault(p => p.UserName == name);
        }

        public int Insert(User user)
        {
            this.context.users.Add(user);
            return this.context.SaveChanges();
        }

        public int Update(User user)
        {
            User UserToUpdate = this.Get(user.UserId);
            //UserToUpdate.UserName = user.UserName;
           
            UserToUpdate.Email = user.Email;
            UserToUpdate.Age = user.Age;
            UserToUpdate.FullName = user.FullName;
            UserToUpdate.Balance += user.Balance;
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            User UserToDelete = this.Get(id);
            this.context.users.Remove(UserToDelete);
            return this.context.SaveChanges();
        }

        public int UpdateBalance(User user)
        {
            User UserToUpdate = this.Get(user.UserId);
            //UserToUpdate.UserName = user.UserName;
            UserToUpdate.Email = user.Email;
            UserToUpdate.Age = user.Age;
            UserToUpdate.FullName = user.FullName;
            return this.context.SaveChanges();
        }

        public int AddBalance(User user, int balance)
        {
            /*
            User UserToUpdate = this.Get(user.UserId);
            //UserToUpdate.UserName = user.UserName;
            UserToUpdate.Email = user.Email;
            UserToUpdate.Age = user.Age;
            UserToUpdate.FullName = user.FullName;
            */

            user.Balance = user.Balance+balance;
            return this.context.SaveChanges();
        }

        public int RemoveBalance(User user, int balance)
        {
            user.Balance -= balance;
            return this.context.SaveChanges();
        }


    }
}
