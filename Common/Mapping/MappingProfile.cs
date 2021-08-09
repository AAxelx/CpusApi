using AutoMapper;
using CpusApi.Data;
using CpusApi.Data.Entities;
using CpusApi.Models;
using CpusApi.Models.Responses;

namespace CpusApi.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CpuModel, CpuEntity>().ReverseMap();
            CreateMap<GetByPageResponse, PagingDataResult>().ReverseMap();
        }
    }
}
