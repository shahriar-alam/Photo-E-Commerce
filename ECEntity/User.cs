using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECEntity
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "UserName cannot be empty")][MaxLength(10, ErrorMessage = "Maximum 10 characters allowed")]
        [MinLength(5, ErrorMessage ="Minimun 5 characters allowed")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Name cannot be empty")][MaxLength(10, ErrorMessage = "Maximum 10 characters allowed")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email cannot be empty")][DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int Age { get; set; }

        //[DefaultValue(10)]
        public int Balance { get; set; }
        public virtual ICollection<Stash> Stashes { get; set; }
        public virtual ICollection<Transaction> Transactions{ get; set; }

       /* public User()
        {
            this.Stashes = new List<Stash>();
            this.Transactions = new List<Transaction>();
        }*/

    }


}
