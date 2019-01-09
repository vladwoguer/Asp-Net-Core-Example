using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.models;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private User[] users = new User[]
        {
            new User { id = 1, name = "Vladwoguer Bezerra", email = "vladwoguerbezerra@gmail.com", phone = "01111111", role = 1},
            new User { id = 2, name = "Tacila Magalhães", email = "vladwoguerbezerra@gmail.com", phone = "01111111", role = 1},
        };

        /// <summary>
        /// List all public gists sorted by most recently updated to least recently updated.
        /// </summary>
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return users;
        }

        /// <summary>
        /// Looks up some user by ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

      
    }
}
