using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPortfolioo.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string PlanName { get; set; }
        public double Price { get; set; }
        public string Features { get; set; }

    }
}
