﻿using Microsoft.AspNetCore.Mvc;
using Saper.Models.SaperLogic;

namespace Saper.Controllers
{
    public class SaperController : Controller {
        private static AbstractGameBoard? gameBoard;

        
        public IActionResult IndexSmall() {
            
             if (gameBoard != null && gameBoard.GetSize() == 100)
                return View(gameBoard);

            gameBoard = new GameBoard();
            gameBoard = new SmallSizeDecorator(gameBoard);
            gameBoard.SetBombsToBoard();
            return View(gameBoard);
        }
        public IActionResult IndexMedium() {
         
            if (gameBoard != null && gameBoard.GetSize() == 400)
                return View(gameBoard);
            gameBoard = new GameBoard();
            gameBoard = new MediumSizeDecorator(gameBoard);
            gameBoard.SetBombsToBoard();
            return View(gameBoard);
        }
        public IActionResult Check(int x, int y) {
            if (gameBoard.Board[x, y] == -1) {
                
                TempData["Failed"] = "Spróbuj jeszcze raz!";
                if (gameBoard.GetSize() == 100) {
                    gameBoard = null;
                    return RedirectToAction("IndexSmall");
                }
                else if (gameBoard.GetSize() == 400) {
                    gameBoard = null;
                    return RedirectToAction("IndexMedium");
                }
            }
            else if (gameBoard.Board[x, y] == 0) {
                int axis = (int)Math.Sqrt(gameBoard.GetSize()) - 1;
                Seeking(gameBoard.Board,gameBoard.ClickedXY(), axis, x, y);
                SeekingMinus(gameBoard.Board, gameBoard.ClickedXY(), axis, x, y);
            }

            gameBoard.ClickedXY()[x,y] = 1; // One - Clicked

            if (gameBoard.GetSize() == 100) 
                return RedirectToAction("IndexSmall");
            
            else if (gameBoard.GetSize() == 400)               
                return RedirectToAction("IndexMedium");
            
            return View();
        }
        private static bool? Seeking(int[,] Tab, int[,] Clicks, int axis, int x, int y) {
            if ( x> axis || y > axis || y < 0 || x < 0)
                return null;
			if (Tab[x, y] != 0) {
                Clicks[x, y] = 1;
                return null;
            }

            Seeking(Tab, Clicks, axis, x + 1, y);

            Seeking(Tab, Clicks, axis, x, y + 1);

            Seeking(Tab, Clicks, axis, x + 1, y + 1);
               Clicks[x,y] = 1;

     

            return null;
		}
        private static bool? SeekingMinus(int[,] Tab,int[,]Clicks, int axis, int x, int y) {
            if (x > axis || y > axis || y < 0 || x < 0)
                return null;

            if (Tab[x, y] != 0) {
                Clicks[x, y] = 1;
                return null;
            }
            SeekingMinus(Tab, Clicks, axis, x, y - 1);


            SeekingMinus(Tab, Clicks, axis, x - 1, y);


            SeekingMinus(Tab, Clicks, axis, x - 1, y - 1);
            Clicks[x, y] = 1;


            return null;
        }

    }
}
