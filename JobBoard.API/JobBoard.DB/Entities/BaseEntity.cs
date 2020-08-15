using System;
using System.Collections.Generic;
using System.Text;

namespace JobBoard.DB.Entities
{
    public class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
