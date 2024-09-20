using LibraryMangment.Application.DTOs.Author;
using LibraryMangment.Application.DTOs.Member;
using LibraryMangment.Application.Features.Member.Requests.Commands;
using LibraryMangment.Application.Features.Member.Requests.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagment.Web.Controllers.AdminPanel
{
    public class MemberController : Controller
    {
        private readonly IMediator _mediator;
        public MemberController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index()
        {
            IList<MemberDto> members = await _mediator.Send(new GetMemberRequest());
            return View(members);
        }
        public async Task<IActionResult> CreateEdit(int id)
        {
            MemberDto member = new MemberDto();
            if (id > 0)
            {
                 member = await _mediator.Send(new GetMemeberByIdRequest()
                {
                        Id = id,
                });
            }
            return View(member);
        }
        [Route("Member/Save")]
        public async Task<string> Save([FromForm] MemberDto member, [FromForm] IFormFile ImageFile)
        {
            if(ImageFile != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await ImageFile.CopyToAsync(memoryStream);
                    member.Image = memoryStream.ToArray();
                }
            }
            var response = await _mediator.Send(new CreateMemberRequest()
            {
                MemberDto = member,
            });
            if(response.Success)
            {
                return "success";
            }
            else
            {
                return "error";
            }
           
        }
    }
}
