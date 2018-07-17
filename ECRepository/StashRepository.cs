using ECEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRepository
{
    public class StashRepository
    {
        private ECDBContext context = new ECDBContext();
        //private User user = new User();
        public List<Stash> GetAll()
        {
            return this.context.stashes.ToList();
            //return this.context.People.Where(p => p.Name.Contains("a") || p.Email.Contains("a")).ToList();
            //return new List<Person>();
        }

        
        public List<Stash> GetStashBySellerId(int id)
        {
            //User user = GetUser(id);
            //return this.context.stashes.SingleOrDefault(p => p.SellerId == id);
            //return this.context.stashes.Where(p => p.SellerId==id).ToList();
            //return new List<Person>();
            return this.context.stashes.Where(p => p.SellerId.Equals(id)).ToList();
        }

        public Stash Get(int id)
        {
            //var result = from p in this.context.People
            //             where p.Id == id
            //             select p;
            //List<Person> plist = result.ToList();
            //return plist[0];

            return this.context.stashes.SingleOrDefault(p => p.StashId == id);
        }

        public int Insert(Stash stash)
        {
            this.context.stashes.Add(stash);
            return this.context.SaveChanges();
        }

        public int Delete(int id)
        {
            Stash stashToDelete = this.Get(id);
            this.context.stashes.Remove(stashToDelete);
            return this.context.SaveChanges();
        }

        public List<Stash> GetStashByTag(string str)
        {
            //User user = GetUser(id);
            //return this.context.stashes.SingleOrDefault(p => p.SellerId == id);
            //return this.context.stashes.Where(p => p.SellerId==id).ToList();
            //return new List<Person>();
            return this.context.stashes.Where(p => p.Tags.Equals(str)).ToList();
        }

        public int GetLatestStash()
        {
            int max = this.context.stashes.Max(p => p.StashId);
            return max;
        }

        public List<Stash> GetStashBySortTag(string tag, string sort)
        {
            if(sort == "Price Descending")
            {
                return this.context.stashes.OrderByDescending(s => s.Price).Where(p => p.Tags.Equals(tag)).ToList();
            }

            else if (sort == "Price Ascending")
            {
                return this.context.stashes.OrderBy(s => s.Price).Where(p => p.Tags.Equals(tag)).ToList();
            }

            else
                return this.context.stashes.OrderByDescending(s => s.Sold).Where(p => p.Tags.Equals(tag)).ToList();

        }

        public int AddSold(Stash stash)
        {

            stash.Sold++;
            return this.context.SaveChanges();
        }
    }
}
