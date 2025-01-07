using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using System.Formats.Tar;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthorization(options => {
    options.AddPolicy("RequireAdminRole",
    policy => policy.RequireRole("Admin"));
});




builder.Services.AddScoped<IServicesRepository, ServicesRepository>(); 
builder.Services.AddScoped<IHorizontalSliderRepository, HorizontalSliderRepository>(); 
builder.Services.AddScoped<IAboutRepository, AboutRepository>();
builder.Services.AddScoped<IWhyUsRepository, WhyUsRepository>();
builder.Services.AddScoped<ISkillsRepository, SkillsRepository>();
builder.Services.AddScoped<IProjectsRepository, ProjectsRepository>(); 
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IFeaturesRepository, FeaturesRepository>(); 
builder.Services.AddScoped<ITestimonialRepository, TestimonialRepository>(); 
builder.Services.AddScoped<IAskedQuestionRepository, AskedQuestionRepository>();
builder.Services.AddScoped<IContactUsRepository, ContactUsRepository>();
builder.Services.AddScoped<IProjectCategoryService, ProjectCategoryService>();
builder.Services.AddScoped<IProjectDetailsService, ProjectDetailsService>();

builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=DashBoard}/{action=index}/{id?}"
    );
app.Run();
