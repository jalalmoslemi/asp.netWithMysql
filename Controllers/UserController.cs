using Microsoft.AspNetCore.Mvc;
using MySqlConnector.Data;

namespace mysqlConnection.Controllers
{
  [Route("users")]
  [ApiController]
  public class UserController : ControllerBase
  {
    private readonly AppDbContext _context;
    public UserController(AppDbContext context)
    {
      _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
      var users = _context.Users.ToList();

      return Ok(users);
    }

  }
}