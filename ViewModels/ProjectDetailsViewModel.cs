using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyPortfolioo.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
                 
        public int TestimonialId { get; set; }
    }
}
