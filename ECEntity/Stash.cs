using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECEntity
{
    public class Stash
    {
        public int StashId { get; set; }
        public int SellerId { get; set; }
        public int Sold { get; set; }
        public int Price { get; set; }

        [Required(ErrorMessage = "Stash Name cannot be empty")][MaxLength(10, ErrorMessage = "Maximum 20 characters allowed")]
        public string StashName { get; set; }
        public string Tags { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Created { get; set; } //= DateTime.Today;
        public virtual User User { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }

        //public Stash()
        //{
           // this.Transactions = new List<Transaction>();
       // }
    }
}
