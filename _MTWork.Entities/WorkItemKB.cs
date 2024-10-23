using System;
using System.Collections.Generic;
using System.Text;

namespace MTWork.Entities
{
    public class WorkItemKB:BaseEntity
    {
        public int WorkItemDetailId { get; set; }
        public int WorkItemId { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }
        public string[] ReferenceURL { get; set; }

    }
}
