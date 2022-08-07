using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Models;
using Focal.Models;
using Focal.Services;

namespace Focal.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller {
        private readonly UserService service;
        public UserController(UserService service) {
            service = _service;
        }

        [HttpGet]
        public ActionResult<List<User>> GetUsers() {
            return service.GetUsers();
        }

        [HttpGet("{id:length(24)}")]
        public ActionResult<User> GetUser(string id) {
            var user = GetUser(id);

            if (user == null) {
                return NotFound();
            }

            return Json(user);
        }

        [HttpPost]
        public ActionResult<User> CreateUser(User user) {
            service.CreateUser(user);
            return Json(user);
        }
    }
}