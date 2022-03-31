using Microsoft.AspNetCore.Mvc;
using Saper.Models.SaperLogic;

namespace Saper.Controllers
{
    public class SaperController : Controller {
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
            if (gameBoard.Board[x, y] == -1) {
                gameBoard = null;
                TempData["Failed"] = "Spróbuj jeszcze raz!";
                return RedirectToAction("Index");
            }
            else if (gameBoard.Board[x, y] == 0) {
                int axis = (int)Math.Sqrt(gameBoard.GetSize()) - 1;
                Seeking(gameBoard.Board, axis, x, y);
                SeekingMinus(gameBoard.Board, axis, x, y);
            }

            gameBoard.ClickedXY()[x,y] = 1; // One - Clicked

            return RedirectToAction("Index");
        }
        private static int[,] Seeking(int[,] Tab,int axis, int x, int y) {
            if ( x> axis || y > axis || y < 0 || x < 0)
                return Tab;
			if (Tab[x, y] != 0) {
                gameBoard.ClickedXY()[x, y] = 1;
                return Tab;
            }

            Seeking(Tab, axis, x + 1, y);


            Seeking(Tab, axis, x, y + 1);



            Seeking(Tab, axis, x + 1, y + 1);
                gameBoard.ClickedXY()[x, y] = 1;

            
           

            return Tab;
		}
        private static int[,] SeekingMinus(int[,] Tab, int axis, int x, int y) {
            if (x > axis || y > axis || y < 0 || x < 0)
                return Tab;

            if (Tab[x, y] != 0) {
                gameBoard.ClickedXY()[x, y] = 1;
                return Tab;
            }
            SeekingMinus(Tab, axis, x, y - 1);


            SeekingMinus(Tab, axis, x - 1, y);


            SeekingMinus(Tab, axis, x - 1, y - 1);
                  gameBoard.ClickedXY()[x, y] = 1;


            return Tab;
        }

    }
}
