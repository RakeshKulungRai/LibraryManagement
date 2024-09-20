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
    public class GetMemeberByIdRequestHandler:IRequestHandler<GetMemeberByIdRequest,MemberDto>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;
        public GetMemeberByIdRequestHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }
        public async Task<MemberDto> Handle(GetMemeberByIdRequest request, CancellationToken cancellationToken)
        {
            var member = await _memberRepository.Get(request.Id);
            member.Password = "";
            return _mapper.Map<MemberDto>(member);
        }
    }
}
