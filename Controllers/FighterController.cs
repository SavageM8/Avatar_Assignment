using Microsoft.AspNetCore.Mvc;
using Avatar.Models;
using Avatar.Data;
using System.Collections.Generic;

namespace Avatar.Controllers
{
    public class FighterController : Controller
    {
        private readonly ApplicationDBContext _db;

        public FighterController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Fighters> objList = _db.Fighters;           
            return View(objList);
        }
        public IActionResult Create()
        {
            return View();
        }
        
    }
}
