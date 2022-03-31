namespace Saper.Domain.Saper.Tests
{
    public class GameBoard : AbstractGameBoard
    {
        public override int[,] Board { get; set; }
        
        public override int GetBoardTile(int a, int b) {
            return 0;
        }

        public override int GetSize() {
            return this.Board.Length;
        }



    }
}
