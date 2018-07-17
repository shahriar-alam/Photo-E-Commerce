using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECEntity
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public int sellerId { get; set; }
        public int buyerId { get; set; }
        public int ItemId { get; set; }
        public int ItemPrice { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string TransactionDate { get; set; } //= DateTime.Today;
        
        public virtual User User { get; set; }
        public virtual Stash Stash { get; set; }

    }

}
