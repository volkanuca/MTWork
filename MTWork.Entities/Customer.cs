using System;
using System.Collections.Generic;
using System.Text;

namespace MTWork.Entities
{
    public class Customer:BaseEntity
    {
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
    }
}
