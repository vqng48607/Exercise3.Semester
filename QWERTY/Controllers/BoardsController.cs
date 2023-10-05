using Microsoft.AspNetCore.Mvc;
using QWERTY.Models;
using System.Security.Cryptography.X509Certificates;

namespace QWERTY.Controllers
{
    public class BoardsController : Controller
    {
        Surfboard _sb;
        public BoardsController(Surfboard sb) 
        {
            _sb = sb;
        }
        public IActionResult Index()
        {
            var board = new Surfboard { Id = 1, Name = "Test" };
            return View(board);
        }
    }
}
