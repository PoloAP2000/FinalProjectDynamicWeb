using FinalProject_v2_.Interface;
using FinalProject_v2_.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_v2_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class APIController : ControllerBase
    {

            private readonly IUserRepository _userRepository;
            private readonly UserDBContext _userDbContext;

            public APIController(IUserRepository userRepository, UserDBContext userDbContext)
            {
                _userDbContext = userDbContext;
                _userRepository = userRepository;
            }


            [HttpGet]
            [Route("{id}")]
            public User GetById(int id)
            {
                return _userDbContext.Users.FirstOrDefault(P => P.Id == id);
            }

            //GET api/user
            [HttpGet]
            [Route("")]
            public IEnumerable<User> GetUsers()
            {
                return (_userRepository.AllUsers);
            }

        // POST: api/user
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            _userDbContext.Add(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        // PUT: api/user/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }
            _userDbContext.Update(user);
            return NoContent();
        }

        // DELETE: api/user/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var existingUser = _userRepository.GetUserById(id);
            if (existingUser == null)
            {
                return NotFound();
            }
            _userDbContext.Remove(id);
            return NoContent();
        }
    }
}
