using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyPortfolioo.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string MainImagePath { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
    }
}
