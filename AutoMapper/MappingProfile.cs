using AutoMapper;
using CompanyPortfolioo.Domain;
using CompanyPortfolioo.ViewModels;

namespace CompanyPortfolioo.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AboutUs, AboutViewModel>().ReverseMap();

            CreateMap<AskedQuestion, AskedQuestionsViewModel>().ReverseMap();
            CreateMap<CompanyInformation, CompanyInformationViewModel>().ReverseMap();
            CreateMap<ContactUs, ContactUsViewModel>().ReverseMap();
            CreateMap<HorizontalSlider, HorizontalSliderViewModel>().ReverseMap();

            CreateMap<Features, PricingViewModel>()
                .ForMember(dest => dest.PlanName, opt => opt.MapFrom(src => src.Pricing.PlanName))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Pricing.Price))
                .ForMember(dest => dest.IsActive, opt => opt.MapFrom(src => src.Pricing.IsActive))
                .ForMember(dest => dest.FeatureId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.PriceId, opt => opt.MapFrom(src => src.Pricing.Id));

            CreateMap<Project, ProjectViewModel>()
                .ForMember(dest => dest.ProjectCategoryName, opt => opt.MapFrom(src => src.ProjectCategory.Name))
                .ForMember(dest => dest.ProjectCategoryDescription, opt => opt.MapFrom(src => src.ProjectCategory.Description))
                .ReverseMap();
            CreateMap<ProjectCategory, ProjectCategoryViewModel>().ReverseMap();
            CreateMap<ProjectDetails, ProjectDetailsViewModel>().ReverseMap();
            CreateMap<Service, ServicesViewModel>().ReverseMap();
            CreateMap<Skill, SkillsViewModel>().ReverseMap();
            CreateMap<Team, TeamViewModel>().ReverseMap();
            CreateMap<WhyUs, WhyUsViewModel>().ReverseMap();
            CreateMap<Testimonial, TestimonialViewModel>().ReverseMap();



        }
    }
}
