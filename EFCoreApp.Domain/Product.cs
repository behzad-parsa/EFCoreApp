using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreApp.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int? Quantity { get; set; }
    }
}
