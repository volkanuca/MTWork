using MTWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTWork.Business.UserOperations
{
    public class LoginResult:QueryResult
    {
        public User? User{ get; set; }

    }
}
