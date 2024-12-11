namespace CompanyPortfolioo.Domain
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
