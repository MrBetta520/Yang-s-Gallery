using Microsoft.AspNetCore.Mvc;
using Assignment12._2._2.Models;
using Microsoft.AspNetCore.Authorization;

namespace Assignment12._2._2.Controllers
{
    public class DrawController : Controller
    {
        private IDraw _Draw;
        public DrawController(IDraw draw)
        {
            _Draw = draw;
        }
        public IActionResult Index()
        {
            DrawViewModel drawViewModel = new DrawViewModel();
            drawViewModel.Draws = _Draw.InitializeDraw();
            return View(drawViewModel);
        }

        public IActionResult Details(int? id)
        {
            var model = _Draw.GetDrawById(id);
            if(model == null)
            {
                return NotFound();
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult About()
        {
            return View();
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult Create(Draw obj)
        {
            if(ModelState.IsValid)
            {
                _Draw.AddDraw(obj);
            }
            ViewBag.Message = "New draw is created successfully!";
            return View();
        }
        [Authorize]
        public IActionResult Delete (int id)
        {
            _Draw.DeleteDraw(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public IActionResult Update(int id)
        {
            Draw draw = _Draw.GetDrawById(id);
            return View(draw);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Update(Draw obj, int id)
        {
            obj.Id = id;
            _Draw.UpdateDraw(obj);
            return RedirectToAction("Index");
        }
    }
}
