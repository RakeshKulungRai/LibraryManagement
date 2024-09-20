using AutoMapper;
using LibraryMangment.Application.Contracts.Persistance;
using LibraryMangment.Application.DTOs.Member;
using LibraryMangment.Application.Features.Member.Requests.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.Features.Member.Handlers.Queries
{
    public class GetMemberRequestHandler:IRequestHandler<GetMemberRequest,List<MemberDto>>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;
        public GetMemberRequestHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }
        public async Task<List<MemberDto>> Handle(GetMemberRequest request, CancellationToken cancellationToken)
        {
               var allMembers = await _memberRepository.GetAll();
                return _mapper.Map<List<MemberDto>>(allMembers);
            

        }
    }
}
