using AutoMapper;
using Commander.Dtos;
using Commander.Models;

namespace Commander.Profiles
{
    public class AppMappingProfile : Profile
	{
		public AppMappingProfile()
		{
			CreateMap<Command, CommandReadDto>();
			CreateMap<CommandCreateDto, Command>();
			CreateMap<CommandUpdateDto, Command>();
		}
    }
}
