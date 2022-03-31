using System;

namespace Saper.Models.SaperLogic
{
    public class GameBoard : AbstractGameBoard
    {
        // BOMBS are represents as -1
        public override int[,] Board { get; set; }
        
        public override int GetBoardTile(int a, int b) {
            return 0;
        }

        public override int GetSize() {
            return this.Board.Length;
        }
        public override void SetBombsToBoard() {
            int counter = 0;
            int x, y;
            Random random = new Random();
            do {

                x = random.Next((int)Math.Sqrt(Board.Length)+1);
                y = random.Next((int)Math.Sqrt(Board.Length)+1);
                if (Board[x, y] != -1) {
                    Board[x, y] = -1;
                    counter++;
                }
            } while (counter <= 10);
        }


    }
}
