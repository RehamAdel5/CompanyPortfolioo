using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
namespace CompanyPortfolioo.Models
{

    public class Testimonial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string PositionTitle { get; set; }
        public string ClientOpinion { get; set; }
        public int Stars { get; set; }



    }
}
