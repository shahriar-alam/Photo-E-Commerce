using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECEntity
{
    public class UserStashData
    {
        [Key]
        public int id { get; set; }
        public User users { get; set; }
        public List<Stash> stashes { get; set; }
    }
}
