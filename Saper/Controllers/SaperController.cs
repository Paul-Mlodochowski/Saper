using Microsoft.AspNetCore.Mvc;
using Saper.Models.SaperLogic;

namespace Saper.Controllers
{
    public class SaperController : Controller
    {
        public IActionResult Index() {
            AbstractGameBoard gameBoard = new GameBoard();
            gameBoard = new SmallSizeDecorator(gameBoard);
            return View(gameBoard);
        }
    }
}
