using Microsoft.AspNetCore.Mvc;
using ProyectoTest.Models.Data;

namespace ProyectoTest.Controllers
{
    public class UserController : Controller
    {
        private TestDataBaseContext _db;
        public UserController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost
        public async Task<IActionResult> Create(User user)
        {
            if(ModelState.IsValid)
            {
                _db.Add(user);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
