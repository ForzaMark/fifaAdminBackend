using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fifaAdministration.Features.Group
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService _groupService;

        public GroupController(IGroupService groupService)
        {
            _groupService = groupService;
        }

        [HttpGet("{GroupId}/Games")]
        public IActionResult GetAllGamesOfGroup(int GroupId)
        {
            _groupService.GetGamesOfGroup(GroupId);
            return Ok();
        }
    }
}
