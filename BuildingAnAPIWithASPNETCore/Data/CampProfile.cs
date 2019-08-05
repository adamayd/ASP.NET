using AutoMapper;
using CoreCodeCamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCodeCamp.Data
{
    public class CampProfile : Profile
    {
        public CampProfile()
        {
            CreateMap<Camp, CampModel>()
                .ForMember(dest => dest.Venue, opt => opt.MapFrom(src => src.Location.VenueName))
                .ForMember(dest => dest.Address1, opt => opt.MapFrom(src => src.Location.Address1))
                .ForMember(dest => dest.Address2, opt => opt.MapFrom(src => src.Location.Address2))
                .ForMember(dest => dest.Address3, opt => opt.MapFrom(src => src.Location.Address3))
                .ForMember(dest => dest.CityTown, opt => opt.MapFrom(src => src.Location.CityTown))
                .ForMember(dest => dest.StateProvince, opt => opt.MapFrom(src => src.Location.StateProvince))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.Location.PostalCode))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Location.Country))
                .ReverseMap();

            CreateMap<Talk, TalkModel>()
                .ReverseMap()
                .ForMember(src => src.Camp, opt => opt.Ignore())
                .ForMember(src => src.Speaker, opt => opt.Ignore());

            CreateMap<Speaker, SpeakerModel>()
                .ReverseMap();
        }
        
    }
}
