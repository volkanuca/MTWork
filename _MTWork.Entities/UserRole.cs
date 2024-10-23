using System;
using System.Collections.Generic;
using System.Text;

namespace MTWork.Entities
{
    public class UserRole:BaseEntity
    {
        public int UserId { get; set; }
        public int UserGroupId { get; set; }
    }
}
