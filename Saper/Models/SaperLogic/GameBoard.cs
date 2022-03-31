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
            if (Board == null)
                throw new ArgumentNullException(nameof(Board));
            int counter = 0;
            int x, y;
            Random random = new Random();
            do {

                x = random.Next((int)Math.Sqrt(Board.Length));
                y = random.Next((int)Math.Sqrt(Board.Length));
                if (Board[x, y] != -1) {
                    Board[x, y] = -1;
                    counter++;
                }
            } while (counter <= 10);
            SetClues();

        }
        private void SetClues() {
            int axis = (int)Math.Sqrt(Board.Length);
          
            for (int x = 0; x < axis; x++) {
                for (int y = 0; y < axis; y++) {
                    if (Board[x, y] == -1)
                        continue;
                    int counterOfBombs = 0;
                    if (y + 1 < axis && Board[x, y +1] == -1) // prawo
                        counterOfBombs++;
                    if (y + 1 < axis && x + 1 < axis && Board[x + 1, y + 1] == -1) // prawo dół
                        counterOfBombs++;
                    if (x + 1 < axis && Board[x + 1, y] == -1) // dół
                        counterOfBombs++;
                    if (x + 1 < axis && y - 1 >= 0 && Board[x + 1, y - 1] == -1) // dół lewo
                        counterOfBombs++;
                    if (y - 1 >= 0 && Board[x, y - 1] == -1) // lewo
                        counterOfBombs++;
                    if (x-1 >=0 && y - 1 >= 0 && Board[x - 1, y - 1] == -1) // lewo góra
                        counterOfBombs++;
                    if (x - 1 >= 0 && Board[x - 1, y] == -1) //  góra
                        counterOfBombs++;
                    if (x - 1 >= 0  && y + 1 < axis && Board[x - 1, y + 1] == -1) // góra prawo
                        counterOfBombs++;
                    Board[x, y] = counterOfBombs;
                }
            }
        }


    }
}
