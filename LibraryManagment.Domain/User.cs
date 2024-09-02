using LibraryManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagment.Domain
{
    public class UserLogin:BaseDomainEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Member Member { get; set; }
        public string Role { get; set; }
    }
}
