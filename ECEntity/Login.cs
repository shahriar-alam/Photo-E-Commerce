using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECEntity
{
    public class Login
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "UserName cannot be empty")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password cannot be empty")] //[DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
