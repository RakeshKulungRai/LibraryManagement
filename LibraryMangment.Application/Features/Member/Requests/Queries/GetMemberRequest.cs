using LibraryMangment.Application.DTOs.Member;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangment.Application.Features.Member.Requests.Queries
{
    public class GetMemberRequest:IRequest<List<MemberDto>>
    {

    }
}
