using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        public DataContext _dbContext { get; }

        public UsersController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public ActionResult<ApiUser> GetUser(int id)
        {
            return _dbContext.Users.FirstOrDefault(user => user.Id == id);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ApiUser>> GetUsers()
        {
            return _dbContext.Users.ToList();
        }
    }
}