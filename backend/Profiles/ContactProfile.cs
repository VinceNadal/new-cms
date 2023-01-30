using AutoMapper;
using backend.DTOs;
using backend.Models;

namespace backend.Profiles
{
    public class ContactProfile : Profile
    {
        public ContactProfile()
        {
            // create a map from Contact to ReadContactDto
            CreateMap<Contact, ReadContactDto>().ReverseMap();
            // create a map from CreateContactDto to Contact with an auto generated Guid for the ID
            CreateMap<CreateContactDto, Contact>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
            // create a map from UpdateContactDto to Contact
            CreateMap<UpdateContactDto, Contact>();
        }
    }
}
