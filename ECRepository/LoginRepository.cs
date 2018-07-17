using ECEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRepository
{
    public class LoginRepository
    {
        private ECDBContext context = new ECDBContext();

        public bool Validate(Login user)
        {
            Login validUser = this.context.logins.SingleOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
            return validUser != null;
        }

        public int Insert(Login user)
        {
            this.context.logins.Add(user);
            return this.context.SaveChanges();
        }

        public int GetId(string name)
        {
            //return this.context.People.SingleOrDefault(p => p.Id == id);
            Login user = this.context.logins.SingleOrDefault(p => p.UserName == name);

            return user.UserId;
            //return this.context.SaveChanges();
        }
    }
}
