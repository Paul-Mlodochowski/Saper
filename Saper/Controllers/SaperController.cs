using Microsoft.AspNetCore.Mvc;
using Saper.Models.SaperLogic;

namespace Saper.Controllers
{
    public class SaperController : Controller
    {
        private static AbstractGameBoard gameBoard;
        public IActionResult Index() {
            if (gameBoard != null)
                return View(gameBoard);
            gameBoard = new GameBoard();
            gameBoard = new SmallSizeDecorator(gameBoard);
            gameBoard.SetBombsToBoard();
            return View(gameBoard);
        }
        
        public IActionResult Check(int x, int y) {
            if(gameBoard.Board[x,y] == -1)
                return RedirectToAction("Index","Home");

            return RedirectToAction("Index");
        }
      
        
    }
}
