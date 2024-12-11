using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPortfolioo.Models
{
    public class ProjectDetail
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [ForeignKey("Testimonial")]
        public int TestimonialId { get; set; }
        public Testimonial Testimonial { get; set; }
    }
}
