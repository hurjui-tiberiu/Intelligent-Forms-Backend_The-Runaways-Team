using AutoMapper;
using IntelligentFormsAPI.Application.Models.Submission;
using IntelligentFormsAPI.Domain.Entities;
using System.Text;

namespace IntelligentFormsAPI.Application.Mapper
{
    public class SubmissionProfile : Profile
    {
        public SubmissionProfile()
        {
            CreateMap<Submission, SubmissionRequestDto>()
            .ForMember(dest => dest.Content,
                opt => opt.MapFrom(src => Encoding.UTF8.GetString(Convert.FromBase64String(src.Content))));


            CreateMap<SubmissionDto, Submission>()
                .ForMember(dest => dest.Content,
                opt => opt.MapFrom(
                    src => Convert.ToBase64String(Encoding.UTF8.GetBytes(src.Content))));

        }
    }
}
