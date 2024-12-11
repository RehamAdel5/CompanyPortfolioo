using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPortfolioo.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PositionTitle { get; set; }
        public string Summary { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedInUrl { get; set; }

    }
}
