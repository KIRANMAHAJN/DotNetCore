using DotNetCore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDataController : ControllerBase
    {
        private readonly IData data;

        public EmployeeDataController(IData data)
        {

            this.data = data;
        }

        [HttpGet]
         public async Task<IActionResult> GetDataList()
        {
            var result = await _Data.GetDataList();
            return Ok(result);

        }
    }
}
 