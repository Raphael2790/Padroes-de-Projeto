using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Facade.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
