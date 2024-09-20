using LibraryMangment.Application.DTOs.Member;
using LibraryMangment.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.Features.Member.Requests.Commands
{
    public class CreateMemberRequest:IRequest<BaseCommandResponse>
    {
        public MemberDto MemberDto { get; set; }
    }
}
