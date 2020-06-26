using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKTECO.TM.Entities.Entities;
using ZKTECO.TM.Services;
using ZKTECO.TM.WEB.WebUtils;

namespace ZKTECO.TM.WEB.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AttLogController : BaseController
    {
        private IAttLogService attLogService;

        public AttLogController(IAttLogService _attLogService)
        {
            attLogService = _attLogService;
        }

        [AllowAnonymous]
        [HttpPost("GetAllAttLogs")]
        public IActionResult GetAllAttLogs()
        {
            var listAttLogs = attLogService.FindAll();
            if (listAttLogs == null)
                return BadRequest(new { message = "Error Table AttLog" });

            return Ok(new
            {
                listAttLogs
            });
        }
        [AllowAnonymous]
        [HttpGet("page")]
        public ActionResult GetPage(int page, int pageSize, string search, string sortDirection, string sortColumn)
        {
            var result = attLogService.GetPage(page, pageSize, search, sortDirection, sortColumn);

            return Ok(new { Data = result });
        }
    }
}