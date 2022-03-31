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
            if (gameBoard.Board[x, y] == -1)
                return RedirectToAction("Index", "Home");
            else if (gameBoard.Board[x, y] == 0) {
                 int axis = (int)Math.Sqrt(gameBoard.GetSize())-1;
                Seeking(gameBoard.Board, axis, x, y);

            }

            gameBoard.ClickedXY()[x,y] = 1; // One - Clicked

            return RedirectToAction("Index");
        }
        private static int[,] Seeking(int[,] Tab,int axis, int x, int y) {
            if ( x>= axis || y >= axis || y < 0 || x < 0)
                return Tab;
			if (Tab[x, y] != 0) {
                gameBoard.ClickedXY()[x, y] = 1;
                return Tab;
            }

            if(Seeking(Tab,axis, x+1,y)[x,y] == 0) {
                gameBoard.ClickedXY()[x, y] = 1;
                
            }
            if (Seeking(Tab, axis, x, y+1)[x, y] == 0) {
                gameBoard.ClickedXY()[x, y] = 1;

            }
            if (Seeking(Tab, axis, x + 1, y + 1)[x, y] == 0) {
                gameBoard.ClickedXY()[x, y] = 1;

            }
           
            // Nie mam pojęcia dlaczego przy wartosci y-1 wyskakuje jakas pętla (nie chciało od y odjąc jeden)
            /*  if ( Seeking(Tab, axis, x + 1, y+1)[x, y] == 0) {
                  gameBoard.ClickedXY()[x, y] = 1;

              } 
              if ( Seeking(Tab, axis, x, y+1)[x, y] == 0) {
                  gameBoard.ClickedXY()[x, y] = 1;

              }
              if(Seeking(Tab,axis, x-1,y)[x,y] == 0) {
                  gameBoard.ClickedXY()[x, y] = 1;

              }

              if ( Seeking(Tab, axis, x - 1, y - 1)[x, y] == 0) {
                  gameBoard.ClickedXY()[x, y] = 1;

              }
              if ( Seeking(Tab, axis, x , y - 1)[x, y] == 0) {
                  gameBoard.ClickedXY()[x, y] = 1;

              }*/


            return Tab;
		}
      
        
    }
}
