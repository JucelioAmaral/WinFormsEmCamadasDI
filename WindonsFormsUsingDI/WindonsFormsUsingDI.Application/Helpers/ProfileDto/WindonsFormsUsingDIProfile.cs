using AutoMapper;
using WindonsFormsUsingDI.Application.Dtos;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Application.Helpers.ProfileDto
{
    public class WindonsFormsUsingDIProfile : Profile
    {
        public WindonsFormsUsingDIProfile()
        {
            CreateMap<Dono, DonoDto>().ReverseMap();
            CreateMap<Cao, CaoDto>().ReverseMap();
        }
    }
}
