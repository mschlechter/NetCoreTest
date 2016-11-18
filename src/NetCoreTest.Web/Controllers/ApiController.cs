using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NetCoreTest.Web.Controllers
{
  public class ApiController : Controller
  {
    [Route("api/hello")]
    public IActionResult Hello()
    {
      return Ok("Hello World from a controller");
    }
  }
}
