using EmpApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmpApi.Controllers
{
    [Route("api/[controller]")]
    public class EmpController : ControllerBase
    {
        IERepository rep;
        public EmpController(IERepository repo) 
        {
            rep = repo;
        }

        [Route("AllEmployees")]
        [HttpGet]
        public IActionResult ShowAllEmployees()
        {
            try
            {
                var request = rep.ShowAllEmployees();
                if (request != null)
                {
                    return Ok(request);
                }
                else { return BadRequest(); }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
