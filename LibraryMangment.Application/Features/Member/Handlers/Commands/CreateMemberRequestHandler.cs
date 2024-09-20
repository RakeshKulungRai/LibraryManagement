using AutoMapper;
using LibraryMangment.Application.Contracts.Persistance;
using LibraryMangment.Application.Features.Member.Requests.Commands;
using LibraryMangment.Application.Responses;
using LibraryMangment.Application.Utilities;
using MediatR;

namespace LibraryMangment.Application.Features.Member.Handlers.Commands
{
    public class CreateMemberRequestHandler : IRequestHandler<CreateMemberRequest, BaseCommandResponse>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly  IMapper _mapper;
        public CreateMemberRequestHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _mapper = mapper;
            _memberRepository = memberRepository;
        }
        public async Task<BaseCommandResponse> Handle(CreateMemberRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            try
            {
                var member = _mapper.Map<LibraryManagment.Domain.Member>(request.MemberDto);
                member.Password = Encryptions.HashWithSalt(member.Password);
                if (request.MemberDto.Id > 0)
                {
                    member = await _memberRepository.Update(member);
                    response.Success = true;
                    response.Message = "Update Successfully";
                }
                else
                {
                    member = await _memberRepository.Add(member);
                    response.Success = true;
                    response.Message = "Create Successfully";
                }
                response.Id = member.Id;
            } 
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
