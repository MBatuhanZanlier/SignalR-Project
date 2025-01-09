using AutoMapper;
using SignalR.API.DAL.Entities;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.DAL.Entities;

namespace SignalR.API.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap(); 
            CreateMap<About, CreateAboutDto>().ReverseMap(); 
            CreateMap<About, GetAboutDto>().ReverseMap(); 
            CreateMap<About, UpdateAboutDto>().ReverseMap(); 
        }
    }
}
