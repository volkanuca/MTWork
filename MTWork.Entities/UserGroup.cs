using System;
using System.Collections.Generic;
using System.Text;

namespace MTWork.Entities
{
    public class UserGroup:BaseEntity
    {
        public string Name { get; set; }
        public string? Email { get; set; }
    }
}
