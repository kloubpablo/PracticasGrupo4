using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Repositories;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var users = _repository.GetAll();
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            _repository.Add(user);
            return RedirectToAction("Index");
        }
    }
}
