using Microsoft.AspNetCore.Mvc;
using WepApp.Data;
using WepApp.Models;

namespace WepApp.Controllers
{
    public class ItemsController : Controller
    {
       private readonly AppDbContext _db;

        public ItemsController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Item> ItemsList=_db.Items.ToList();
            return View(ItemsList);
        }
    }
}
