﻿namespace CompanyPortfolioo.Domain
{
    public class ProjectCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
