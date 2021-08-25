using AutoMapper;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Application.Helpers.ProfileDto
{
    public class WindonsFormsUsingDIProfile : Profile
    {
        public WindonsFormsUsingDIProfile()
        {
            CreateMap<Dono, DonoDto>().ReverseMap();
        }
    }
}
