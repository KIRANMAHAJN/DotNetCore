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
        private readonly IData _data;

        public EmployeeDataController(IData data)
        {

           _data = data;
        }

        [HttpGet]
         public async Task<IActionResult> GetDataList()
        {
            var result = await _data.GetDataList();
            return Ok(result);

        }
    }
}
 