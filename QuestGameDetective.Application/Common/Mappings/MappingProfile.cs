using AutoMapper;
using QuestGameDetective.Application.Dtos.Case;
using QuestGameDetective.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuestGameDetective.Application.Common.Mappings;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<MurderCase, CaseReadDto>();

        CreateMap<Suspect, SuspectDto>();
    }
}