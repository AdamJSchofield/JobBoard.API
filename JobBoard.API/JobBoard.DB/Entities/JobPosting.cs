using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoard.DB.Entities
{
    public class JobPosting: BaseEntity<int>
    {
        public string Comapany { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
    }
}
