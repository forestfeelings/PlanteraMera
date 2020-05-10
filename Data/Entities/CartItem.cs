using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanteraMera.Data.Entities
{
    public class CartItem
    {
        public Guid CartItemId { get; set; }
        public Seed Seed { get; set; }
        public int Amount { get; set; }
        public string CartId { get; set; }
    }
}
