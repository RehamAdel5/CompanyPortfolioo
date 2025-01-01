using CompanyPortfolioo.Domain;
using CompanyPortfolioo.Interfaces;
using CompanyPortfolioo.ViewModels;
using Microsoft.EntityFrameworkCore;
namespace CompanyPortfolioo.Services
{

    public class ContactUsRepository : IContactUsRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactUsRepository(ApplicationDbContext context)
        { _context = context; }
        public async Task<ContactUsViewModel> GetContactUsAsync()
        {
            var contactUsList = await _context.ContactUs.ToListAsync();
            var contactUs = contactUsList.FirstOrDefault();

            if (contactUs != null)
            {
                return new ContactUsViewModel
                {
                    Address = contactUs.Address,
                    Email = contactUs.Email,
                    FacebookUrl = contactUs.FacebookUrl,
                    InstagramUrl = contactUs.InstagramUrl,
                    Latitude = contactUs.Latitude,
                    LinkedInUrl = contactUs.LinkedInUrl,
                    Longitude = contactUs.Longitude,
                    Phone = contactUs.Phone,
                    TwitterUrl = contactUs.TwitterUrl
                };
            }

            return new ContactUsViewModel();
        }

    }
}
