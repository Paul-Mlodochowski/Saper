namespace Saper.Models.SaperLogic
{
    public abstract class GameBoardDecorator : AbstractGameBoard
    {
        protected AbstractGameBoard _gameBoard;
        public override int[,] Board { get; set; }
        public GameBoardDecorator(AbstractGameBoard gameBoard) {
            _gameBoard = gameBoard;
        }
        public override int GetBoardTile(int a, int b) {
            return _gameBoard.GetBoardTile(a,b);
        }

        public override int GetSize() {
            _gameBoard.Board = Board; // To pass right size board
            return _gameBoard.GetSize();
        }
        public override void SetBombsToBoard() {
            _gameBoard.SetBombsToBoard();
        }
    }
}
