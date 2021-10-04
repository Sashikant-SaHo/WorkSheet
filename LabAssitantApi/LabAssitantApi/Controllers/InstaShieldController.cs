using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LabAssitantApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LabAssitantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstaShieldController : ControllerBase
    {
        IEmpData empdata;
        public InstaShieldController(IEmpData _empData)
        {
            empdata = _empData;
        }

        [HttpGet("getdata")]
        public IActionResult getInstall()
        {
            return Ok(empdata.getData());
        }
    }
}