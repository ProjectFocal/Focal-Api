using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Focal.Models;
using Focal.Services;

namespace Focal.Controllers
{

    [Route("api/[controller")]
    [ApiController]

    public class USerController : Controller
    {
        private readonly UserService service;

        public USerController(UserService _service)
        {
            service = _service;
        }
    }

    [HttpGet]
    public ActionResult<List<User>> GetUsers()
    {
        return service.GetUsers();
    }

    [HttpGet("{id:length(24)")]

    public ActionResult<User> GetUser(string id)
    {
        var user = ServiceCollection.GetUser(id);

        return Json(user);
    }

    [HttpPost]

    public ActionResult<User> Create(User user)
    {
        ServiceCollection.Create(user);

        return Json(user);
    }
}
