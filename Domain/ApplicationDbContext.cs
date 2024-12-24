using Microsoft.EntityFrameworkCore;

namespace CompanyPortfolioo.Domain
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSets for each entity
        public DbSet<Service> Services { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<ProjectDetails> ProjectDetails { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<HorizontalSlider> HorizontalSliders { get; set; }
        public DbSet<AskedQuestion> AskedQuestions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<ProjectImage> ProjectImages { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<CompanyInformation> CompanyInformation { get; set; }
        public DbSet<WhyUs> WhyUs { get; set; }
        public DbSet<Features> Features { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity relationships and constraints


            modelBuilder.Entity<ProjectDetails>()
                .HasOne(pd => pd.Testimonial)
                .WithMany()
                .HasForeignKey(pd => pd.TestimonialId);

            modelBuilder.Entity<ProjectDetails>()
                .HasOne(pd => pd.Project)
                .WithMany()
                .HasForeignKey(pd => pd.ProjectId);
        }
}
}
