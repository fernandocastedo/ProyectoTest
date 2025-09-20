using Microsoft.AspNetCore.Mvc;
using ProyectoTest.Models.Data;
using System.Threading.Tasks;

namespace ProyectoTest.Controllers
{
    public class UserController : Controller
    {
        private TestDataBaseContext _db;
        public UserController()
        {
        }
        public async Task<IActionResult> Index()
        {
            var data = await _db.Users.ToListAsync();
            return View(data);
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
