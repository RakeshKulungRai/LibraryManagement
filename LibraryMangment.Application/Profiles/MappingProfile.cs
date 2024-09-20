using AutoMapper;
using LibraryManagment.Domain;
using LibraryMangment.Application.DTOs.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.Profiles
{
    internal class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Member,MemberDto>().ReverseMap();
        }
    }
}
