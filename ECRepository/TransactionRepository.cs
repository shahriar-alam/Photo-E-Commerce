using ECEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRepository
{
    public class TransactionRepository
    {
        private ECDBContext context = new ECDBContext();

        public List<Transaction> GetAll()
        {
            return this.context.transactions.ToList();
        }

        public List<Transaction> GetBuyerbyId(int id)
        {

            return this.context.transactions.Where(p => p.buyerId == id).ToList();
        }

        public List<Transaction> GetSellerbyId(int id)
        {

            return this.context.transactions.Where(p => p.sellerId == id).ToList();
        }


        public int Insert(Transaction transaction)
        {
            this.context.transactions.Add(transaction);
            return this.context.SaveChanges();
        }

        public bool Match(User user, Stash stash)
        {
            var match = this.context.transactions.Where(p => p.buyerId == user.UserId && p.ItemId == stash.StashId);

            if (match.Count() == 0)
            {
                return true;
            }

            else return false;

        }

        public List<Transaction> GetTransactionByReport(string sort)
        {
            if (sort == "Date Ascending")
            {
                return this.context.transactions.OrderByDescending(s => s.TransactionDate).ToList();
            }

            else if (sort == "Date Descending")
            {
                return this.context.transactions.OrderBy(s => s.TransactionDate).ToList();
            }

            else if (sort == "Price Asscending")
            {
                return this.context.transactions.OrderBy(s => s.ItemPrice).ToList();
            }

            else if (sort == "Price Descending")
            {
                return this.context.transactions.OrderBy(s => s.ItemPrice).ToList();
            }

            else
                return this.context.transactions.ToList();

        }
    }
}
