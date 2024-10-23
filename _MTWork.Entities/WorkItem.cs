using System;
using System.Collections.Generic;
using System.Text;

namespace MTWork.Entities
{
    public class WorkItem:BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int? CustomerId { get; set; }
        public int StatusId { get; set; }



    }
}
