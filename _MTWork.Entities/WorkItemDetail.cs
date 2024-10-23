using System;
using System.Collections.Generic;
using System.Text;

namespace MTWork.Entities
{
    public class WorkItemDetail:BaseEntity
    {
        public int WorkItemId { get; set; }
        public int? UserId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusId { get; set; }
    }
}
